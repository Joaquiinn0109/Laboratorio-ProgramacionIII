namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            dgMaterias = new DataGridView();
            Materia = new DataGridViewTextBoxColumn();
            materiasBindingSource = new BindingSource(components);
            panel2 = new Panel();
            dgAlumnos = new DataGridView();
            Alumno = new DataGridViewTextBoxColumn();
            Legajo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            alumnoListBindingSource = new BindingSource(components);
            alumnosBindingSource = new BindingSource(components);
            btnGenerarDatos = new Button();
            label1 = new Label();
            label2 = new Label();
            lblAlumno = new Label();
            lblMateria = new Label();
            btnBuscarMateria = new Button();
            btnBuscarAlumno = new Button();
            txtBusqueda = new TextBox();
            txtDatosAlumno = new TextBox();
            label3 = new Label();
            btnAgregarAlumno = new Button();
            txtNombreAlumno = new TextBox();
            txtApellidoAlumno = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgMaterias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materiasBindingSource).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alumnoListBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alumnosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgMaterias);
            panel1.Location = new Point(12, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 353);
            panel1.TabIndex = 0;
            // 
            // dgMaterias
            // 
            dgMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMaterias.Columns.AddRange(new DataGridViewColumn[] { Materia });
            dgMaterias.Dock = DockStyle.Fill;
            dgMaterias.Location = new Point(0, 0);
            dgMaterias.Name = "dgMaterias";
            dgMaterias.RowHeadersWidth = 62;
            dgMaterias.RowTemplate.Height = 33;
            dgMaterias.Size = new Size(214, 353);
            dgMaterias.TabIndex = 0;
            dgMaterias.CellMouseEnter += dgMaterias_CellMouseEnter;
            dgMaterias.SelectionChanged += dgMaterias_SelectionChanged;
            // 
            // Materia
            // 
            Materia.DataPropertyName = "MateriaId";
            Materia.HeaderText = "Materia";
            Materia.MinimumWidth = 8;
            Materia.Name = "Materia";
            Materia.Width = 150;
            // 
            // materiasBindingSource
            // 
            materiasBindingSource.DataSource = typeof(Materias_Alumnos.Materias);
            // 
            // panel2
            // 
            panel2.Controls.Add(dgAlumnos);
            panel2.Location = new Point(232, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(676, 353);
            panel2.TabIndex = 1;
            // 
            // dgAlumnos
            // 
            dgAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAlumnos.Columns.AddRange(new DataGridViewColumn[] { Alumno, Legajo, Nombre, Apellido });
            dgAlumnos.Dock = DockStyle.Fill;
            dgAlumnos.Location = new Point(0, 0);
            dgAlumnos.Name = "dgAlumnos";
            dgAlumnos.RowHeadersWidth = 62;
            dgAlumnos.RowTemplate.Height = 33;
            dgAlumnos.Size = new Size(676, 353);
            dgAlumnos.TabIndex = 0;
            dgAlumnos.CellMouseEnter += dgAlumnos_CellMouseEnter;
            // 
            // Alumno
            // 
            Alumno.DataPropertyName = "AlumnoId";
            Alumno.HeaderText = "Alumno";
            Alumno.MinimumWidth = 8;
            Alumno.Name = "Alumno";
            Alumno.Width = 111;
            // 
            // Legajo
            // 
            Legajo.DataPropertyName = "Legajo";
            Legajo.HeaderText = "Legajo";
            Legajo.MinimumWidth = 8;
            Legajo.Name = "Legajo";
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 114;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.Width = 114;
            // 
            // alumnoListBindingSource
            // 
            alumnoListBindingSource.DataMember = "AlumnoList";
            alumnoListBindingSource.DataSource = materiasBindingSource;
            // 
            // alumnosBindingSource
            // 
            alumnosBindingSource.DataSource = typeof(Materias_Alumnos.Alumnos);
            // 
            // btnGenerarDatos
            // 
            btnGenerarDatos.BackColor = Color.FromArgb(128, 255, 128);
            btnGenerarDatos.Location = new Point(12, 6);
            btnGenerarDatos.Name = "btnGenerarDatos";
            btnGenerarDatos.Size = new Size(144, 53);
            btnGenerarDatos.TabIndex = 2;
            btnGenerarDatos.Text = "Generar Datos";
            btnGenerarDatos.UseVisualStyleBackColor = false;
            btnGenerarDatos.Click += btnGenerarDatos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 512);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 3;
            label1.Text = "Materia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 512);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 4;
            label2.Text = "Alumno:";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Location = new Point(308, 512);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(0, 25);
            lblAlumno.TabIndex = 5;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(77, 512);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(0, 25);
            lblMateria.TabIndex = 6;
            // 
            // btnBuscarMateria
            // 
            btnBuscarMateria.Location = new Point(149, 65);
            btnBuscarMateria.Name = "btnBuscarMateria";
            btnBuscarMateria.Size = new Size(185, 34);
            btnBuscarMateria.TabIndex = 7;
            btnBuscarMateria.Text = "Buscar por Materia";
            btnBuscarMateria.UseVisualStyleBackColor = true;
            btnBuscarMateria.Click += btnBuscarMateria_Click;
            // 
            // btnBuscarAlumno
            // 
            btnBuscarAlumno.Location = new Point(149, 110);
            btnBuscarAlumno.Name = "btnBuscarAlumno";
            btnBuscarAlumno.Size = new Size(185, 34);
            btnBuscarAlumno.TabIndex = 8;
            btnBuscarAlumno.Text = "Buscar por Alumno";
            btnBuscarAlumno.UseVisualStyleBackColor = true;
            btnBuscarAlumno.Click += btnBuscarAlumno_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(12, 91);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(131, 31);
            txtBusqueda.TabIndex = 9;
            // 
            // txtDatosAlumno
            // 
            txtDatosAlumno.Location = new Point(340, 65);
            txtDatosAlumno.Multiline = true;
            txtDatosAlumno.Name = "txtDatosAlumno";
            txtDatosAlumno.Size = new Size(262, 79);
            txtDatosAlumno.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(340, 34);
            label3.Name = "label3";
            label3.Size = new Size(256, 25);
            label3.TabIndex = 11;
            label3.Text = "Datos del Alumno Encontrado:";
            // 
            // btnAgregarAlumno
            // 
            btnAgregarAlumno.BackColor = Color.FromArgb(128, 255, 128);
            btnAgregarAlumno.Location = new Point(815, 59);
            btnAgregarAlumno.Name = "btnAgregarAlumno";
            btnAgregarAlumno.Size = new Size(141, 75);
            btnAgregarAlumno.TabIndex = 12;
            btnAgregarAlumno.Text = "Agregar Alumno";
            btnAgregarAlumno.UseVisualStyleBackColor = false;
            btnAgregarAlumno.Click += btnAgregarAlumno_Click;
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Location = new Point(630, 50);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.Size = new Size(172, 31);
            txtNombreAlumno.TabIndex = 13;
            // 
            // txtApellidoAlumno
            // 
            txtApellidoAlumno.Location = new Point(630, 110);
            txtApellidoAlumno.Name = "txtApellidoAlumno";
            txtApellidoAlumno.Size = new Size(172, 31);
            txtApellidoAlumno.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(630, 20);
            label4.Name = "label4";
            label4.Size = new Size(175, 25);
            label4.TabIndex = 15;
            label4.Text = "Nombre del Alumno";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(630, 84);
            label5.Name = "label5";
            label5.Size = new Size(175, 25);
            label5.TabIndex = 16;
            label5.Text = "Apellido del Alumno";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(968, 545);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtApellidoAlumno);
            Controls.Add(txtNombreAlumno);
            Controls.Add(btnAgregarAlumno);
            Controls.Add(label3);
            Controls.Add(txtDatosAlumno);
            Controls.Add(txtBusqueda);
            Controls.Add(btnBuscarAlumno);
            Controls.Add(btnBuscarMateria);
            Controls.Add(lblMateria);
            Controls.Add(lblAlumno);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGenerarDatos);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Lista de Alumnos y Materias";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgMaterias).EndInit();
            ((System.ComponentModel.ISupportInitialize)materiasBindingSource).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)alumnoListBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)alumnosBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnGenerarDatos;
        private DataGridView dgMaterias;
        private DataGridView dgAlumnos;
        private BindingSource materiasBindingSource;
        private BindingSource alumnosBindingSource;
        private BindingSource alumnoListBindingSource;
        private Label label1;
        private Label label2;
        private Label lblAlumno;
        private Label lblMateria;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewTextBoxColumn Alumno;
        private DataGridViewTextBoxColumn Legajo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private Button btnBuscarMateria;
        private Button btnBuscarAlumno;
        private TextBox txtBusqueda;
        private TextBox txtDatosAlumno;
        private Label label3;
        private Button btnAgregarAlumno;
        private TextBox txtNombreAlumno;
        private TextBox txtApellidoAlumno;
        private Label label4;
        private Label label5;
    }
}