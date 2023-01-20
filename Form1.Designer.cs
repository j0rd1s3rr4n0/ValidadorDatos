namespace ValidadorDadesJson
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_importData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_total_personas = new System.Windows.Forms.Label();
            this.label_num_validas = new System.Windows.Forms.Label();
            this.label_num_invalidas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgrid_datos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_pathFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_eliminacio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_filterData = new System.Windows.Forms.Button();
            this.cb_modoUso = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_linq = new System.Windows.Forms.TextBox();
            this.tb_seq = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_datos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "IMPORTACION DE DATOS";
            // 
            // btn_importData
            // 
            this.btn_importData.Location = new System.Drawing.Point(39, 137);
            this.btn_importData.Name = "btn_importData";
            this.btn_importData.Size = new System.Drawing.Size(266, 39);
            this.btn_importData.TabIndex = 2;
            this.btn_importData.Text = "Importar Archivo (.JSON)";
            this.btn_importData.UseVisualStyleBackColor = true;
            this.btn_importData.Click += new System.EventHandler(this.buttonInsertDataFromFile);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "TABLA DE DATOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_total_personas);
            this.groupBox1.Controls.Add(this.label_num_validas);
            this.groupBox1.Controls.Add(this.label_num_invalidas);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dgrid_datos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 426);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label_total_personas
            // 
            this.label_total_personas.AutoSize = true;
            this.label_total_personas.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label_total_personas.Location = new System.Drawing.Point(279, 384);
            this.label_total_personas.Name = "label_total_personas";
            this.label_total_personas.Size = new System.Drawing.Size(20, 23);
            this.label_total_personas.TabIndex = 23;
            this.label_total_personas.Text = "0";
            // 
            // label_num_validas
            // 
            this.label_num_validas.AutoSize = true;
            this.label_num_validas.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label_num_validas.Location = new System.Drawing.Point(544, 383);
            this.label_num_validas.Name = "label_num_validas";
            this.label_num_validas.Size = new System.Drawing.Size(37, 23);
            this.label_num_validas.TabIndex = 22;
            this.label_num_validas.Text = "0/0";
            // 
            // label_num_invalidas
            // 
            this.label_num_invalidas.AutoSize = true;
            this.label_num_invalidas.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label_num_invalidas.Location = new System.Drawing.Point(807, 384);
            this.label_num_invalidas.Name = "label_num_invalidas";
            this.label_num_invalidas.Size = new System.Drawing.Size(37, 23);
            this.label_num_invalidas.TabIndex = 21;
            this.label_num_invalidas.Text = "0/0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label12.Location = new System.Drawing.Point(639, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 23);
            this.label12.TabIndex = 17;
            this.label12.Text = "Personas Invalidas:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label11.Location = new System.Drawing.Point(391, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "Personas Validas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label10.Location = new System.Drawing.Point(142, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Num Personas:";
            // 
            // dgrid_datos
            // 
            this.dgrid_datos.AllowUserToAddRows = false;
            this.dgrid_datos.AllowUserToDeleteRows = false;
            this.dgrid_datos.AllowUserToOrderColumns = true;
            this.dgrid_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrid_datos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrid_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_datos.Location = new System.Drawing.Point(11, 46);
            this.dgrid_datos.Name = "dgrid_datos";
            this.dgrid_datos.RowHeadersWidth = 51;
            this.dgrid_datos.RowTemplate.Height = 24;
            this.dgrid_datos.ShowCellErrors = false;
            this.dgrid_datos.ShowCellToolTips = false;
            this.dgrid_datos.ShowEditingIcon = false;
            this.dgrid_datos.Size = new System.Drawing.Size(1007, 322);
            this.dgrid_datos.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_pathFile);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_importData);
            this.groupBox2.Location = new System.Drawing.Point(1042, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 223);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // tb_pathFile
            // 
            this.tb_pathFile.Location = new System.Drawing.Point(39, 109);
            this.tb_pathFile.Name = "tb_pathFile";
            this.tb_pathFile.Size = new System.Drawing.Size(266, 22);
            this.tb_pathFile.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Archivo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_eliminacio);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btn_filterData);
            this.groupBox3.Controls.Add(this.cb_modoUso);
            this.groupBox3.Location = new System.Drawing.Point(1042, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 197);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // cb_eliminacio
            // 
            this.cb_eliminacio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_eliminacio.FormattingEnabled = true;
            this.cb_eliminacio.Items.AddRange(new object[] {
            "ELIMINAR VALIDOS",
            "ELIMINAR INVALIDOS"});
            this.cb_eliminacio.Location = new System.Drawing.Point(39, 98);
            this.cb_eliminacio.Name = "cb_eliminacio";
            this.cb_eliminacio.Size = new System.Drawing.Size(266, 24);
            this.cb_eliminacio.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "METODO DE EJECUCIÓN";
            // 
            // btn_filterData
            // 
            this.btn_filterData.Location = new System.Drawing.Point(39, 140);
            this.btn_filterData.Name = "btn_filterData";
            this.btn_filterData.Size = new System.Drawing.Size(266, 38);
            this.btn_filterData.TabIndex = 6;
            this.btn_filterData.Text = "Filtrar Datos";
            this.btn_filterData.UseVisualStyleBackColor = true;
            this.btn_filterData.Click += new System.EventHandler(this.buttonFilterDataFromFilter);
            // 
            // cb_modoUso
            // 
            this.cb_modoUso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_modoUso.FormattingEnabled = true;
            this.cb_modoUso.Items.AddRange(new object[] {
            "PARALLEL LINQ",
            "SEQUENCIAL"});
            this.cb_modoUso.Location = new System.Drawing.Point(39, 57);
            this.cb_modoUso.Name = "cb_modoUso";
            this.cb_modoUso.Size = new System.Drawing.Size(266, 24);
            this.cb_modoUso.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.tb_linq);
            this.groupBox4.Controls.Add(this.tb_seq);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 454);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1353, 123);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label8.Location = new System.Drawing.Point(1180, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "segons";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label9.Location = new System.Drawing.Point(496, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "segons";
            // 
            // tb_linq
            // 
            this.tb_linq.Location = new System.Drawing.Point(912, 74);
            this.tb_linq.Name = "tb_linq";
            this.tb_linq.Size = new System.Drawing.Size(262, 22);
            this.tb_linq.TabIndex = 18;
            // 
            // tb_seq
            // 
            this.tb_seq.Location = new System.Drawing.Point(228, 76);
            this.tb_seq.Name = "tb_seq";
            this.tb_seq.Size = new System.Drawing.Size(262, 22);
            this.tb_seq.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label7.Location = new System.Drawing.Point(803, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Parallel Linq";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label6.Location = new System.Drawing.Point(119, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sequencial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(412, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "ESTADISTICAS DE TIEMPO DE PROCESO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1389, 589);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validador Datos Json Parallel - J0rd1s3rr4n0";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.AppWorkspace;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_datos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_importData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgrid_datos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_filterData;
        private System.Windows.Forms.ComboBox cb_modoUso;
        private System.Windows.Forms.TextBox tb_pathFile;
        private System.Windows.Forms.ComboBox cb_eliminacio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_linq;
        private System.Windows.Forms.TextBox tb_seq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_total_personas;
        private System.Windows.Forms.Label label_num_validas;
        private System.Windows.Forms.Label label_num_invalidas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

