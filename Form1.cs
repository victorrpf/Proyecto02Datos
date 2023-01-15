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
    public partial class fmMaestroDetalle : Form
    {
        public fmMaestroDetalle()
        {
            InitializeComponent();
        }

        private void autorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librosDataSet);

        }

        private void fmMaestroDetalle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'librosDataSet.Materia' Puede moverla o quitarla según sea necesario.
            this.materiaTableAdapter.Fill(this.librosDataSet.Materia);
            // TODO: esta línea de código carga datos en la tabla 'librosDataSet.Editorial' Puede moverla o quitarla según sea necesario.
            this.editorialTableAdapter.Fill(this.librosDataSet.Editorial);
            // TODO: esta línea de código carga datos en la tabla 'librosDataSet.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.librosDataSet.Libros);
            // TODO: esta línea de código carga datos en la tabla 'librosDataSet.Autor' Puede moverla o quitarla según sea necesario.
            this.autorTableAdapter.Fill(this.librosDataSet.Autor);

        }
    }
}
