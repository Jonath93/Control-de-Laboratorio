namespace Control_de_Laboratorio
{
    partial class Frm_Proyectores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Proyectores));
            this.Lbl_Marca = new System.Windows.Forms.Label();
            this.Lbl_Modelo = new System.Windows.Forms.Label();
            this.Txt_Marca = new System.Windows.Forms.TextBox();
            this.Txt_Modelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Clave = new System.Windows.Forms.TextBox();
            this.db_cañones = new System.Windows.Forms.DataGridView();
            this.Rad_Registrar = new System.Windows.Forms.RadioButton();
            this.Rad_Modificar = new System.Windows.Forms.RadioButton();
            this.Rad_Borrar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_cañones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Marca
            // 
            this.Lbl_Marca.AutoSize = true;
            this.Lbl_Marca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Marca.Location = new System.Drawing.Point(15, 58);
            this.Lbl_Marca.Name = "Lbl_Marca";
            this.Lbl_Marca.Size = new System.Drawing.Size(56, 18);
            this.Lbl_Marca.TabIndex = 7;
            this.Lbl_Marca.Text = "Marca:";
            // 
            // Lbl_Modelo
            // 
            this.Lbl_Modelo.AutoSize = true;
            this.Lbl_Modelo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Modelo.Location = new System.Drawing.Point(6, 89);
            this.Lbl_Modelo.Name = "Lbl_Modelo";
            this.Lbl_Modelo.Size = new System.Drawing.Size(64, 18);
            this.Lbl_Modelo.TabIndex = 8;
            this.Lbl_Modelo.Text = "Modelo:";
            // 
            // Txt_Marca
            // 
            this.Txt_Marca.Location = new System.Drawing.Point(70, 53);
            this.Txt_Marca.Name = "Txt_Marca";
            this.Txt_Marca.Size = new System.Drawing.Size(173, 27);
            this.Txt_Marca.TabIndex = 5;
            // 
            // Txt_Modelo
            // 
            this.Txt_Modelo.Location = new System.Drawing.Point(70, 86);
            this.Txt_Modelo.Name = "Txt_Modelo";
            this.Txt_Modelo.Size = new System.Drawing.Size(173, 27);
            this.Txt_Modelo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Clave:";
            // 
            // Txt_Clave
            // 
            this.Txt_Clave.Location = new System.Drawing.Point(70, 22);
            this.Txt_Clave.MaxLength = 3;
            this.Txt_Clave.Name = "Txt_Clave";
            this.Txt_Clave.Size = new System.Drawing.Size(173, 27);
            this.Txt_Clave.TabIndex = 4;
            this.Txt_Clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Clave_KeyPress);
            // 
            // db_cañones
            // 
            this.db_cañones.AllowUserToAddRows = false;
            this.db_cañones.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_cañones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.db_cañones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_cañones.Location = new System.Drawing.Point(74, 201);
            this.db_cañones.Name = "db_cañones";
            this.db_cañones.ReadOnly = true;
            this.db_cañones.RowHeadersVisible = false;
            this.db_cañones.Size = new System.Drawing.Size(318, 150);
            this.db_cañones.TabIndex = 10;
            // 
            // Rad_Registrar
            // 
            this.Rad_Registrar.AutoSize = true;
            this.Rad_Registrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Registrar.Location = new System.Drawing.Point(15, 31);
            this.Rad_Registrar.Name = "Rad_Registrar";
            this.Rad_Registrar.Size = new System.Drawing.Size(90, 22);
            this.Rad_Registrar.TabIndex = 1;
            this.Rad_Registrar.TabStop = true;
            this.Rad_Registrar.Text = "Registrar";
            this.Rad_Registrar.UseVisualStyleBackColor = true;
            this.Rad_Registrar.Click += new System.EventHandler(this.Rad_Registrar_Click);
            // 
            // Rad_Modificar
            // 
            this.Rad_Modificar.AutoSize = true;
            this.Rad_Modificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Modificar.Location = new System.Drawing.Point(15, 61);
            this.Rad_Modificar.Name = "Rad_Modificar";
            this.Rad_Modificar.Size = new System.Drawing.Size(91, 22);
            this.Rad_Modificar.TabIndex = 2;
            this.Rad_Modificar.TabStop = true;
            this.Rad_Modificar.Text = "Modificar";
            this.Rad_Modificar.UseVisualStyleBackColor = true;
            this.Rad_Modificar.Click += new System.EventHandler(this.Rad_Modificar_Click);
            // 
            // Rad_Borrar
            // 
            this.Rad_Borrar.AutoSize = true;
            this.Rad_Borrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Borrar.Location = new System.Drawing.Point(15, 94);
            this.Rad_Borrar.Name = "Rad_Borrar";
            this.Rad_Borrar.Size = new System.Drawing.Size(70, 22);
            this.Rad_Borrar.TabIndex = 3;
            this.Rad_Borrar.TabStop = true;
            this.Rad_Borrar.Text = "Borrar";
            this.Rad_Borrar.UseVisualStyleBackColor = true;
            this.Rad_Borrar.Click += new System.EventHandler(this.Rad_Borrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Rad_Registrar);
            this.groupBox1.Controls.Add(this.Rad_Borrar);
            this.groupBox1.Controls.Add(this.Rad_Modificar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(269, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 124);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.fondo_verde_157556_;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::Control_de_Laboratorio.Properties.Resources._1432613538_stock_home;
            this.btnHome.Location = new System.Drawing.Point(513, 306);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(54, 51);
            this.btnHome.TabIndex = 11;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_modificar.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.fondo_verde_157556_;
            this.Btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_modificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_modificar.Image")));
            this.Btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_modificar.Location = new System.Drawing.Point(422, 120);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(131, 55);
            this.Btn_modificar.TabIndex = 8;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.fondo_verde_157556_;
            this.Btn_Borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Borrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Borrar.Image")));
            this.Btn_Borrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Borrar.Location = new System.Drawing.Point(422, 181);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(131, 55);
            this.Btn_Borrar.TabIndex = 9;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Btn_Borrar.UseVisualStyleBackColor = true;
            this.Btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click_1);
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Registrar.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.fondo_verde_157556_;
            this.Btn_Registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Registrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registrar.Image = global::Control_de_Laboratorio.Properties.Resources._1432598470_Check;
            this.Btn_Registrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Registrar.Location = new System.Drawing.Point(422, 57);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(131, 55);
            this.Btn_Registrar.TabIndex = 7;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Btn_Registrar.UseVisualStyleBackColor = false;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Txt_Clave);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Txt_Modelo);
            this.groupBox2.Controls.Add(this.Txt_Marca);
            this.groupBox2.Controls.Add(this.Lbl_Modelo);
            this.groupBox2.Controls.Add(this.Lbl_Marca);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 124);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
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
            this.panel2.Size = new System.Drawing.Size(571, 43);
            this.panel2.TabIndex = 25;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources._1432619285_close_window;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Location = new System.Drawing.Point(525, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 34);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Cañones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frm_Proyectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Control_de_Laboratorio.Properties.Resources.a_001_6400_fondo_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 361);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.db_cañones);
            this.Controls.Add(this.Btn_Borrar);
            this.Controls.Add(this.Btn_Registrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Proyectores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Proyectores";
            ((System.ComponentModel.ISupportInitialize)(this.db_cañones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Marca;
        private System.Windows.Forms.Label Lbl_Modelo;
        private System.Windows.Forms.TextBox Txt_Marca;
        private System.Windows.Forms.TextBox Txt_Modelo;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.Button Btn_Registrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Clave;
        private System.Windows.Forms.DataGridView db_cañones;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.RadioButton Rad_Registrar;
        private System.Windows.Forms.RadioButton Rad_Modificar;
        private System.Windows.Forms.RadioButton Rad_Borrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
    }
}