using App.Core.Business;
using App.Core.Entities;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private MailBusiness _mailBusiness;
        private int currentPageIndex = 1;
        private bool _txtPageIndexBlock = false;
        public Form1()
        {
            _mailBusiness = new MailBusiness();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTama�oPagina.SelectedIndex = cbTama�oPagina.FindStringExact("10");

            txtPageIndex.Text = currentPageIndex.ToString();
        }

        private void CargaDatos(int pageIndex)
        {
            var pageSize = int.Parse(cbTama�oPagina.SelectedItem.ToString());

            _txtPageIndexBlock = true;
            txtPageIndex.Text = pageIndex.ToString();
            _txtPageIndexBlock = false;

            var filter = new MailFilter()
            {
                TextToSearch = txtPageIndex.Text,
                PageIndex = pageIndex,
                PageSize = pageSize
            };

            var mails = _mailBusiness.Search(filter);

            dataGridView1.DataSource = mails;
            
        }

        private void cbTama�oPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPageIndex = 1;
            CargaDatos(currentPageIndex);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            currentPageIndex = 1;
            CargaDatos(currentPageIndex);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            currentPageIndex++;
            CargaDatos(currentPageIndex);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (currentPageIndex == 1)
            {
                return;
            }
            currentPageIndex--;
            CargaDatos(currentPageIndex);
        }

        private void txtPageIndex_TextChanged(object sender, EventArgs e)
        {
            //pageIndex = int.Parse(txtPageIndex.Text);
            if (_txtPageIndexBlock)
            {
                return;
            }

            int index;
            if (int.TryParse(txtPageIndex.Text, out index))
            {
                currentPageIndex = index;
            }
            else
            {
                currentPageIndex = 1;
            }

            CargaDatos(currentPageIndex);
        }
    }
}