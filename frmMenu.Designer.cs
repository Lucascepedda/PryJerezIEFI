
namespace PryJerezIEFI
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.auditoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssUsuario = new System.Windows.Forms.StatusStrip();
            this.tssUno = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.eliminarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tssUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auditoriaToolStripMenuItem,
            this.agregarCuentaToolStripMenuItem,
            this.eliminarCuentaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // auditoriaToolStripMenuItem
            // 
            this.auditoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auditoriaToolStripMenuItem1});
            this.auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            this.auditoriaToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.auditoriaToolStripMenuItem.Text = "Administracion";
            // 
            // auditoriaToolStripMenuItem1
            // 
            this.auditoriaToolStripMenuItem1.Name = "auditoriaToolStripMenuItem1";
            this.auditoriaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.auditoriaToolStripMenuItem1.Text = "Auditoria";
            this.auditoriaToolStripMenuItem1.Click += new System.EventHandler(this.auditoriaToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // agregarCuentaToolStripMenuItem
            // 
            this.agregarCuentaToolStripMenuItem.Name = "agregarCuentaToolStripMenuItem";
            this.agregarCuentaToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.agregarCuentaToolStripMenuItem.Text = "Agregar Cuenta";
            this.agregarCuentaToolStripMenuItem.Click += new System.EventHandler(this.agregarCuentaToolStripMenuItem_Click);
            // 
            // tssUsuario
            // 
            this.tssUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssUno});
            this.tssUsuario.Location = new System.Drawing.Point(0, 423);
            this.tssUsuario.Name = "tssUsuario";
            this.tssUsuario.Size = new System.Drawing.Size(463, 27);
            this.tssUsuario.TabIndex = 1;
            this.tssUsuario.Text = "statusStrip1";
            // 
            // tssUno
            // 
            this.tssUno.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssUno.ForeColor = System.Drawing.Color.Red;
            this.tssUno.Name = "tssUno";
            this.tssUno.Size = new System.Drawing.Size(188, 22);
            this.tssUno.Text = "toolStripStatusLabel1";
            this.tssUno.Click += new System.EventHandler(this.tssUno_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.SystemColors.Control;
            this.lblTiempo.Location = new System.Drawing.Point(173, 389);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(0, 13);
            this.lblTiempo.TabIndex = 17;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.SystemColors.Control;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(334, 384);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 18);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // eliminarCuentaToolStripMenuItem
            // 
            this.eliminarCuentaToolStripMenuItem.Name = "eliminarCuentaToolStripMenuItem";
            this.eliminarCuentaToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.eliminarCuentaToolStripMenuItem.Text = "Eliminar Cuenta";
            this.eliminarCuentaToolStripMenuItem.Click += new System.EventHandler(this.eliminarCuentaToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.tssUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tssUsuario.ResumeLayout(false);
            this.tssUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem auditoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip tssUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tssUno;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ToolStripMenuItem auditoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCuentaToolStripMenuItem;
    }
}