using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto02Datos
{
    public partial class fmConsulta : Form
    {
        public fmConsulta()
        {
            InitializeComponent();
        }

        private void autorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librosDataSet);

        }

        private void fmConsulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librosDataSet.Materia' table. You can move, or remove it, as needed.
            this.materiaTableAdapter.Fill(this.librosDataSet.Materia);
            // TODO: This line of code loads data into the 'librosDataSet.Editorial' table. You can move, or remove it, as needed.
            this.editorialTableAdapter.Fill(this.librosDataSet.Editorial);
            // TODO: This line of code loads data into the 'librosDataSet.Libros' table. You can move, or remove it, as needed.
            this.librosTableAdapter.Fill(this.librosDataSet.Libros);
            // TODO: This line of code loads data into the 'librosDataSet.Autor' table. You can move, or remove it, as needed.
            this.autorTableAdapter.Fill(this.librosDataSet.Autor);

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (tbBuscar.Text != "")
            {
                autorBindingSource.Position = autorBindingSource.Find("nombre",
                tbBuscar.Text);
            }
        }

        private void tbBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btBuscar_Click(sender, e);
            }
        }

        private void ckInferior50_CheckedChanged(object sender, EventArgs e)
        {
            if (ckInferior50.Checked)
            {
                librosBindingSource.Filter = "precio <=50";
            }
            else
            {
                librosBindingSource.RemoveFilter();
            }
        }

        private void librosDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            stEstado.Items[1].Text = "Número de libros de este autor: "+ librosDataGridView.RowCount;

            float totPrecio = 0;
            for (int i = 0; i <= librosDataGridView.RowCount - 1; i++)
            {
                totPrecio += Convert.ToInt16(librosDataGridView.Rows[i].Cells[8].Value);
            } // Asegurarse de que el precio está en la columna 8

            stEstado.Items[3].Text = "Suma de precios: "+ totPrecio;

            stEstado.Items[5].Text = "Media de precios: " + totPrecio / librosDataGridView.RowCount;
        }
    }
}
