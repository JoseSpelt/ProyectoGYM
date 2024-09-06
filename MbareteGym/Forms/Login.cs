using System.Runtime.InteropServices;

namespace MbareteGym.Formularios
{
    public partial class Login : Form
    {
        // Variables para arrastrar el formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Login()
        {
            InitializeComponent();

            txtPass.PasswordChar = '•';

            // Asocia los eventos de ratón
            this.MouseDown += new MouseEventHandler(Login_MouseDown);
            this.MouseMove += new MouseEventHandler(Login_MouseMove);
            this.MouseUp += new MouseEventHandler(Login_MouseUp);

            // Suponiendo que tu panel se llama 'panelSuperior'
            panelSuperior.MouseDown += new MouseEventHandler(Panel_MouseDown);
            panelSuperior.MouseMove += new MouseEventHandler(Panel_MouseMove);
            panelSuperior.MouseUp += new MouseEventHandler(Panel_MouseUp);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        // Eventos para mover el formulario al hacer clic en el panel
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string password = txtPass.Text;

            // Aquí puedes poner tu lógica de validación
            // Este es solo un ejemplo de validación simple
            if (usuario == "admin" && password == "1234") // Cambia esto por la validación real
            {
                // Si las credenciales son correctas, se abre el formulario Main
                Main mainForm = new Main();
                mainForm.Show();

                // Opcional: Cerrar el formulario de login
                this.Hide();
            }
            else
            {
                // Si las credenciales son incorrectas, muestra un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
