namespace SYMercado
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
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textDocumento = new TextBox();
            textpass = new TextBox();
            butingresar = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 337);
            panel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.SkyBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Shop;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 215;
            iconPictureBox1.Location = new Point(38, 39);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(217, 215);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 257);
            label1.Name = "label1";
            label1.Size = new Size(279, 46);
            label1.TabIndex = 0;
            label1.Text = "Sistema Mercado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 39);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 162);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // textDocumento
            // 
            textDocumento.Location = new Point(341, 62);
            textDocumento.Name = "textDocumento";
            textDocumento.Size = new Size(356, 27);
            textDocumento.TabIndex = 3;
            // 
            // textpass
            // 
            textpass.Location = new Point(341, 185);
            textpass.Name = "textpass";
            textpass.Size = new Size(359, 27);
            textpass.TabIndex = 4;
            // 
            // butingresar
            // 
            butingresar.BackColor = SystemColors.ActiveCaption;
            butingresar.BackgroundImageLayout = ImageLayout.None;
            butingresar.Cursor = Cursors.Hand;
            butingresar.ImageAlign = ContentAlignment.MiddleLeft;
            butingresar.Location = new Point(341, 257);
            butingresar.Name = "butingresar";
            butingresar.Size = new Size(143, 40);
            butingresar.TabIndex = 7;
            butingresar.Text = "Ingresar";
            butingresar.UseVisualStyleBackColor = false;
            butingresar.Click += butingresar_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(554, 257);
            button1.Name = "button1";
            button1.Size = new Size(143, 40);
            button1.TabIndex = 8;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 337);
            Controls.Add(button1);
            Controls.Add(butingresar);
            Controls.Add(textpass);
            Controls.Add(textDocumento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private Label label3;
        private TextBox textDocumento;
        private TextBox textpass;
        private Button butingresar;
        private Button button1;
    }
}