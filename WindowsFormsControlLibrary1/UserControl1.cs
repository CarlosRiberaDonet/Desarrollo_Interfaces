using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public string TextoInicio
        {
            get { return etiquetaInicio.Text; }
            set { etiquetaInicio.Text = value; }
        }

        private void fechaInicio_ValueChanged(object sender, EventArgs e)
        {
            if (fechaFin.Value < fechaInicio.Value)
            {
                fechaFin.Value = fechaInicio.Value.AddDays(1);
            }
        }

        private void fechaFin_ValueChanged(object sender, EventArgs e)
        {

            if (fechaInicio.Value > fechaFin.Value)
            {
                fechaInicio.Value = fechaFin.Value.AddDays(-1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Imagenes|*.jpg";
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);
        }
    }
}
