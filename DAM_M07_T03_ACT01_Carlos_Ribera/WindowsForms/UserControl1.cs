using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Net.Http.Headers;
using System.Diagnostics;


namespace WindowsForms
{
    public partial class UserControl1: UserControl
    {
        // Variable para almacenar el numero de notificaciones
        private int numeroNotificaciones = 1;

        public UserControl1()
        {
            InitializeComponent();
            pictureBox.Paint += PictureBoxPaint;
        }

        // Método para pintar el circulo de notificaciones
        private void PictureBoxPaint(object sender, PaintEventArgs e)
        {
            string texto = "";

            Graphics g = e.Graphics; // Obtengo el Objeto Graphics para pintar
            int diametro = (int)(Math.Min(pictureBox.Width, pictureBox.Height) * 0.30); // 30% del tamaño del PictureBox
              
            // Límito por debajo
            if (numeroNotificaciones <= 0)
            {
                numeroNotificaciones = 0;
            }
            // Límito por arriba
            else if (numeroNotificaciones > 99)
            {
                String maxNotificaciones = "+99";
                texto = maxNotificaciones;
            }
            else
            {
                texto = numeroNotificaciones.ToString();
            }
            
            if (numeroNotificaciones > 0)
            {
                // Posicionamos el círculo en la esquina superior izquierda de PictureBox
                int posX = 0;
                int posY = 0;

                // Dibujar el círculo rojo
                using (Brush brushCirculo = new SolidBrush(Color.Red))
                {
                    g.FillEllipse(brushCirculo, posX, posY, diametro, diametro);
                }

                // Dibujar el número dentro del círculo
                
                using (Font fuente = new Font(Font.FontFamily, diametro / 2, FontStyle.Bold))
                using (Brush brushTexto = new SolidBrush(Color.White))
                {
                    SizeF tamañoTexto = g.MeasureString(texto, fuente);
                    float textoX = posX + (diametro - tamañoTexto.Width) / 2;
                    float textoY = posY + (diametro - tamañoTexto.Height) / 2;
                    g.DrawString(texto, fuente, brushTexto, textoX, textoY);
                }
            }     
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            numeroNotificaciones++;
            Debug.WriteLine($"Número de notificaciones: {numeroNotificaciones}"); // Mensaje de depuración
            pictureBox.Invalidate();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            numeroNotificaciones--;
            Debug.WriteLine($"Número de notificaciones: {numeroNotificaciones}"); // Mensaje de depuración
            pictureBox.Invalidate();
        }

        private void añadirX_Click(object sender, EventArgs e)
        {
            numeroNotificaciones += int.Parse(textBox1.Text);
            pictureBox.Invalidate();
        }

        private void eliminarX_Click(object sender, EventArgs e)
        {
           numeroNotificaciones -= int.Parse(textBox1.Text);
            pictureBox.Invalidate();
        }
    }
}
