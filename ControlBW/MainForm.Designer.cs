
namespace ControlBW
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnConsultarDivisas = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbTipo_Pago = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMonto = new System.Windows.Forms.TextBox();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnConsultaBsF = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.DarkRed;
			this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSalir.Location = new System.Drawing.Point(554, 12);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(66, 31);
			this.btnSalir.TabIndex = 0;
			this.btnSalir.Text = "SALIR";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnConsultarDivisas
			// 
			this.btnConsultarDivisas.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnConsultarDivisas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConsultarDivisas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultarDivisas.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultarDivisas.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnConsultarDivisas.Location = new System.Drawing.Point(506, 239);
			this.btnConsultarDivisas.Name = "btnConsultarDivisas";
			this.btnConsultarDivisas.Size = new System.Drawing.Size(114, 67);
			this.btnConsultarDivisas.TabIndex = 2;
			this.btnConsultarDivisas.Text = "CONSULTAR INGRESOS ($)";
			this.btnConsultarDivisas.UseVisualStyleBackColor = false;
			this.btnConsultarDivisas.Click += new System.EventHandler(this.BtnConsultarDivisasClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(82, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(385, 31);
			this.label1.TabIndex = 4;
			this.label1.Text = "CONTROL DE REGISTRO DE INGRESOS";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(130, 207);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Cantidad:";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidad.Location = new System.Drawing.Point(204, 205);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(52, 20);
			this.txtCantidad.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(120, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Fecha de ingreso: ";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha.Location = new System.Drawing.Point(242, 133);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(200, 20);
			this.dtpFecha.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new System.Drawing.Point(120, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Tipo de pago:";
			// 
			// cmbTipo_Pago
			// 
			this.cmbTipo_Pago.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTipo_Pago.FormattingEnabled = true;
			this.cmbTipo_Pago.Items.AddRange(new object[] {
									"",
									"Pago movil",
									"Efectivo (Bs.F)",
									"Divisas ($)"});
			this.cmbTipo_Pago.Location = new System.Drawing.Point(217, 164);
			this.cmbTipo_Pago.Name = "cmbTipo_Pago";
			this.cmbTipo_Pago.Size = new System.Drawing.Size(121, 24);
			this.cmbTipo_Pago.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.Location = new System.Drawing.Point(137, 242);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "Monto:";
			// 
			// txtMonto
			// 
			this.txtMonto.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMonto.Location = new System.Drawing.Point(204, 240);
			this.txtMonto.Name = "txtMonto";
			this.txtMonto.Size = new System.Drawing.Size(52, 20);
			this.txtMonto.TabIndex = 12;
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnRegistrar.Location = new System.Drawing.Point(506, 62);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(114, 65);
			this.btnRegistrar.TabIndex = 15;
			this.btnRegistrar.Text = "REGISTRAR CORTE";
			this.btnRegistrar.UseVisualStyleBackColor = false;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// erpError
			// 
			this.erpError.ContainerControl = this;
			// 
			// btnConsultaBsF
			// 
			this.btnConsultaBsF.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnConsultaBsF.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConsultaBsF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultaBsF.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultaBsF.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnConsultaBsF.Location = new System.Drawing.Point(506, 147);
			this.btnConsultaBsF.Name = "btnConsultaBsF";
			this.btnConsultaBsF.Size = new System.Drawing.Size(114, 68);
			this.btnConsultaBsF.TabIndex = 16;
			this.btnConsultaBsF.Text = "CONSULTAR INGRESOS (Bs.F)";
			this.btnConsultaBsF.UseVisualStyleBackColor = false;
			this.btnConsultaBsF.Click += new System.EventHandler(this.BtnConsultaBsFClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.pictureBox1.Location = new System.Drawing.Point(473, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(160, 423);
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(35, 111);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 176);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 18;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(12, 12);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(64, 62);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 19;
			this.pictureBox3.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HotTrack;
			this.ClientSize = new System.Drawing.Size(632, 327);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.btnConsultaBsF);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.txtMonto);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmbTipo_Pago);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnConsultarDivisas);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ControlBW";
			((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ErrorProvider erpError;
		private System.Windows.Forms.TextBox txtMonto;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbTipo_Pago;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnConsultaBsF;
		private System.Windows.Forms.Button btnConsultarDivisas;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.Button btnSalir;
	}
}
