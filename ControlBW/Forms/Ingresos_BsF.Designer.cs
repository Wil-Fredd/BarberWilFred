
namespace ControlBW.Forms
{
	partial class Ingresos_BsF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingresos_BsF));
			this.btnSalir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvIngresos = new System.Windows.Forms.DataGridView();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblMontoT = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.DarkRed;
			this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnSalir.Location = new System.Drawing.Point(553, 12);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(66, 31);
			this.btnSalir.TabIndex = 1;
			this.btnSalir.Text = "SALIR";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(12, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(524, 27);
			this.label1.TabIndex = 5;
			this.label1.Text = "CONSULTA DE INGRESOS EN EFECTIVO (BS.F)";
			// 
			// dgvIngresos
			// 
			this.dgvIngresos.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Fecha,
									this.Tipo_Pago,
									this.Cantidad,
									this.Monto});
			this.dgvIngresos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvIngresos.Location = new System.Drawing.Point(12, 71);
			this.dgvIngresos.Name = "dgvIngresos";
			this.dgvIngresos.Size = new System.Drawing.Size(443, 338);
			this.dgvIngresos.TabIndex = 6;
			// 
			// Fecha
			// 
			this.Fecha.HeaderText = "Fecha de ingreso";
			this.Fecha.Name = "Fecha";
			this.Fecha.ReadOnly = true;
			// 
			// Tipo_Pago
			// 
			this.Tipo_Pago.HeaderText = "Tipo de pago";
			this.Tipo_Pago.Name = "Tipo_Pago";
			this.Tipo_Pago.ReadOnly = true;
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.ReadOnly = true;
			// 
			// Monto
			// 
			this.Monto.HeaderText = "Monto";
			this.Monto.Name = "Monto";
			this.Monto.ReadOnly = true;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.ForestGreen;
			this.label2.Font = new System.Drawing.Font("Trebuchet MS", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(471, 297);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 53);
			this.label2.TabIndex = 13;
			this.label2.Text = "SUBTOTAL";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.ForestGreen;
			this.pictureBox1.Location = new System.Drawing.Point(471, 292);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 115);
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// lblMontoT
			// 
			this.lblMontoT.BackColor = System.Drawing.Color.ForestGreen;
			this.lblMontoT.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMontoT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblMontoT.Location = new System.Drawing.Point(495, 378);
			this.lblMontoT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMontoT.Name = "lblMontoT";
			this.lblMontoT.Size = new System.Drawing.Size(124, 28);
			this.lblMontoT.TabIndex = 15;
			this.lblMontoT.Text = "0,00 Bs.F";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(484, 76);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(126, 180);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 16;
			this.pictureBox2.TabStop = false;
			// 
			// Ingresos_BsF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HotTrack;
			this.ClientSize = new System.Drawing.Size(632, 422);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.lblMontoT);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dgvIngresos);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSalir);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Ingresos_BsF";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ingresos en efectivo — Wil-Fred";
			((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lblMontoT;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Pago;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.DataGridView dgvIngresos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSalir;
	}
}
