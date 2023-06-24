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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Demo", "Colum2 Demo" }, -1);
            listBox1 = new ListBox();
            emailRepositoryBindingSource = new BindingSource(components);
            btnSearch = new Button();
            txtSearch = new TextBox();
            listView1 = new ListView();
            ColAsunto = new ColumnHeader();
            ColID = new ColumnHeader();
            checkedListBox1 = new CheckedListBox();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            btnGuardar = new Button();
            txtSeleccion = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)emailRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(26, 68);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(209, 354);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // emailRepositoryBindingSource
            // 
            emailRepositoryBindingSource.DataSource = typeof(App.Core.Data.EmailRepository);
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(255, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(145, 39);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(26, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(209, 31);
            txtSearch.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ColAsunto, ColID });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(241, 68);
            listView1.Name = "listView1";
            listView1.Size = new Size(287, 354);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ColAsunto
            // 
            ColAsunto.Text = "Asunto 1";
            // 
            // ColID
            // 
            ColID.Text = "Identificador";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(554, 68);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(274, 340);
            checkedListBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridView1.Location = new Point(870, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(360, 354);
            dataGridView1.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Asunto";
            dataGridViewTextBoxColumn1.HeaderText = "Asunto";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            dataGridViewTextBoxColumn2.HeaderText = "Id";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(26, 504);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtSeleccion
            // 
            txtSeleccion.Location = new Point(26, 467);
            txtSeleccion.Name = "txtSeleccion";
            txtSeleccion.Size = new Size(209, 31);
            txtSeleccion.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 438);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 8;
            label1.Text = "Seleccion:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 561);
            Controls.Add(label1);
            Controls.Add(txtSeleccion);
            Controls.Add(btnGuardar);
            Controls.Add(dataGridView1);
            Controls.Add(checkedListBox1);
            Controls.Add(listView1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)emailRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private BindingSource emailRepositoryBindingSource;
        private Button btnSearch;
        private TextBox txtSearch;
        private ListView listView1;
        private ColumnHeader ColAsunto;
        private ColumnHeader ColID;
        private CheckedListBox checkedListBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Button btnGuardar;
        private TextBox txtSeleccion;
        private Label label1;
    }
}