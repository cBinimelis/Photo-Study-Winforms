namespace Photo_Study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_quit_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("¿Estás seguro de querer cerrar el programa?", "¡Cuidado!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }
    }
}