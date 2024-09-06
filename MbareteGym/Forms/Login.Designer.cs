namespace MbareteGym.Formularios
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSuperior = new Panel();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            panel1 = new Panel();
            txtUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPass = new TextBox();
            button1 = new Button();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(30, 38, 70);
            panelSuperior.Controls.Add(btnMinimizar);
            panelSuperior.Controls.Add(btnCerrar);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(473, 50);
            panelSuperior.TabIndex = 0;
            panelSuperior.Paint += title_Paint;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = Properties.Resources.minimazar;
            btnMinimizar.Location = new Point(420, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(17, 22);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.cerrar;
            btnCerrar.Location = new Point(443, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(18, 22);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 38, 70);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 602);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 15);
            panel1.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Century Gothic", 12F);
            txtUser.ForeColor = Color.Silver;
            txtUser.Location = new Point(53, 193);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(350, 27);
            txtUser.TabIndex = 2;
            txtUser.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(53, 169);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(53, 271);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 5;
            label2.Text = "Contraseña";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Century Gothic", 12F);
            txtPass.ForeColor = Color.Silver;
            txtPass.Location = new Point(53, 295);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(350, 27);
            txtPass.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(17, 97, 238);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(53, 404);
            button1.Name = "button1";
            button1.Size = new Size(350, 50);
            button1.TabIndex = 6;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 59, 104);
            ClientSize = new Size(473, 617);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtPass);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(panel1);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.85D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSuperior;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Panel panel1;
        private TextBox txtUser;
        private Label label1;
        private Label label2;
        private TextBox txtPass;
        private Button button1;
    }
}