using Proyecto02Datos.librosDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto02Datos
{
    public partial class fmMaestroDetalle : Form
    {
        bool edicionAutor = false;
        bool edicionLibro = false;

        public fmMaestroDetalle()
        {
            InitializeComponent();
        }

        private void fmMaestroDetalle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librosDataSet.Editorial' table. You can move, or remove it, as needed.
            this.editorialTableAdapter.Fill(this.librosDataSet.Editorial);
            // TODO: This line of code loads data into the 'librosDataSet.Libros' table. You can move, or remove it, as needed.
            this.librosTableAdapter.Fill(this.librosDataSet.Libros);
            // TODO: This line of code loads data into the 'librosDataSet.Autor' table. You can move, or remove it, as needed.
            this.autorTableAdapter.Fill(this.librosDataSet.Autor);
            this.materiaTableAdapter.Fill(this.librosDataSet.Materia);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (librosDataSet.HasChanges()) //Hay cambios pendiente de guardar
            {
                autorTableAdapter.Update(librosDataSet.Autor);
                librosTableAdapter.Update(librosDataSet.Libros);
            }
            //Código usado en el formulario fmComandos. Genera nueva clave id con la
            // última guardada + 1
            DataTable miTabla = librosDataSet.Autor;
            DataRowCollection cfilas = miTabla.Rows;
            DataRow Fila;
            Fila = miTabla.Rows[miTabla.Rows.Count - 1];//rescato id de última fila
            int nuevoid = Convert.ToInt32(Fila[0]);
            nuevoid++;
            try
            {
                codigoAutorTextBox.Text = Convert.ToString(nuevoid);//Asignamos nuevo a textbox
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bindingNavigatorAddNewItem.Enabled = false; //Mientras se añade, si se
                                                        // vuelve a pulsar dará excepción, deshabilitado no se puede
            bindingNavigatorLibros.Enabled = false;
            nombreTextBox.Focus();
            edicionAutor = true;
        }

        private void autorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            if (nombreTextBox.Text == "") //Convertimos este campo en obligatorio
            {
                MessageBox.Show("Falta nombre");
                nombreTextBox.Focus();
            }
            else
            {
                try
                {
                    this.Validate(); //si se pone codigo en evento validated se ejecuta
                    this.autorBindingSource.EndEdit();//Aplica cambios al origen datos
                    this.tableAdapterManager.UpdateAll(this.librosDataSet); //Actualiza
                                                                                  // los cambios en el DataSet
                    bindingNavigatorAddNewItem.Enabled = true;
                    bindingNavigatorLibros.Enabled = true;
                }
                catch (ConstraintException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                edicionAutor = false; //Variable bool definida a nivel global e iniciada a false
                                 // Usaremos para comprobar los cambios pendientes de guardar
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorLibros.Enabled = true;
            edicionAutor = false;
            autorTableAdapter.Update(librosDataSet.Autor);
        }

        private void bindingNavigatorDeleteItem_MouseDown(object sender, MouseEventArgs e)
        {
            if(librosDataGridView.Rows.Count > 0)
            {
                MessageBox.Show("Este autor tiene " + librosDataGridView.Rows.Count.ToString() + " libros. No se puede borrar.");
                return;
            }
            DialogResult resultado = MessageBox.Show("Seguro que deseas Borrar? "
                + nombreTextBox.Text, "Borrar Datos", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No)
                return;
            else
            {
                bindingNavigatorDeleteItem.PerformClick();//click boton borrar de navigator
            }
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            if (librosDataSet.HasChanges()) //Hay cambios pendiente de guardar
            {
                autorTableAdapter.Update(librosDataSet.Autor);
                librosTableAdapter.Update(librosDataSet.Libros);
            }
            
            bindingNavigatorAddNewItem1.Enabled = false; //Mientras se añade, si se
                                                         // vuelve a pulsar dará excepción, deshabilitado no se puede
            autorBindingNavigator.Enabled = false;
            edicionLibro = true;
        }

        private void bindingNavigatorAddNewItem1_MouseUp(object sender, MouseEventArgs e)
        {
            //Código usado en el formulario fmComandos. Genera nueva clave id con la
            // última guardada + 1
            DataTable miTabla = librosDataSet.Libros.OrderBy(x => x.CodigoLibro).CopyToDataTable();
            DataRowCollection cfilas = miTabla.Rows;
            DataRow Fila;
            Fila = miTabla.Rows[miTabla.Rows.Count - 1];//rescato id de última fila
            int nuevoid = Convert.ToInt32(Fila[0]);
            nuevoid++;
            try
            {
                librosDataGridView.Rows[librosDataGridView.Rows.Count - 1].Cells[0].Value = nuevoid;
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem1.Enabled = true;
            autorBindingNavigator.Enabled = true;
            edicionLibro = false;
            librosTableAdapter.Update(librosDataSet.Libros);
        }

        private void bindingNavigatorDeleteItem1_MouseDown(object sender, MouseEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que deseas Borrar? "
                + librosDataGridView.Rows[librosDataGridView.CurrentCell.RowIndex].Cells[2].Value.ToString(), "Borrar Datos", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No)
                return;
            else
            {
                bindingNavigatorDeleteItem1.PerformClick();//click boton borrar de navigator
            }
        }

        private void bindingNavigatorSaveItem1_Click(object sender, EventArgs e)
        {
            if (librosDataGridView.Rows[librosDataGridView.CurrentCell.RowIndex].Cells[2].Value.ToString() == "") //Convertimos este campo en obligatorio
            {
                MessageBox.Show("Falta nombre");
                nombreTextBox.Focus();
            }
            else
            {
                try
                {
                    this.Validate(); //si se pone codigo en evento validated se ejecuta
                    this.librosBindingSource.EndEdit();//Aplica cambios al origen datos
                    this.tableAdapterManager.UpdateAll(this.librosDataSet); //Actualiza
                                                                            // los cambios en el DataSet
                    bindingNavigatorAddNewItem1.Enabled = true;
                    autorBindingNavigator.Enabled = true;
                }
                catch (ConstraintException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                edicionLibro = false; //Variable bool definida a nivel global e iniciada a false
                                      // Usaremos para comprobar los cambios pendientes de guardar
            }
        }

        private void fmMaestroDetalle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (edicionAutor ||edicionLibro || librosDataSet.HasChanges())
            {
                if (MessageBox.Show("¿Desea Grabar los cambios pendientes?", "Guardar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.librosBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.librosDataSet);
                    // telefonosTableAdapter.Update(bd_telefonosDataSet.telefonos);
                    // También se puede usar
                }
            }
        }

        private void librosDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            stEstado.Items[1].Text = // Usamos matriz Rows del DataGrid con fila y celda
                    Convert.ToString(librosDataGridView.Rows[e.RowIndex].Cells[2].Value);
        }

        private void consultaOption_Click(object sender, EventArgs e)
        {
            this.Hide();

            fmConsulta fmCons = new fmConsulta();

            fmCons.ShowDialog();

            this.Show();
        }

        private void acercaDeOption_Click(object sender, EventArgs e)
        {
            fmAcercade fmAcerca = new fmAcercade();
            fmAcerca.ShowDialog();
            fmAcerca.Dispose();
        }
    }
}
