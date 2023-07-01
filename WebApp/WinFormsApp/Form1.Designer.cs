namespace WinFormsApp
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            cbTamañoPagina = new ComboBox();
            txtSearch = new TextBox();
            txtPageIndex = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(17, 95);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 635);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1109, 635);
            dataGridView1.TabIndex = 0;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = SystemColors.ButtonHighlight;
            btnSiguiente.Location = new Point(1000, 47);
            btnSiguiente.Margin = new Padding(4, 5, 4, 5);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(111, 38);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguiente >";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = SystemColors.ButtonHighlight;
            btnAnterior.Location = new Point(733, 47);
            btnAnterior.Margin = new Padding(4, 5, 4, 5);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(107, 38);
            btnAnterior.TabIndex = 2;
            btnAnterior.Text = "< Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // cbTamañoPagina
            // 
            cbTamañoPagina.FormattingEnabled = true;
            cbTamañoPagina.Items.AddRange(new object[] { "5", "10", "25", "50", "100" });
            cbTamañoPagina.Location = new Point(414, 47);
            cbTamañoPagina.Margin = new Padding(4, 5, 4, 5);
            cbTamañoPagina.Name = "cbTamañoPagina";
            cbTamañoPagina.Size = new Size(171, 33);
            cbTamañoPagina.TabIndex = 3;
            cbTamañoPagina.SelectedIndexChanged += cbTamañoPagina_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(17, 47);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(387, 31);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtPageIndex
            // 
            txtPageIndex.Location = new Point(877, 47);
            txtPageIndex.Margin = new Padding(4, 5, 4, 5);
            txtPageIndex.Name = "txtPageIndex";
            txtPageIndex.Size = new Size(88, 31);
            txtPageIndex.TabIndex = 5;
            txtPageIndex.TextChanged += txtPageIndex_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(txtPageIndex);
            Controls.Add(txtSearch);
            Controls.Add(cbTamañoPagina);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btnSiguiente;
        private Button btnAnterior;
        private ComboBox cbTamañoPagina;
        private TextBox txtSearch;
        private TextBox txtPageIndex;
    }
}