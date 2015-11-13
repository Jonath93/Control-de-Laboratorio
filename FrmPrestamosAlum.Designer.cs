namespace Control_de_Laboratorio
{
    partial class FrmPrestamosAlum
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_observaciones = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dTp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_Horaprestamo = new System.Windows.Forms.ComboBox();
            this.cmb_Horaentrega = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_NoCañon = new System.Windows.Forms.TextBox();
            this.Txt_NoControl = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtg_Alumnos = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.dtg_Cañones = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.db_Prestamo = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Alumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Cañones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Prestamo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dTp_Fecha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmb_Horaprestamo);
            this.groupBox1.Controls.Add(this.cmb_Horaentrega);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_NoCañon);
            this.groupBox1.Controls.Add(this.Txt_NoControl);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmb_observaciones);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(555, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 65);
            this.panel1.TabIndex = 47;
            // 
            // cmb_observaciones
            // 
            this.cmb_observaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_observaciones.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_observaciones.FormattingEnabled = true;
            this.cmb_observaciones.Items.AddRange(new object[] {
            "Excelente",
            "Bueno",
            "Regular",
            "Malo",
            "Muy Malo"});
            this.cmb_observaciones.Location = new System.Drawing.Point(3, 26);
            this.cmb_observaciones.Name = "cmb_observaciones";
            this.cmb_observaciones.Size = new System.Drawing.Size(150, 27);
            this.cmb_observaciones.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Observaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "Fecha de Préstamo:";
            // 
            // dTp_Fecha
            // 
            this.dTp_Fecha.CustomFormat = "MM/dd/yyyy";
            this.dTp_Fecha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTp_Fecha.Location = new System.Drawing.Point(436, 22);
            this.dTp_Fecha.Name = "dTp_Fecha";
            this.dTp_Fecha.Size = new System.Drawing.Size(109, 27);
            this.dTp_Fecha.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "Hora de Préstamo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(434, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 46;
            this.label8.Text = "Hora Entrega";
            // 
            // cmb_Horaprestamo
            // 
            this.cmb_Horaprestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Horaprestamo.FormattingEnabled = true;
            this.cmb_Horaprestamo.Items.AddRange(new object[] {
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.cmb_Horaprestamo.Location = new System.Drawing.Point(330, 85);
            this.cmb_Horaprestamo.Name = "cmb_Horaprestamo";
            this.cmb_Horaprestamo.Size = new System.Drawing.Size(85, 27);
            this.cmb_Horaprestamo.TabIndex = 4;
            // 
            // cmb_Horaentrega
            // 
            this.cmb_Horaentrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Horaentrega.FormattingEnabled = true;
            this.cmb_Horaentrega.Items.AddRange(new object[] {
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.cmb_Horaentrega.Location = new System.Drawing.Point(437, 84);
            this.cmb_Horaentrega.Name = "cmb_Horaentrega";
            this.cmb_Horaentrega.Size = new System.Drawing.Size(85, 27);
            this.cmb_Horaentrega.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "No. Control:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Clave Proyector:";
            // 
            // Txt_NoCañon
            // 
            this.Txt_NoCañon.Location = new System.Drawing.Point(157, 22);
            this.Txt_NoCañon.MaxLength = 3;
            this.Txt_NoCañon.Name = "Txt_NoCañon";
            this.Txt_NoCañon.Size = new System.Drawing.Size(111, 27);
            this.Txt_NoCañon.TabIndex = 1;
            // 
            // Txt_NoControl
            // 
            this.Txt_NoControl.Location = new System.Drawing.Point(157, 55);
            this.Txt_NoControl.MaxLength = 8;
            this.Txt_NoControl.Name = "Txt_NoControl";
            this.Txt_NoControl.Size = new System.Drawing.Size(111, 27);
            this.Txt_NoControl.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnRegistrar);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.fondo_verde_157556_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Control_de_Laboratorio.Properties.Resources._1432598470_Check;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(27, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Entregar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.fondo_verde_157556_;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Image = global::Control_de_Laboratorio.Properties.Resources._1432598470_Check;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(27, 20);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(131, 55);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(214, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 19);
            this.label10.TabIndex = 26;
            this.label10.Text = "Alumnos";
            // 
            // dtg_Alumnos
            // 
            this.dtg_Alumnos.AllowUserToAddRows = false;
            this.dtg_Alumnos.AllowUserToDeleteRows = false;
            this.dtg_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Alumnos.Location = new System.Drawing.Point(218, 206);
            this.dtg_Alumnos.Name = "dtg_Alumnos";
            this.dtg_Alumnos.ReadOnly = true;
            this.dtg_Alumnos.RowHeadersVisible = false;
            this.dtg_Alumnos.Size = new System.Drawing.Size(241, 150);
            this.dtg_Alumnos.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(475, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "Cañones";
            // 
            // dtg_Cañones
            // 
            this.dtg_Cañones.AllowUserToAddRows = false;
            this.dtg_Cañones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Cañones.Location = new System.Drawing.Point(465, 206);
            this.dtg_Cañones.Name = "dtg_Cañones";
            this.dtg_Cañones.ReadOnly = true;
            this.dtg_Cañones.RowHeadersVisible = false;
            this.dtg_Cañones.Size = new System.Drawing.Size(242, 150);
            this.dtg_Cañones.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 19);
            this.label9.TabIndex = 30;
            this.label9.Text = "Prestamo";
            // 
            // db_Prestamo
            // 
            this.db_Prestamo.AllowUserToAddRows = false;
            this.db_Prestamo.AllowUserToDeleteRows = false;
            this.db_Prestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_Prestamo.Location = new System.Drawing.Point(12, 374);
            this.db_Prestamo.Name = "db_Prestamo";
            this.db_Prestamo.ReadOnly = true;
            this.db_Prestamo.RowHeadersVisible = false;
            this.db_Prestamo.Size = new System.Drawing.Size(701, 116);
            this.db_Prestamo.TabIndex = 10;
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
            this.panel2.Size = new System.Drawing.Size(739, 43);
            this.panel2.TabIndex = 31;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources._1432619285_close_window;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Location = new System.Drawing.Point(693, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 34);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Prestamos para Alumnos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmPrestamosAlum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.a_001_6400_fondo_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.db_Prestamo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtg_Cañones);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtg_Alumnos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrestamosAlum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrestamosAlum";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Alumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Cañones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Prestamo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_NoCañon;
        private System.Windows.Forms.TextBox Txt_NoControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtg_Alumnos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dtg_Cañones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView db_Prestamo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_observaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTp_Fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_Horaprestamo;
        private System.Windows.Forms.ComboBox cmb_Horaentrega;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}