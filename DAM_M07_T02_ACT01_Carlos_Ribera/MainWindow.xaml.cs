using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DAM_M07_T02_ACT01_Carlos_Ribera
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Declaro variable
        private String tipoEntrega;
        public MainWindow()
        {
            InitializeComponent();

            // Oculto labelMensaje
            labelMensaje.Visibility = Visibility.Hidden;
        }

        // Evento que se activa con "botonEnviar"
        private void botonEnviar_Click(object sender, RoutedEventArgs e)
        {
            string mensajeError = ValidarCampos();

            if (!string.IsNullOrEmpty(mensajeError))
            {
                labelMensaje.Content = mensajeError;
                labelMensaje.Foreground = Brushes.Red; // Cambio el color de labelMensaje
                labelMensaje.Visibility = Visibility.Visible; // Hago visible labelMensaje
            }
            else
            {
                labelMensaje.Content = "Tarea enviada exitosamente.";
                labelMensaje.Foreground = Brushes.Green; // Cambio el color de labelMensaje
                labelMensaje.Visibility = Visibility.Visible; // Hago visible labelMensaje
            }
        }

        // Evento que se activa cuando el USR cambia la selección de comboBoxEntrega
        private void comboBoxTipoEntrega_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Si el USR selecciona un item dentro de comboBoxEntrega
            if (comboBoxTipoEntrega.SelectedItem is ComboBoxItem selectedItem)
            {
                // Extraigo el texto de la opción seleccionada y elimino los espacios
                tipoEntrega = selectedItem.Content.ToString().Trim();

                // Si el USR ha elegido "Subir Fichero"
                if (tipoEntrega == "Subir Fichero")
                {
                    // Habilito el comboBoxExtension
                    comboBoxExtension.IsEnabled = true;
                }
                // Si ha elegido otra opción
                else
                {
                    // Deshabilito comboBoxExtension
                    comboBoxExtension.IsEnabled = false;
                    // Vacío la seleccion
                    comboBoxExtension.SelectedIndex = -1;
                }
            
            }
        }

        // Método que comprueba los campos del formulario
        private string ValidarCampos()
        {
            // Si el textBoxNombre está vacío
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                return "Por favor, ingrese un nombre para la tarea.";
            }
            // Si el textBoxDescripcion está vacío
            if (string.IsNullOrEmpty(textBoxDescripcion.Text))
            {
                return "Por favor, ingrese una descripción para la tarea.";
            }
            // Si la fecha de entrega está vacía
            if (!fechaEntrega.SelectedDate.HasValue) 
            {
                return "Por favor, introduzca una fecha de entrega.";           
            }
            // Si la fecha de entrega es anterior a la fecha actual
            if (fechaEntrega.SelectedDate.Value < DateTime.Now)
            {
                return "Debe introducir una fecha de entrega posterior a la fecha actual.";
            }
            // Si no se ha seleccionado un tipo de entrega
            if(comboBoxTipoEntrega.SelectedItem == null)
            {
                return "Debe seleccionar un tipo de entrega.";
            }
            // Si el tipo de entrega seleccionado es "Subir Fichero"
            if (tipoEntrega == "Subir Fichero" && comboBoxExtension.SelectedItem == null)
            {
                return "Para tipo de entrega Subir Fichero, debe seleccionar una extensión válida.";
            }
            // Si todos los campos están correctos, devuelvo una cadena vacía
            return "";
        }
    }
}
