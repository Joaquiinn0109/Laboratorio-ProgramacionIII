using App.Core.Data;
using App.Core.Entities;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Email _emailSelecionado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CargarDatos()
        {
            //ListBox
            var emails = (new EmailRepository()).Buscar(txtSearch.Text);
            listBox1.DataSource = emails;
            listBox1.ValueMember = "Asunto";

            //ListView
            listView1.View = View.Details;
            listView1.Items.Clear();
            foreach (var email in emails)
            {
                ListViewItem item = new ListViewItem(email.Asunto);
                item.ForeColor = Color.Red;
                item.SubItems.Add(email.Id.ToString());
                listView1.Items.Add(item);
            }

            //checkedListBox
            checkedListBox1.Items.Clear();
            foreach (var email in emails)
            {
                checkedListBox1.Items.Add(email.Asunto);
            }

            //DataGrid
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = emails;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _emailSelecionado.Asunto = txtSeleccion.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _emailSelecionado = ((Email)listBox1.SelectedItem);

            txtSeleccion.Text = _emailSelecionado.Asunto;
        }
    }
}