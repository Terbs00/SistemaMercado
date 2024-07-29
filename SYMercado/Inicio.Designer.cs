namespace SYMercado
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            iconMenuItem7 = new FontAwesome.Sharp.IconMenuItem();
            imtmanatenedor = new FontAwesome.Sharp.IconMenuItem();
            imtVentas = new FontAwesome.Sharp.IconMenuItem();
            ImtCompras = new FontAwesome.Sharp.IconMenuItem();
            ImtClientes = new FontAwesome.Sharp.IconMenuItem();
            imtProveedor = new FontAwesome.Sharp.IconMenuItem();
            imtRecortes = new FontAwesome.Sharp.IconMenuItem();
            IMTACD = new FontAwesome.Sharp.IconMenuItem();
            menuTitulo = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            Contenedor = new Panel();
            menu.SuspendLayout();
            menuTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.Thistle;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { iconMenuItem7, imtmanatenedor, imtVentas, ImtCompras, ImtClientes, imtProveedor, imtRecortes, IMTACD });
            menu.Location = new Point(0, 52);
            menu.Name = "menu";
            menu.Size = new Size(757, 58);
            menu.TabIndex = 0;
            menu.Text = "menu";
            // 
            // iconMenuItem7
            // 
            iconMenuItem7.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            iconMenuItem7.IconChar = FontAwesome.Sharp.IconChar.Bacon;
            iconMenuItem7.IconColor = Color.Black;
            iconMenuItem7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem7.IconSize = 30;
            iconMenuItem7.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem7.Name = "iconMenuItem7";
            iconMenuItem7.Size = new Size(73, 54);
            iconMenuItem7.Text = "Usuario";
            iconMenuItem7.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // imtmanatenedor
            // 
            imtmanatenedor.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            imtmanatenedor.IconChar = FontAwesome.Sharp.IconChar.Cloud;
            imtmanatenedor.IconColor = Color.Black;
            imtmanatenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imtmanatenedor.IconSize = 30;
            imtmanatenedor.ImageScaling = ToolStripItemImageScaling.None;
            imtmanatenedor.Name = "imtmanatenedor";
            imtmanatenedor.Size = new Size(104, 54);
            imtmanatenedor.Text = "Mantenedor";
            imtmanatenedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // imtVentas
            // 
            imtVentas.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            imtVentas.IconChar = FontAwesome.Sharp.IconChar.Coins;
            imtVentas.IconColor = Color.Black;
            imtVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imtVentas.IconSize = 30;
            imtVentas.ImageScaling = ToolStripItemImageScaling.None;
            imtVentas.Name = "imtVentas";
            imtVentas.Size = new Size(66, 54);
            imtVentas.Text = "Ventas";
            imtVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // ImtCompras
            // 
            ImtCompras.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            ImtCompras.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            ImtCompras.IconColor = Color.Black;
            ImtCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ImtCompras.IconSize = 30;
            ImtCompras.ImageScaling = ToolStripItemImageScaling.None;
            ImtCompras.Name = "ImtCompras";
            ImtCompras.Size = new Size(82, 54);
            ImtCompras.Text = "Compras";
            ImtCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // ImtClientes
            // 
            ImtClientes.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            ImtClientes.IconChar = FontAwesome.Sharp.IconChar.BuildingUser;
            ImtClientes.IconColor = Color.Black;
            ImtClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ImtClientes.IconSize = 30;
            ImtClientes.ImageScaling = ToolStripItemImageScaling.None;
            ImtClientes.Name = "ImtClientes";
            ImtClientes.Size = new Size(75, 54);
            ImtClientes.Text = "Clientes";
            ImtClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // imtProveedor
            // 
            imtProveedor.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            imtProveedor.IconChar = FontAwesome.Sharp.IconChar.PeopleCarryBox;
            imtProveedor.IconColor = Color.Black;
            imtProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imtProveedor.IconSize = 30;
            imtProveedor.ImageScaling = ToolStripItemImageScaling.None;
            imtProveedor.Name = "imtProveedor";
            imtProveedor.Size = new Size(91, 54);
            imtProveedor.Text = "Proveedor";
            imtProveedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // imtRecortes
            // 
            imtRecortes.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            imtRecortes.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            imtRecortes.IconColor = Color.Black;
            imtRecortes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imtRecortes.IconSize = 30;
            imtRecortes.ImageScaling = ToolStripItemImageScaling.None;
            imtRecortes.Name = "imtRecortes";
            imtRecortes.Size = new Size(80, 54);
            imtRecortes.Text = "Recortes";
            imtRecortes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // IMTACD
            // 
            IMTACD.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            IMTACD.IconChar = FontAwesome.Sharp.IconChar.Bell;
            IMTACD.IconColor = Color.Black;
            IMTACD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IMTACD.IconSize = 30;
            IMTACD.ImageScaling = ToolStripItemImageScaling.None;
            IMTACD.Name = "IMTACD";
            IMTACD.Size = new Size(89, 54);
            IMTACD.Text = "Acerca de";
            IMTACD.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            menuTitulo.AutoSize = false;
            menuTitulo.BackColor = Color.MediumSlateBlue;
            menuTitulo.ImageScalingSize = new Size(20, 20);
            menuTitulo.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuTitulo.Location = new Point(0, 0);
            menuTitulo.Name = "menuTitulo";
            menuTitulo.RightToLeft = RightToLeft.No;
            menuTitulo.Size = new Size(757, 52);
            menuTitulo.TabIndex = 1;
            menuTitulo.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(236, 48);
            toolStripMenuItem1.Text = "Sistema de mercado";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // Contenedor
            // 
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.Location = new Point(0, 110);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(757, 340);
            Contenedor.TabIndex = 2;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 450);
            Controls.Add(Contenedor);
            Controls.Add(menu);
            Controls.Add(menuTitulo);
            MainMenuStrip = menu;
            Name = "Inicio";
            Text = "Form1";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            menuTitulo.ResumeLayout(false);
            menuTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private MenuStrip menuTitulo;
        private ToolStripMenuItem toolStripMenuItem1;
        private FontAwesome.Sharp.IconMenuItem IMTACD;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem7;
        private FontAwesome.Sharp.IconMenuItem imtmanatenedor;
        private FontAwesome.Sharp.IconMenuItem imtVentas;
        private FontAwesome.Sharp.IconMenuItem ImtCompras;
        private FontAwesome.Sharp.IconMenuItem ImtClientes;
        private FontAwesome.Sharp.IconMenuItem imtProveedor;
        private FontAwesome.Sharp.IconMenuItem imtRecortes;
        private Panel Contenedor;
    }
}
