namespace Control_de_Laboratorio
{
    partial class Bitacora
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
            this.dgv_BitacoraAlumno = new System.Windows.Forms.DataGridView();
            this.btn_alumnos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BitacoraAlumno)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_BitacoraAlumno
            // 
            this.dgv_BitacoraAlumno.BackgroundColor = System.Drawing.Color.White;
            this.dgv_BitacoraAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BitacoraAlumno.Location = new System.Drawing.Point(12, 66);
            this.dgv_BitacoraAlumno.Name = "dgv_BitacoraAlumno";
            this.dgv_BitacoraAlumno.Size = new System.Drawing.Size(480, 238);
            this.dgv_BitacoraAlumno.TabIndex = 2;
            // 
            // btn_alumnos
            // 
            this.btn_alumnos.BackColor = System.Drawing.Color.Transparent;
            this.btn_alumnos.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.a_001_6400_fondo_;
            this.btn_alumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_alumnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_alumnos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alumnos.Image = global::Control_de_Laboratorio.Properties.Resources.descarga;
            this.btn_alumnos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_alumnos.Location = new System.Drawing.Point(512, 66);
            this.btn_alumnos.Name = "btn_alumnos";
            this.btn_alumnos.Size = new System.Drawing.Size(76, 93);
            this.btn_alumnos.TabIndex = 4;
            this.btn_alumnos.Text = "Exportar Excel";
            this.btn_alumnos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_alumnos.UseVisualStyleBackColor = false;
            this.btn_alumnos.Click += new System.EventHandler(this.btn_alumnos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.fondo_verde_157556_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 43);
            this.panel2.TabIndex = 27;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources._1432619285_close_window;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(569, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 34);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bitacora";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.a_001_6400_fondo_;
            this.ClientSize = new System.Drawing.Size(615, 352);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_alumnos);
            this.Controls.Add(this.dgv_BitacoraAlumno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Bitacora";
            this.Text = "Bitacora";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BitacoraAlumno)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_BitacoraAlumno;
        private System.Windows.Forms.Button btn_alumnos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
    }
}