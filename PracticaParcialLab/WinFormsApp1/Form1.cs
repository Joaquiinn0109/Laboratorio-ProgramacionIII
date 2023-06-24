using Materias_Alumnos;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Materias> _listaMaterias = new List<Materias>();

        public Form1()
        {
            InitializeComponent();
            dgMaterias.CellMouseEnter += new DataGridViewCellEventHandler(dgMaterias_CellMouseEnter);
            dgAlumnos.CellMouseEnter += new DataGridViewCellEventHandler(dgAlumnos_CellMouseEnter);
        }

        private void btnGenerarDatos_Click(object sender, EventArgs e)
        {
            if (_listaMaterias.Count == 0)
            {
                Generador generador = new Generador();
                _listaMaterias = generador.GenerarAlumnos(10, 20);

                dgMaterias.AutoGenerateColumns = false;
                dgMaterias.DataSource = _listaMaterias;
            }
            else
            {
                MessageBox.Show("Los datos ya han sido generados.");
            }
        }

        private void dgMaterias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgMaterias.CurrentRow != null && dgMaterias.CurrentRow.DataBoundItem != null)
            {
                var materiaSeleccionada = (Materias)dgMaterias.CurrentRow.DataBoundItem;
                dgAlumnos.DataSource = materiaSeleccionada.AlumnoList;
            }
        }

        private void dgMaterias_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgMaterias.Rows[e.RowIndex];
                string datosMateria = string.Join(", ", row.Cells.Cast<DataGridViewCell>()
                                                     .Where(m => m.Value != null)
                                                     .Select(m => m.Value.ToString()));
                lblMateria.Text = datosMateria;
            }
        }

        private void dgAlumnos_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgAlumnos.Rows[e.RowIndex];
                string datosAlumno = string.Join(", ", row.Cells.Cast<DataGridViewCell>()
                                                     .Where(a => a.Value != null)
                                                     .Select(a => a.Value.ToString()));
                lblAlumno.Text = datosAlumno;
            }
        }

        //private void dgMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var texto = e.RowIndex;
        //    if (texto != -1)
        //    {
        //        lblMateria.Text = (string)dgMaterias.Rows[texto].Cells[0].Value;
        //    }
        //}

        //private void dgAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var texto = e.RowIndex;
        //    if (texto != 0)
        //    {
        //        var a = dgAlumnos.Rows[texto].Cells[0].Value;
        //        var l = dgAlumnos.Rows[texto].Cells[1].Value;
        //        var n = dgAlumnos.Rows[texto].Cells[2].Value;
        //        var ap = dgAlumnos.Rows[texto].Cells[3].Value;
        //        lblAlumno.Text = $"{a.ToString()}, {l.ToString()}, {n.ToString()}, {ap.ToString()}";
        //    }
        //}
        private void btnBuscarMateria_Click(object sender, EventArgs e)
        {
            var nombre = txtBusqueda.Text;

            bool materiaEncontrada = false;

            foreach (DataGridViewRow m in dgMaterias.Rows)
            {
                var nombreMateria = m.Cells[0].Value.ToString();

                if (nombreMateria.ToLower().Contains(nombre.ToLower()))
                {
                    m.Selected = true;
                    dgMaterias.CurrentCell = m.Cells[0];
                    materiaEncontrada = true;
                    break;
                }
            }

            if (!materiaEncontrada)
            {
                MessageBox.Show("No se encontraron resultados.");
            }
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            var nombre = txtBusqueda.Text;

            bool alumnoEncontrado = false;

            foreach (DataGridViewRow a in dgAlumnos.Rows)
            {
                var nombreAlumno = a.Cells[0].Value.ToString();
                if (nombreAlumno.ToLower().Contains(nombre.ToLower()))
                {
                    a.Selected = true;
                    dgAlumnos.CurrentCell = a.Cells[0];
                    alumnoEncontrado = true;
                    var al = dgAlumnos.SelectedCells[0].Value;
                    var l = dgAlumnos.SelectedCells[1].Value;
                    var n = dgAlumnos.SelectedCells[2].Value;
                    var ap = dgAlumnos.SelectedCells[3].Value;
                    txtDatosAlumno.Text = $"{al.ToString()}, {l.ToString()}, {n.ToString()}, {ap.ToString()}";

                    break;
                }
            }

            if (!alumnoEncontrado)
            {
                MessageBox.Show("No se encontraron resultados.");
            }
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            var materiaSeleccionada = (Materias)dgMaterias.CurrentRow.DataBoundItem;

            var nuevoAlumno = new Alumnos
            {
                AlumnoId = materiaSeleccionada.AlumnoList.Count + 1,
                Legajo = $"Legajo: {materiaSeleccionada.AlumnoList.Count + 1}/2023 - {materiaSeleccionada.MateriaId}",
                Nombre = $"{txtNombreAlumno.Text} {materiaSeleccionada.AlumnoList.Count + 1}",
                Apellido = $"{txtApellidoAlumno.Text} {materiaSeleccionada.AlumnoList.Count + 1}"
            };

            materiaSeleccionada.AlumnoList.Add(nuevoAlumno);

            dgMaterias.DataSource = _listaMaterias;
        }
    }
}