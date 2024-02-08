namespace UI
{
	partial class FrmSireVentas
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
			this.cboAño = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cboPeriodo = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.rbSire = new System.Windows.Forms.RadioButton();
			this.rbSap = new System.Windows.Forms.RadioButton();
			this.rbComparacion = new System.Windows.Forms.RadioButton();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cboAño
			// 
			this.cboAño.FormattingEnabled = true;
			this.cboAño.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
			this.cboAño.Location = new System.Drawing.Point(128, 27);
			this.cboAño.Name = "cboAño";
			this.cboAño.Size = new System.Drawing.Size(59, 21);
			this.cboAño.TabIndex = 0;
			this.cboAño.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Escoger periodo :";
			this.label1.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// cboPeriodo
			// 
			this.cboPeriodo.FormattingEnabled = true;
			this.cboPeriodo.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo"});
			this.cboPeriodo.Location = new System.Drawing.Point(193, 27);
			this.cboPeriodo.Name = "cboPeriodo";
			this.cboPeriodo.Size = new System.Drawing.Size(87, 21);
			this.cboPeriodo.TabIndex = 2;
			this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(26, 89);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1132, 558);
			this.dataGridView1.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(872, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 34);
			this.button1.TabIndex = 4;
			this.button1.Text = "Buscar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(960, 24);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 34);
			this.button2.TabIndex = 5;
			this.button2.Text = "Exportar";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// rbSire
			// 
			this.rbSire.AutoSize = true;
			this.rbSire.Location = new System.Drawing.Point(1191, 99);
			this.rbSire.Name = "rbSire";
			this.rbSire.Size = new System.Drawing.Size(50, 17);
			this.rbSire.TabIndex = 6;
			this.rbSire.TabStop = true;
			this.rbSire.Text = "SIRE";
			this.rbSire.UseVisualStyleBackColor = true;
			// 
			// rbSap
			// 
			this.rbSap.AutoSize = true;
			this.rbSap.Location = new System.Drawing.Point(1191, 122);
			this.rbSap.Name = "rbSap";
			this.rbSap.Size = new System.Drawing.Size(46, 17);
			this.rbSap.TabIndex = 7;
			this.rbSap.TabStop = true;
			this.rbSap.Text = "SAP";
			this.rbSap.UseVisualStyleBackColor = true;
			// 
			// rbComparacion
			// 
			this.rbComparacion.AutoSize = true;
			this.rbComparacion.Location = new System.Drawing.Point(1191, 145);
			this.rbComparacion.Name = "rbComparacion";
			this.rbComparacion.Size = new System.Drawing.Size(104, 17);
			this.rbComparacion.TabIndex = 8;
			this.rbComparacion.TabStop = true;
			this.rbComparacion.Text = "COMPARACION";
			this.rbComparacion.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(1191, 191);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(122, 34);
			this.button3.TabIndex = 9;
			this.button3.Text = "Aceptar Propuesta";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(1191, 508);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(122, 34);
			this.button4.TabIndex = 10;
			this.button4.Text = "Reemplazar Propuesta";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(236, 671);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Cantidad Documentos :";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(358, 668);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(62, 20);
			this.textBox1.TabIndex = 12;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(358, 694);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(62, 20);
			this.textBox2.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(236, 697);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Monto Total Soles :";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(1036, 697);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(122, 34);
			this.button5.TabIndex = 15;
			this.button5.Text = "Ajuste de Periodos";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.Location = new System.Drawing.Point(23, 720);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(181, 14);
			this.linkLabel1.TabIndex = 16;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Click para dirigirse al Portal Sunat";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(1191, 634);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(133, 99);
			this.panel1.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(45, 66);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 13);
			this.label6.TabIndex = 23;
			this.label6.Text = "Faltante";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.panel4.Location = new System.Drawing.Point(12, 63);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(23, 21);
			this.panel4.TabIndex = 22;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(41, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "Incongruente";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(41, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 18;
			this.label4.Text = "Correcto";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.panel3.Location = new System.Drawing.Point(12, 36);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(23, 21);
			this.panel3.TabIndex = 19;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.panel2.Location = new System.Drawing.Point(12, 9);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(23, 21);
			this.panel2.TabIndex = 18;
			// 
			// FrmSireVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1349, 766);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.rbComparacion);
			this.Controls.Add(this.rbSap);
			this.Controls.Add(this.rbSire);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.cboPeriodo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cboAño);
			this.Name = "FrmSireVentas";
			this.Text = "SIRE VENTAS";
			this.Load += new System.EventHandler(this.FrmSireVentas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboAño;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboPeriodo;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.RadioButton rbSire;
		private System.Windows.Forms.RadioButton rbSap;
		private System.Windows.Forms.RadioButton rbComparacion;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel4;
	}
}

