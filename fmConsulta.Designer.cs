namespace Proyecto02Datos
{
    partial class fmConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoAutorLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label nacionalidadLabel;
            System.Windows.Forms.Label comentarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmConsulta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckInferior50 = new System.Windows.Forms.CheckBox();
            this.comentarioTextBox = new System.Windows.Forms.TextBox();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosDataSet = new Proyecto02Datos.librosDataSet();
            this.nacionalidadTextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.codigoAutorTextBox = new System.Windows.Forms.TextBox();
            this.autorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.btBuscar = new System.Windows.Forms.ToolStripLabel();
            this.autorTableAdapter = new Proyecto02Datos.librosDataSetTableAdapters.AutorTableAdapter();
            this.tableAdapterManager = new Proyecto02Datos.librosDataSetTableAdapters.TableAdapterManager();
            this.editorialTableAdapter = new Proyecto02Datos.librosDataSetTableAdapters.EditorialTableAdapter();
            this.librosTableAdapter = new Proyecto02Datos.librosDataSetTableAdapters.LibrosTableAdapter();
            this.materiaTableAdapter = new Proyecto02Datos.librosDataSetTableAdapters.MateriaTableAdapter();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Editorial = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.editorialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stEstado = new System.Windows.Forms.StatusStrip();
            this.stEstadoItem0 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stEstadoItem1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stEstadoItem2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stEstadoItem3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stEstadoItem4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stEstadoItem5 = new System.Windows.Forms.ToolStripStatusLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource)).BeginInit();
            this.stEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoAutorLabel
            // 
            codigoAutorLabel.AutoSize = true;
            codigoAutorLabel.Location = new System.Drawing.Point(38, 55);
            codigoAutorLabel.Name = "codigoAutorLabel";
            codigoAutorLabel.Size = new System.Drawing.Size(88, 16);
            codigoAutorLabel.TabIndex = 2;
            codigoAutorLabel.Text = "Codigo Autor:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(252, 55);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(59, 16);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(39, 112);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(53, 16);
            ciudadLabel.TabIndex = 5;
            ciudadLabel.Text = "Ciudad:";
            // 
            // nacionalidadLabel
            // 
            nacionalidadLabel.AutoSize = true;
            nacionalidadLabel.Location = new System.Drawing.Point(285, 112);
            nacionalidadLabel.Name = "nacionalidadLabel";
            nacionalidadLabel.Size = new System.Drawing.Size(91, 16);
            nacionalidadLabel.TabIndex = 7;
            nacionalidadLabel.Text = "Nacionalidad:";
            // 
            // comentarioLabel
            // 
            comentarioLabel.AutoSize = true;
            comentarioLabel.Location = new System.Drawing.Point(553, 55);
            comentarioLabel.Name = "comentarioLabel";
            comentarioLabel.Size = new System.Drawing.Size(79, 16);
            comentarioLabel.TabIndex = 9;
            comentarioLabel.Text = "Comentario:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckInferior50);
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
            this.panel1.Size = new System.Drawing.Size(876, 195);
            this.panel1.TabIndex = 0;
            // 
            // ckInferior50
            // 
            this.ckInferior50.AutoSize = true;
            this.ckInferior50.Location = new System.Drawing.Point(302, 159);
            this.ckInferior50.Name = "ckInferior50";
            this.ckInferior50.Size = new System.Drawing.Size(184, 20);
            this.ckInferior50.TabIndex = 11;
            this.ckInferior50.Text = "Filtra precios inferior a 50€";
            this.ckInferior50.UseVisualStyleBackColor = true;
            this.ckInferior50.CheckedChanged += new System.EventHandler(this.ckInferior50_CheckedChanged);
            // 
            // comentarioTextBox
            // 
            this.comentarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorBindingSource, "Comentario", true));
            this.comentarioTextBox.Location = new System.Drawing.Point(638, 52);
            this.comentarioTextBox.Multiline = true;
            this.comentarioTextBox.Name = "comentarioTextBox";
            this.comentarioTextBox.ReadOnly = true;
            this.comentarioTextBox.Size = new System.Drawing.Size(226, 111);
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
            this.nacionalidadTextBox.Location = new System.Drawing.Point(397, 109);
            this.nacionalidadTextBox.Name = "nacionalidadTextBox";
            this.nacionalidadTextBox.ReadOnly = true;
            this.nacionalidadTextBox.Size = new System.Drawing.Size(128, 22);
            this.nacionalidadTextBox.TabIndex = 8;
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorBindingSource, "Ciudad", true));
            this.ciudadTextBox.Location = new System.Drawing.Point(103, 109);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.ReadOnly = true;
            this.ciudadTextBox.Size = new System.Drawing.Size(120, 22);
            this.ciudadTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(317, 52);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(208, 22);
            this.nombreTextBox.TabIndex = 4;
            // 
            // codigoAutorTextBox
            // 
            this.codigoAutorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autorBindingSource, "CodigoAutor", true));
            this.codigoAutorTextBox.Location = new System.Drawing.Point(132, 52);
            this.codigoAutorTextBox.Name = "codigoAutorTextBox";
            this.codigoAutorTextBox.ReadOnly = true;
            this.codigoAutorTextBox.Size = new System.Drawing.Size(62, 22);
            this.codigoAutorTextBox.TabIndex = 3;
            // 
            // autorBindingNavigator
            // 
            this.autorBindingNavigator.AddNewItem = null;
            this.autorBindingNavigator.BindingSource = this.autorBindingSource;
            this.autorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.autorBindingNavigator.DeleteItem = null;
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
            this.bindingNavigatorSeparator2,
            this.tbBuscar,
            this.btBuscar});
            this.autorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.autorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.autorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.autorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.autorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.autorBindingNavigator.Name = "autorBindingNavigator";
            this.autorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.autorBindingNavigator.Size = new System.Drawing.Size(876, 27);
            this.autorBindingNavigator.TabIndex = 2;
            this.autorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(100, 27);
            this.tbBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBuscar_KeyDown);
            // 
            // btBuscar
            // 
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(91, 24);
            this.btBuscar.Text = "Buscar autor";
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
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
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Autor_Libros";
            this.librosBindingSource.DataSource = this.autorBindingSource;
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AllowUserToAddRows = false;
            this.librosDataGridView.AllowUserToDeleteRows = false;
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Materia,
            this.Editorial,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.librosDataGridView.Location = new System.Drawing.Point(0, 195);
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.RowHeadersWidth = 51;
            this.librosDataGridView.RowTemplate.Height = 24;
            this.librosDataGridView.Size = new System.Drawing.Size(876, 374);
            this.librosDataGridView.TabIndex = 1;
            this.librosDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.librosDataGridView_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodigoLibro";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodigoLibro";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "CodigoMateria";
            this.Materia.DataSource = this.materiaBindingSource;
            this.Materia.DisplayMember = "Nombre";
            this.Materia.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Materia.HeaderText = "Materia";
            this.Materia.MinimumWidth = 6;
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            this.Materia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Materia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Materia.ValueMember = "CodigoMateria";
            this.Materia.Width = 125;
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "Materia";
            this.materiaBindingSource.DataSource = this.librosDataSet;
            // 
            // Editorial
            // 
            this.Editorial.DataPropertyName = "Codigoeditorial";
            this.Editorial.DataSource = this.editorialBindingSource;
            this.Editorial.DisplayMember = "Nombre";
            this.Editorial.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Editorial.HeaderText = "Editorial";
            this.Editorial.MinimumWidth = 6;
            this.Editorial.Name = "Editorial";
            this.Editorial.ReadOnly = true;
            this.Editorial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editorial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editorial.ValueMember = "CodigoEditorial";
            this.Editorial.Width = 125;
            // 
            // editorialBindingSource
            // 
            this.editorialBindingSource.DataMember = "Editorial";
            this.editorialBindingSource.DataSource = this.librosDataSet;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn3.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Codigoeditorial";
            this.dataGridViewTextBoxColumn4.HeaderText = "Codigoeditorial";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CodigoAutor";
            this.dataGridViewTextBoxColumn5.HeaderText = "CodigoAutor";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CodigoMateria";
            this.dataGridViewTextBoxColumn6.HeaderText = "CodigoMateria";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn7.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // stEstado
            // 
            this.stEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stEstadoItem0,
            this.stEstadoItem1,
            this.stEstadoItem2,
            this.stEstadoItem3,
            this.stEstadoItem4,
            this.stEstadoItem5});
            this.stEstado.Location = new System.Drawing.Point(0, 543);
            this.stEstado.Name = "stEstado";
            this.stEstado.Size = new System.Drawing.Size(876, 26);
            this.stEstado.TabIndex = 2;
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
            this.stEstadoItem1.Size = new System.Drawing.Size(151, 20);
            this.stEstadoItem1.Text = "toolStripStatusLabel2";
            // 
            // stEstadoItem2
            // 
            this.stEstadoItem2.AutoSize = false;
            this.stEstadoItem2.Name = "stEstadoItem2";
            this.stEstadoItem2.Size = new System.Drawing.Size(60, 20);
            // 
            // stEstadoItem3
            // 
            this.stEstadoItem3.Name = "stEstadoItem3";
            this.stEstadoItem3.Size = new System.Drawing.Size(151, 20);
            this.stEstadoItem3.Text = "toolStripStatusLabel4";
            // 
            // stEstadoItem4
            // 
            this.stEstadoItem4.AutoSize = false;
            this.stEstadoItem4.Name = "stEstadoItem4";
            this.stEstadoItem4.Size = new System.Drawing.Size(60, 20);
            // 
            // stEstadoItem5
            // 
            this.stEstadoItem5.Name = "stEstadoItem5";
            this.stEstadoItem5.Size = new System.Drawing.Size(151, 20);
            this.stEstadoItem5.Text = "toolStripStatusLabel1";
            // 
            // fmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 569);
            this.Controls.Add(this.stEstado);
            this.Controls.Add(this.librosDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "fmConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.fmConsulta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingNavigator)).EndInit();
            this.autorBindingNavigator.ResumeLayout(false);
            this.autorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialBindingSource)).EndInit();
            this.stEstado.ResumeLayout(false);
            this.stEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private librosDataSet librosDataSet;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private librosDataSetTableAdapters.AutorTableAdapter autorTableAdapter;
        private librosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator autorBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private librosDataSetTableAdapters.LibrosTableAdapter librosTableAdapter;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private librosDataSetTableAdapters.EditorialTableAdapter editorialTableAdapter;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.BindingSource editorialBindingSource;
        private librosDataSetTableAdapters.MateriaTableAdapter materiaTableAdapter;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private System.Windows.Forms.TextBox comentarioTextBox;
        private System.Windows.Forms.TextBox nacionalidadTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox codigoAutorTextBox;
        private System.Windows.Forms.ToolStripTextBox tbBuscar;
        private System.Windows.Forms.ToolStripLabel btBuscar;
        private System.Windows.Forms.CheckBox ckInferior50;
        private System.Windows.Forms.StatusStrip stEstado;
        private System.Windows.Forms.ToolStripStatusLabel stEstadoItem0;
        private System.Windows.Forms.ToolStripStatusLabel stEstadoItem1;
        private System.Windows.Forms.ToolStripStatusLabel stEstadoItem2;
        private System.Windows.Forms.ToolStripStatusLabel stEstadoItem3;
        private System.Windows.Forms.ToolStripStatusLabel stEstadoItem4;
        private System.Windows.Forms.ToolStripStatusLabel stEstadoItem5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Materia;
        private System.Windows.Forms.DataGridViewComboBoxColumn Editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}