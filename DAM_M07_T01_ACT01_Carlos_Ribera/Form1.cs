namespace DAM_M07_T01_ACT01_Carlos_Ribera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbExtensionesValidas.Enabled = false; // Desactivo el ComboBox al inicio

        }

        private void crearTareaButton_Click(object sender, EventArgs e)
        {
            // Llamo a la función ValidarDatos
            string mensajeError = ValidarDatos();

            // Si hay algun error, muestro un mensage y detengo el proceso
            if (!string.IsNullOrEmpty(mensajeError))
            {
                MessageBox.Show(mensajeError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si todo está bien, muestro mensaje de éxito
            MessageBox.Show("Tarea creada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Método para validar los datos del formulario
        private string ValidarDatos()
        {
            // Validar que el nombre de la tarea no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombreTarea.Text))
                return "Por favor, ingrese un nombre para la tarea.";

            // Validar que la descripción de la tarea no esté vacía
            if (string.IsNullOrWhiteSpace(txtDescripcionTarea.Text))
                return "Por favor, ingrese una descripción para la tarea.";

            // Validar que la fecha de entrega sea posterior a la actual
            if (fechaEntrega.Value <= DateTime.Now)
                return "La fecha de entrega debe ser posterior a la actual.";

            // Validar que el usuario haya seleccionado un tipo de entrega
            if (cmbTipoEntrega.SelectedItem == null)
                return "Por favor, seleccione un tipo de entrega.";

            // Si el tipo de entrega es "Subir Fichero", validar que se haya seleccionado una opción en comboBoxExtensionesValidas
            if (cmbTipoEntrega.SelectedItem.ToString() == "Subir Fichero" && cmbExtensionesValidas.SelectedItem == null)
                return "Por favor, seleccione un tipo de extensión de archivo para la entrega.";

            // Si todo está bien, devuelve cadena vacía
            return string.Empty;
        }

        // Método para comprobar el tipo de entrega seleccionado por el USR
        private void cmbTipoEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si no hay selección, salir
            if (cmbTipoEntrega.SelectedIndex < 0) return;

            // Variable que almacena el tipo de entrega seleccionado como texto
            string tipoEntrega = cmbTipoEntrega.SelectedItem.ToString();

            // Activar/desactivar ComboBox de extensiones
            cmbExtensionesValidas.Enabled = (tipoEntrega == "Subir Fichero");
            if (!cmbExtensionesValidas.Enabled)
            {
                cmbExtensionesValidas.SelectedIndex = -1; // Limpiar selección
            }
        }
    }
}
