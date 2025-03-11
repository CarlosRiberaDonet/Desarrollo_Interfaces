namespace ControlNotificaciones
{
    public partial class UserControl1 : UserControl
    {
        // Variable para almacenar la imagen del icono
        private Image icono = null;
        public UserControl1()
        {
            InitializeComponent();
            
        }

        // GETTER Y SETTER
        public Image Icono
        {

            get {return icono;}
            set { icono = value;  Invalidate(); } 
        }

        // Método para redibujar el icono
        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            if (icono != null)
            {
                e.Graphics.DrawImage(icono,0 ,0, this.Width,this.Height);
            }
        }
    }
}
