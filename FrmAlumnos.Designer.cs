namespace Control_de_Laboratorio
{
    partial class Frm_Alumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Alumnos));
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Lbl_NoControl = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_Carrera = new System.Windows.Forms.Label();
            this.Txt_NoControl = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.db_Alumnos = new System.Windows.Forms.DataGridView();
            this.Cmb_Carrera = new System.Windows.Forms.ComboBox();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.db_Alumnos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Registrar.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.fondo_verde_157556_;
            this.Btn_Registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Registrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Registrar.Image")));
            this.Btn_Registrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Registrar.Location = new System.Drawing.Point(17, 48);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(82, 57);
            this.Btn_Registrar.TabIndex = 4;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Registrar.UseVisualStyleBackColor = false;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Borrar.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.fondo_verde_157556_;
            this.Btn_Borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Borrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Borrar.Image")));
            this.Btn_Borrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Borrar.Location = new System.Drawing.Point(17, 178);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(82, 57);
            this.Btn_Borrar.TabIndex = 6;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Borrar.UseVisualStyleBackColor = false;
            this.Btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click_1);
            // 
            // Lbl_NoControl
            // 
            this.Lbl_NoControl.AutoSize = true;
            this.Lbl_NoControl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NoControl.Location = new System.Drawing.Point(6, 31);
            this.Lbl_NoControl.Name = "Lbl_NoControl";
            this.Lbl_NoControl.Size = new System.Drawing.Size(112, 18);
            this.Lbl_NoControl.TabIndex = 9;
            this.Lbl_NoControl.Text = "No. de Control:";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.Location = new System.Drawing.Point(50, 61);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(68, 18);
            this.Lbl_Nombre.TabIndex = 10;
            this.Lbl_Nombre.Text = "Nombre:";
            // 
            // Lbl_Carrera
            // 
            this.Lbl_Carrera.AutoSize = true;
            this.Lbl_Carrera.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Carrera.Location = new System.Drawing.Point(52, 94);
            this.Lbl_Carrera.Name = "Lbl_Carrera";
            this.Lbl_Carrera.Size = new System.Drawing.Size(66, 18);
            this.Lbl_Carrera.TabIndex = 11;
            this.Lbl_Carrera.Text = "Carrera:";
            // 
            // Txt_NoControl
            // 
            this.Txt_NoControl.Location = new System.Drawing.Point(124, 25);
            this.Txt_NoControl.MaxLength = 8;
            this.Txt_NoControl.Name = "Txt_NoControl";
            this.Txt_NoControl.Size = new System.Drawing.Size(100, 27);
            this.Txt_NoControl.TabIndex = 1;
            this.Txt_NoControl.TextChanged += new System.EventHandler(this.Txt_NoControl_TextChanged);
            this.Txt_NoControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NoControl_KeyPress);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(124, 57);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(323, 27);
            this.Txt_Nombre.TabIndex = 2;
            // 
            // db_Alumnos
            // 
            this.db_Alumnos.AllowUserToAddRows = false;
            this.db_Alumnos.AllowUserToOrderColumns = true;
            this.db_Alumnos.BackgroundColor = System.Drawing.Color.White;
            this.db_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_Alumnos.Enabled = false;
            this.db_Alumnos.GridColor = System.Drawing.Color.White;
            this.db_Alumnos.Location = new System.Drawing.Point(25, 189);
            this.db_Alumnos.Name = "db_Alumnos";
            this.db_Alumnos.ReadOnly = true;
            this.db_Alumnos.RowHeadersVisible = false;
            this.db_Alumnos.Size = new System.Drawing.Size(455, 221);
            this.db_Alumnos.TabIndex = 7;
            // 
            // Cmb_Carrera
            // 
            this.Cmb_Carrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Carrera.FormattingEnabled = true;
            this.Cmb_Carrera.Items.AddRange(new object[] {
            "Ing. Sistemas Computacionales",
            "Ing. Informática",
            "Ing. Industrial",
            "Ing. Biomédica",
            "Ing. Eléctrica",
            "Ing. Electrónica",
            "Ing. Mecánica",
            "Ing. Mecatrónica",
            "Ing. Gestión Empresarial",
            "Lic. Administración"});
            this.Cmb_Carrera.Location = new System.Drawing.Point(124, 90);
            this.Cmb_Carrera.Name = "Cmb_Carrera";
            this.Cmb_Carrera.Size = new System.Drawing.Size(323, 27);
            this.Cmb_Carrera.TabIndex = 3;
            this.Cmb_Carrera.SelectedIndexChanged += new System.EventHandler(this.Cmb_Carrera_SelectedIndexChanged);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Modificar.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.fondo_verde_157556_;
            this.Btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Modificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Modificar.Location = new System.Drawing.Point(17, 111);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(82, 61);
            this.Btn_Modificar.TabIndex = 5;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.fondo_verde_157556_;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.Image = global::Control_de_Laboratorio.Properties.Resources._1432613538_stock_home;
            this.btnHome.Location = new System.Drawing.Point(559, 359);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(54, 51);
            this.btnHome.TabIndex = 8;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Cmb_Carrera);
            this.groupBox1.Controls.Add(this.Txt_Nombre);
            this.groupBox1.Controls.Add(this.Txt_NoControl);
            this.groupBox1.Controls.Add(this.Lbl_Carrera);
            this.groupBox1.Controls.Add(this.Lbl_Nombre);
            this.groupBox1.Controls.Add(this.Lbl_NoControl);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 129);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.fondo_verde_157556_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 43);
            this.panel2.TabIndex = 26;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources._1432619285_close_window;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Location = new System.Drawing.Point(585, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 34);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Btn_Modificar);
            this.groupBox2.Controls.Add(this.Btn_Borrar);
            this.groupBox2.Controls.Add(this.Btn_Registrar);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(494, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 248);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // Frm_Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.a_001_6400_fondo_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(631, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.db_Alumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.db_Alumnos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Registrar;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.Label Lbl_NoControl;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_Carrera;
        private System.Windows.Forms.TextBox Txt_NoControl;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.DataGridView db_Alumnos;
        private System.Windows.Forms.ComboBox Cmb_Carrera;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}