using Controladora;
using Modelo;

namespace Vista
{
    public partial class Form1 : Form
    {
        ControladoraColectivos controladoraColectivos;
        ControladoraPasajeros controladoraPasajeros;

        public Form1()
        {
            InitializeComponent();
            controladoraColectivos = new ControladoraColectivos();
            controladoraPasajeros = new ControladoraPasajeros();
            ActualizarGrillaColectivos();
        }

        private void rbtnSiEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            txtLegajo.Enabled = true;
        }

        private void rbtnNoEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            txtLegajo.Enabled = false;

        }

        private void btnAgregarColectivo_Click(object sender, EventArgs e)
        {
            Colectivo nuevoColectivo = new Colectivo();

            //txtPatente.Text = nuevoColectivo.Patente;
            //txtNombre.Text = nuevoColectivo.Nombre;
            //numCantidadAsientos.Value = nuevoColectivo.CantidadAsientos;

            nuevoColectivo.Patente = txtPatente.Text;
            nuevoColectivo.Nombre = txtNombre.Text;
            nuevoColectivo.CantidadAsientos = Convert.ToInt16(numCantidadAsientos.Value);

            if (controladoraColectivos.AgregarColectivo(nuevoColectivo))
            {
                MessageBox.Show("Colectivo agregado correctamente.");
                ActualizarGrillaColectivos();
            }
            else
            {
                MessageBox.Show("No se ha podido agregar el colectivo.");
            }

        }

        private void ActualizarGrillaColectivos()
        {
            dgvColectivos.DataSource = null;
            dgvColectivos.DataSource = controladoraColectivos.ListarColectivos();
        }

        private void ActualizarGrillaPasajeros()
        {
            var colectivoSeleccionado = dgvColectivos.SelectedRows[0].DataBoundItem as Colectivo;

            List<Pasajero> pasajeros = new List<Pasajero>();
            List<PasajeroEstudiante> estudiantes = new List<PasajeroEstudiante>();

            foreach (var p in colectivoSeleccionado.Pasajeros)
            {
                if (p is PasajeroEstudiante estudiante)
                {
                    estudiantes.Add(estudiante);
                }
                else
                {
                    pasajeros.Add(p);
                }
            }

            dgvPasajeros.DataSource = null;
            dgvPasajeros.DataSource = pasajeros;

            dgvPasajerosEstudiantes.DataSource = null;
            dgvPasajerosEstudiantes.DataSource = estudiantes;
        }

        private void btnEliminarColectivo_Click(object sender, EventArgs e)
        {
            var colectivoSeleccionado = dgvColectivos.SelectedRows[0].DataBoundItem as Colectivo;
            if (colectivoSeleccionado != null)
            {
                if (controladoraColectivos.EliminarColectivo(colectivoSeleccionado))
                {
                    MessageBox.Show("Colectivo eliminado correctamente.");
                    ActualizarGrillaColectivos();
                }
                else
                {
                    MessageBox.Show("No se ha podido elimnar el colectivo.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un colectivo.");
            }
        }

        private void dgvColectivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvColectivos.SelectedRows.Count == 1)
            {
                gBoxPasajero.Enabled = true;
                ActualizarGrillaPasajeros();
            }
            else
            {
                gBoxPasajero.Enabled = false;
            }

        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
            var colectivoSeleccionado = dgvColectivos.SelectedRows[0].DataBoundItem as Colectivo;

            if (rbtnSiEstudiante.Checked)
            {

                PasajeroEstudiante nuevoPasajeroEstudiante = new PasajeroEstudiante();
                nuevoPasajeroEstudiante.Dni = txtDNI.Text;
                nuevoPasajeroEstudiante.Legajo = Convert.ToInt32(txtLegajo.Text);
                nuevoPasajeroEstudiante.Apellido = txtApellido.Text;
                nuevoPasajeroEstudiante.Nombre = txtNombrePasajero.Text;

                if (controladoraPasajeros.AgregarPasajero(nuevoPasajeroEstudiante))
                {

                    colectivoSeleccionado.AgregarPasajero(nuevoPasajeroEstudiante);
                    MessageBox.Show("Pasajero estudiante agregado correctamente.");
                    ActualizarGrillaPasajeros();
                }
                else
                {
                    MessageBox.Show("No se ha podido pasajero estudiante el colectivo.");
                }
            }
            else if (rbtnNoEstudiante.Checked)
            {
                Pasajero nuevoPasajero = new Pasajero();
                nuevoPasajero.Dni = txtDNI.Text;
                nuevoPasajero.Apellido = txtApellido.Text;
                nuevoPasajero.Nombre = txtNombrePasajero.Text;

                if (controladoraPasajeros.AgregarPasajero(nuevoPasajero))
                {
                    colectivoSeleccionado.AgregarPasajero(nuevoPasajero);
                    MessageBox.Show("Pasajero agregado correctamente.");
                    ActualizarGrillaPasajeros();

                }
                else
                {
                    MessageBox.Show("No se ha podido pasajero el colectivo.");
                }
            }
        }
    }
}
