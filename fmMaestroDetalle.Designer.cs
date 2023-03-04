namespace Proyecto02Datos
{
    partial class fmMaestroDetalle
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoAutorLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label nacionalidadLabel;
            System.Windows.Forms.Label comentarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMaestroDetalle));
            this.materiaTableAdapter = new Proyecto02Datos.librosDataSetTableAdapters.MateriaTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comentarioTextBox = new System.Windows.Forms.TextBox();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosDataSet = new Proyecto02Datos.librosDataSet();
            this.nacionalidadTextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.codigoAutorTextBox = new System.Windows.Forms.TextBox();
            this.autorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.autorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.acercaDeOption = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.consultaOption = new System.Windows.Forms.ToolStripLabel();
            this.stEstado = new System.Windows.Forms.StatusStrip();
            this.stEstadoItem0 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stEstadoItem1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.autorTableAdapter = new Proyecto02Datos.librosDataSetTableAdapters.AutorTableAdapter();
            this.tableAdapterManager = new Proyecto02Datos.librosDataSetTableAdapters.TableAdapterManager();
            this.editorialTableAdapter = new Proyecto02Datos.librosDataSetTableAdapters.EditorialTableAdapter();
            this.librosTableAdapter = new Proyecto02Datos.librosDataSetTableAdapters.LibrosTableAdapter();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorLibros = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSaveItem1 = new System.Windows.Forms.ToolStripButton();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.codigoLibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoeditorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.editorialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codigoAutorLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            nacionalidadLabel = new System.Windows.Forms.Label();
            comentarioLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingNavigator)).BeginInit();
            this.autorBindingNavigator.SuspendLayout();
            this.stEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLibros)).BeginInit();
            this.bindingNavigatorLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoAutorLabel
            // 
            codigoAutorLabel.AutoSize = true;
            codigoAutorLabel.Location = new System.Drawing.Point(79, 56);
            codigoAutorLabel.Name = "codigoAutorLabel";
            codigoAutorLabel.Size = new System.Drawing.Size(88, 16);
            codigoAutorLabel.TabIndex = 3;
            codigoAutorLabel.Text = "Codigo Autor:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(295, 56);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(59, 16);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(81, 102);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(53, 16);
            ciudadLabel.TabIndex = 5;
            ciudadLabel.Text = "Ciudad:";
            // 
            // nacionalidadLabel
            // 
            nacionalidadLabel.AutoSize = true;
            nacionalidadLabel.Location = new System.Drawing.Point(325, 102);
            nacionalidadLabel.Name = "nacionalidadLabel";
            nacionalidadLabel.Size = new System.Drawing.Size(91, 16);
            nacionalidadLabel.TabIndex = 7;
            nacionalidadLabel.Text = "Nacionalidad:";
            // 
            // comentarioLabel
            // 
            comentarioLabel.AutoSize = true;
            comentarioLabel.Location = new System.Drawing.Point(735, 56);
            comentarioLabel.Name = "comentarioLabel";
            comentarioLabel.Size = new System.Drawing.Size(79, 16);
            comentarioLabel.TabIndex = 9;
            comentarioLabel.Text = "Comentario:";
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(comentarioLabel);
            this.panel1.Controls.Add(this.comentarioTextBox);
            this.panel1.Controls.Add(nacionalidadLabel);
            this.panel1.Controls.Add(this.nacionalidadTextBox);
            this.panel1.Controls.Add(ciudadLabel);
            this.panel1.Controls.Add(this.ciudadTextBox);
            this.panel1.Controls.Add(nombreLabel);
            this.panel1.Controls.Add(this.nombreTextBox);
            this.panel1.Controls.Add(codigoAutorLabel);
            this.panel1.Controls.Add(this.codigoAutorTextBox);
            this.panel1.Controls.Add(this.autorBindingNavigator);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 162);
            this.panel1.TabIndex = 0;
            // 
            // comentarioTextBox
            // 
            this.comentarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorBindingSource, "Comentario", true));
            this.comentarioTextBox.Location = new System.Drawing.Point(820, 53);
            this.comentarioTextBox.Multiline = true;
            this.comentarioTextBox.Name = "comentarioTextBox";
            this.comentarioTextBox.ReadOnly = true;
            this.comentarioTextBox.Size = new System.Drawing.Size(251, 87);
            this.comentarioTextBox.TabIndex = 10;
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataMember = "Autor";
            this.autorBindingSource.DataSource = this.librosDataSet;
            // 
            // librosDataSet
            // 
            this.librosDataSet.DataSetName = "librosDataSet";
            this.librosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nacionalidadTextBox
            // 
            this.nacionalidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorBindingSource, "Nacionalidad", true));
            this.nacionalidadTextBox.Location = new System.Drawing.Point(422, 99);
            this.nacionalidadTextBox.Name = "nacionalidadTextBox";
            this.nacionalidadTextBox.ReadOnly = true;
            this.nacionalidadTextBox.Size = new System.Drawing.Size(200, 22);
            this.nacionalidadTextBox.TabIndex = 8;
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorBindingSource, "Ciudad", true));
            this.ciudadTextBox.Location = new System.Drawing.Point(140, 99);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.ReadOnly = true;
            this.ciudadTextBox.Size = new System.Drawing.Size(116, 22);
            this.ciudadTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(360, 53);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(325, 22);
            this.nombreTextBox.TabIndex = 5;
            // 
            // codigoAutorTextBox
            // 
            this.codigoAutorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorBindingSource, "CodigoAutor", true));
            this.codigoAutorTextBox.Location = new System.Drawing.Point(173, 53);
            this.codigoAutorTextBox.Name = "codigoAutorTextBox";
            this.codigoAutorTextBox.Size = new System.Drawing.Size(48, 22);
            this.codigoAutorTextBox.TabIndex = 4;
            // 
            // autorBindingNavigator
            // 
            this.autorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.autorBindingNavigator.BindingSource = this.autorBindingSource;
            this.autorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.autorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.autorBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.autorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.toolStripSeparator1,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.autorBindingNavigatorSaveItem,
            this.acercaDeOption,
            this.bindingNavigatorSeparator2,
            this.consultaOption});
            this.autorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.autorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.autorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.autorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.autorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.autorBindingNavigator.Name = "autorBindingNavigator";
            this.autorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.autorBindingNavigator.Size = new System.Drawing.Size(1109, 27);
            this.autorBindingNavigator.TabIndex = 3;
            this.autorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            this.bindingNavigatorDeleteItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bindingNavigatorDeleteItem_MouseDown);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // autorBindingNavigatorSaveItem
            // 
            this.autorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.autorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("autorBindingNavigatorSaveItem.Image")));
            this.autorBindingNavigatorSaveItem.Name = "autorBindingNavigatorSaveItem";
            this.autorBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.autorBindingNavigatorSaveItem.Text = "Save Data";
            this.autorBindingNavigatorSaveItem.Click += new System.EventHandler(this.autorBindingNavigatorSaveItem_Click_1);
            // 
            // acercaDeOption
            // 
            this.acercaDeOption.Name = "acercaDeOption";
            this.acercaDeOption.Size = new System.Drawing.Size(75, 24);
            this.acercaDeOption.Text = "Acerca de";
            this.acercaDeOption.Click += new System.EventHandler(this.acercaDeOption_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // consultaOption
            // 
            this.consultaOption.Name = "consultaOption";
            this.consultaOption.Size = new System.Drawing.Size(66, 24);
            this.consultaOption.Text = "Consulta";
            this.consultaOption.Click += new System.EventHandler(this.consultaOption_Click);
            // 
            // stEstado
            // 
            this.stEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stEstadoItem0,
            this.stEstadoItem1});
            this.stEstado.Location = new System.Drawing.Point(0, 479);
            this.stEstado.Name = "stEstado";
            this.stEstado.Size = new System.Drawing.Size(1109, 26);
            this.stEstado.TabIndex = 1;
            this.stEstado.Text = "statusStrip1";
            // 
            // stEstadoItem0
            // 
            this.stEstadoItem0.AutoSize = false;
            this.stEstadoItem0.Name = "stEstadoItem0";
            this.stEstadoItem0.Size = new System.Drawing.Size(60, 20);
            // 
            // stEstadoItem1
            // 
            this.stEstadoItem1.Name = "stEstadoItem1";
            this.stEstadoItem1.Size = new System.Drawing.Size(0, 20);
            // 
            // autorTableAdapter
            // 
            this.autorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutorTableAdapter = this.autorTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EditorialTableAdapter = this.editorialTableAdapter;
            this.tableAdapterManager.LibrosTableAdapter = this.librosTableAdapter;
            this.tableAdapterManager.MateriaTableAdapter = this.materiaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proyecto02Datos.librosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // editorialTableAdapter
            // 
            this.editorialTableAdapter.ClearBeforeFill = true;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Autor_Libros";
            this.librosBindingSource.DataSource = this.autorBindingSource;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CodigoLibro";
            this.dataGridViewTextBoxColumn6.HeaderText = "CodigoLibro";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn8.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Codigoeditorial";
            this.dataGridViewTextBoxColumn9.HeaderText = "Codigoeditorial";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CodigoAutor";
            this.dataGridViewTextBoxColumn10.HeaderText = "CodigoAutor";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CodigoMateria";
            this.dataGridViewTextBoxColumn11.HeaderText = "CodigoMateria";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn12.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // bindingNavigatorLibros
            // 
            this.bindingNavigatorLibros.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigatorLibros.BindingSource = this.librosBindingSource;
            this.bindingNavigatorLibros.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigatorLibros.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigatorLibros.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorLibros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1,
            this.bindingNavigatorSaveItem1});
            this.bindingNavigatorLibros.Location = new System.Drawing.Point(0, 162);
            this.bindingNavigatorLibros.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigatorLibros.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigatorLibros.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigatorLibros.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigatorLibros.Name = "bindingNavigatorLibros";
            this.bindingNavigatorLibros.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigatorLibros.Size = new System.Drawing.Size(1109, 27);
            this.bindingNavigatorLibros.TabIndex = 0;
            this.bindingNavigatorLibros.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            this.bindingNavigatorAddNewItem1.Click += new System.EventHandler(this.bindingNavigatorAddNewItem1_Click);
            this.bindingNavigatorAddNewItem1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bindingNavigatorAddNewItem1_MouseUp);
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem1.Text = "de {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            this.bindingNavigatorDeleteItem1.Click += new System.EventHandler(this.bindingNavigatorDeleteItem1_Click);
            this.bindingNavigatorDeleteItem1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bindingNavigatorDeleteItem1_MouseDown);
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSaveItem1
            // 
            this.bindingNavigatorSaveItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem1.Image")));
            this.bindingNavigatorSaveItem1.Name = "bindingNavigatorSaveItem1";
            this.bindingNavigatorSaveItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorSaveItem1.Text = "Save Data";
            this.bindingNavigatorSaveItem1.Click += new System.EventHandler(this.bindingNavigatorSaveItem1_Click);
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AllowUserToAddRows = false;
            this.librosDataGridView.AllowUserToDeleteRows = false;
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoLibroDataGridViewTextBoxColumn,
            this.Materia,
            this.tituloDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.codigoeditorialDataGridViewTextBoxColumn,
            this.codigoAutorDataGridViewTextBoxColumn,
            this.codigoMateriaDataGridViewTextBoxColumn,
            this.Editorial,
            this.precioDataGridViewTextBoxColumn});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(0, 192);
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.RowHeadersWidth = 51;
            this.librosDataGridView.Size = new System.Drawing.Size(1109, 288);
            this.librosDataGridView.TabIndex = 2;
            this.librosDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.librosDataGridView_CellEnter);
            // 
            // codigoLibroDataGridViewTextBoxColumn
            // 
            this.codigoLibroDataGridViewTextBoxColumn.DataPropertyName = "CodigoLibro";
            this.codigoLibroDataGridViewTextBoxColumn.HeaderText = "CodigoLibro";
            this.codigoLibroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoLibroDataGridViewTextBoxColumn.Name = "codigoLibroDataGridViewTextBoxColumn";
            this.codigoLibroDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoLibroDataGridViewTextBoxColumn.Width = 125;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "CodigoMateria";
            this.Materia.DataSource = this.materiaBindingSource;
            this.Materia.DisplayMember = "Nombre";
            this.Materia.HeaderText = "Materia";
            this.Materia.MinimumWidth = 6;
            this.Materia.Name = "Materia";
            this.Materia.ValueMember = "CodigoMateria";
            this.Materia.Width = 125;
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "Materia";
            this.materiaBindingSource.DataSource = this.librosDataSet;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.Width = 125;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoeditorialDataGridViewTextBoxColumn
            // 
            this.codigoeditorialDataGridViewTextBoxColumn.DataPropertyName = "Codigoeditorial";
            this.codigoeditorialDataGridViewTextBoxColumn.HeaderText = "Codigoeditorial";
            this.codigoeditorialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoeditorialDataGridViewTextBoxColumn.Name = "codigoeditorialDataGridViewTextBoxColumn";
            this.codigoeditorialDataGridViewTextBoxColumn.Visible = false;
            this.codigoeditorialDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoAutorDataGridViewTextBoxColumn
            // 
            this.codigoAutorDataGridViewTextBoxColumn.DataPropertyName = "CodigoAutor";
            this.codigoAutorDataGridViewTextBoxColumn.HeaderText = "CodigoAutor";
            this.codigoAutorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoAutorDataGridViewTextBoxColumn.Name = "codigoAutorDataGridViewTextBoxColumn";
            this.codigoAutorDataGridViewTextBoxColumn.Visible = false;
            this.codigoAutorDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoMateriaDataGridViewTextBoxColumn
            // 
            this.codigoMateriaDataGridViewTextBoxColumn.DataPropertyName = "CodigoMateria";
            this.codigoMateriaDataGridViewTextBoxColumn.HeaderText = "CodigoMateria";
            this.codigoMateriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoMateriaDataGridViewTextBoxColumn.Name = "codigoMateriaDataGridViewTextBoxColumn";
            this.codigoMateriaDataGridViewTextBoxColumn.Visible = false;
            this.codigoMateriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Editorial
            // 
            this.Editorial.DataPropertyName = "Codigoeditorial";
            this.Editorial.DataSource = this.editorialBindingSource;
            this.Editorial.DisplayMember = "Nombre";
            this.Editorial.HeaderText = "Editorial";
            this.Editorial.MinimumWidth = 6;
            this.Editorial.Name = "Editorial";
            this.Editorial.ValueMember = "CodigoEditorial";
            this.Editorial.Width = 125;
            // 
            // editorialBindingSource
            // 
            this.editorialBindingSource.DataMember = "Editorial";
            this.editorialBindingSource.DataSource = this.librosDataSet;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // fmMaestroDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 505);
            this.Controls.Add(this.bindingNavigatorLibros);
            this.Controls.Add(this.librosDataGridView);
            this.Controls.Add(this.stEstado);
            this.Controls.Add(this.panel1);
            this.Name = "fmMaestroDetalle";
            this.Text = "Libros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMaestroDetalle_FormClosing);
            this.Load += new System.EventHandler(this.fmMaestroDetalle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingNavigator)).EndInit();
            this.autorBindingNavigator.ResumeLayout(false);
            this.autorBindingNavigator.PerformLayout();
            this.stEstado.ResumeLayout(false);
            this.stEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLibros)).EndInit();
            this.bindingNavigatorLibros.ResumeLayout(false);
            this.bindingNavigatorLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private librosDataSetTableAdapters.MateriaTableAdapter materiaTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip stEstado;
        private System.Windows.Forms.ToolStripStatusLabel stEstadoItem0;
        private System.Windows.Forms.ToolStripStatusLabel stEstadoItem1;
        private librosDataSet librosDataSet;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private librosDataSetTableAdapters.AutorTableAdapter autorTableAdapter;
        private librosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator autorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton autorBindingNavigatorSaveItem;
        private librosDataSetTableAdapters.LibrosTableAdapter librosTableAdapter;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingNavigator bindingNavigatorLibros;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem1;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private librosDataSetTableAdapters.EditorialTableAdapter editorialTableAdapter;
        private System.Windows.Forms.BindingSource editorialBindingSource;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private System.Windows.Forms.TextBox comentarioTextBox;
        private System.Windows.Forms.TextBox nacionalidadTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox codigoAutorTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoLibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoeditorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel acercaDeOption;
        private System.Windows.Forms.ToolStripLabel consultaOption;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

