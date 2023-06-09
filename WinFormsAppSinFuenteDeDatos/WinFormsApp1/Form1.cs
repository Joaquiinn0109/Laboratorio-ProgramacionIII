namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Panel buttonPanel = new Panel();
        private DataGridView songsDataGridView = new DataGridView();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
        private void PopulateDataGridView()
        {
            string[] row0 = { "11/22/1968", "29", "Revolution 9",
        "Beatles", "The Beatles [White Album]" };
            string[] row1 = { "1960", "6", "Fools Rush In",
        "Frank Sinatra", "Nice 'N' Easy" };
            string[] row2 = { "11/11/1971", "1", "One of These Days",
        "Pink Floyd", "Meddle" };
            string[] row3 = { "1988", "7", "Where Is My Mind?",
        "Pixies", "Surfer Rosa" };
            string[] row4 = { "5/1981", "9", "Can't Find My Mind",
        "Cramps", "Psychedelic Jungle" };
            string[] row5 = { "6/10/2003", "13",
        "Scatterbrain. (As Dead As Leaves.)",
        "Radiohead", "Hail to the Thief" };
            string[] row6 = { "6/30/1992", "3", "Dress", "P J Harvey", "Dry" };

            songsDataGridView.Rows.Add(row0);
            songsDataGridView.Rows.Add(row1);
            songsDataGridView.Rows.Add(row2);
            songsDataGridView.Rows.Add(row3);
            songsDataGridView.Rows.Add(row4);
            songsDataGridView.Rows.Add(row5);
            songsDataGridView.Rows.Add(row6);

            songsDataGridView.Columns[0].DisplayIndex = 3;
            songsDataGridView.Columns[1].DisplayIndex = 4;
            songsDataGridView.Columns[2].DisplayIndex = 0;
            songsDataGridView.Columns[3].DisplayIndex = 1;
            songsDataGridView.Columns[4].DisplayIndex = 2;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.songsDataGridView.Rows.Add();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.songsDataGridView.SelectedRows.Count > 0 &&
            this.songsDataGridView.SelectedRows[0].Index !=
            this.songsDataGridView.Rows.Count - 1)
            {
                this.songsDataGridView.Rows.RemoveAt(
                    this.songsDataGridView.SelectedRows[0].Index);
            }
        }

    }
}