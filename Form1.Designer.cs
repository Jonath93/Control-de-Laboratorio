namespace Control_de_Laboratorio
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_Pres = new System.Windows.Forms.Button();
            this.Btn_Regpro = new System.Windows.Forms.Button();
            this.Btn_Regalum = new System.Windows.Forms.Button();
            this.Bitacora_Prestamo = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(778, 134);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Instituto Tecnológico de Hermosillo");
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Exit.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources._1432619285_close_window;
            this.Btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Exit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.Btn_Exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Exit.Location = new System.Drawing.Point(744, 1);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(31, 32);
            this.Btn_Exit.TabIndex = 8;
            this.toolTip1.SetToolTip(this.Btn_Exit, "Salir");
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click_1);
            // 
            // Btn_Pres
            // 
            this.Btn_Pres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Pres.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources._1432597979_digital_projector;
            this.Btn_Pres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Pres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Pres.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pres.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Pres.Location = new System.Drawing.Point(381, 201);
            this.Btn_Pres.Name = "Btn_Pres";
            this.Btn_Pres.Size = new System.Drawing.Size(167, 163);
            this.Btn_Pres.TabIndex = 4;
            this.Btn_Pres.Text = "Préstamo de Proyectores";
            this.Btn_Pres.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.Btn_Pres, "Préstamo de Proyectores");
            this.Btn_Pres.UseVisualStyleBackColor = true;
            this.Btn_Pres.Click += new System.EventHandler(this.Btn_Pres_Click);
            this.Btn_Pres.MouseLeave += new System.EventHandler(this.Btn_Pres_MouseLeave);
            this.Btn_Pres.MouseHover += new System.EventHandler(this.Btn_Pres_MouseHover);
            // 
            // Btn_Regpro
            // 
            this.Btn_Regpro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Regpro.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources._1432598671_plus;
            this.Btn_Regpro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Regpro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Regpro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regpro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Regpro.Location = new System.Drawing.Point(208, 201);
            this.Btn_Regpro.Name = "Btn_Regpro";
            this.Btn_Regpro.Size = new System.Drawing.Size(167, 163);
            this.Btn_Regpro.TabIndex = 3;
            this.Btn_Regpro.Text = "Registro de Proyectores";
            this.Btn_Regpro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.Btn_Regpro, "Registro de proyectores");
            this.Btn_Regpro.UseVisualStyleBackColor = true;
            this.Btn_Regpro.Click += new System.EventHandler(this.Btn_Regpro_Click_1);
            this.Btn_Regpro.MouseLeave += new System.EventHandler(this.Btn_Regpro_MouseLeave);
            this.Btn_Regpro.MouseHover += new System.EventHandler(this.Btn_Regpro_MouseHover);
            // 
            // Btn_Regalum
            // 
            this.Btn_Regalum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Regalum.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources._1432598386_group_add;
            this.Btn_Regalum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Regalum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Regalum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regalum.Location = new System.Drawing.Point(35, 201);
            this.Btn_Regalum.Name = "Btn_Regalum";
            this.Btn_Regalum.Size = new System.Drawing.Size(167, 163);
            this.Btn_Regalum.TabIndex = 1;
            this.Btn_Regalum.Text = "Registro de Personal";
            this.Btn_Regalum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.Btn_Regalum, "Registro de Alumnos");
            this.Btn_Regalum.UseVisualStyleBackColor = false;
            this.Btn_Regalum.Click += new System.EventHandler(this.Btn_Regalum_Click);
            this.Btn_Regalum.MouseLeave += new System.EventHandler(this.Btn_Regalum_MouseLeave);
            this.Btn_Regalum.MouseHover += new System.EventHandler(this.Btn_Regalum_MouseHover);
            // 
            // Bitacora_Prestamo
            // 
            this.Bitacora_Prestamo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bitacora_Prestamo.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.pdf_to_png_document;
            this.Bitacora_Prestamo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Bitacora_Prestamo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bitacora_Prestamo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bitacora_Prestamo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bitacora_Prestamo.Location = new System.Drawing.Point(554, 201);
            this.Bitacora_Prestamo.Name = "Bitacora_Prestamo";
            this.Bitacora_Prestamo.Size = new System.Drawing.Size(167, 163);
            this.Bitacora_Prestamo.TabIndex = 5;
            this.Bitacora_Prestamo.Text = "Bitacora de Proyectores";
            this.Bitacora_Prestamo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.Bitacora_Prestamo, "Préstamo de Proyectores");
            this.Bitacora_Prestamo.UseVisualStyleBackColor = true;
            this.Bitacora_Prestamo.Click += new System.EventHandler(this.Bitacora_Prestamo_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources._1432619269_minimize_window;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMin.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.Black;
            this.btnMin.Location = new System.Drawing.Point(708, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 32);
            this.btnMin.TabIndex = 7;
            this.btnMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.a_001_6400_fondo_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lblFecha);
            this.panel3.Controls.Add(this.btnMin);
            this.panel3.Controls.Add(this.Btn_Exit);
            this.panel3.Controls.Add(this.lblHora);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 692);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 35);
            this.panel3.TabIndex = 9;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(573, 10);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 19);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(99, 10);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(48, 19);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "Hora";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Bitacora_Prestamo);
            this.panel2.Controls.Add(this.Btn_Regalum);
            this.panel2.Controls.Add(this.Btn_Regpro);
            this.panel2.Controls.Add(this.Btn_Pres);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 558);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 727);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyectores L5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Regalum;
        private System.Windows.Forms.Button Btn_Regpro;
        private System.Windows.Forms.Button Btn_Pres;
        private System.Windows.Forms.Button Bitacora_Prestamo;
    }
}

