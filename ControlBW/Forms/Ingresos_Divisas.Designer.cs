
namespace ControlBW.Forms
{
	partial class Ingresos_Divisas
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingresos_Divisas));
			this.btnSalir = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblMontoT = new System.Windows.Forms.Label();
			this.dgvIngresos = new System.Windows.Forms.DataGridView();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Maroon;
			this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnSalir.Location = new System.Drawing.Point(549, 17);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(66, 31);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "SALIR";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.ForestGreen;
			this.label2.Font = new System.Drawing.Font("Trebuchet MS", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(471, 302);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 53);
			this.label2.TabIndex = 15;
			this.label2.Text = "SUBTOTAL";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.ForestGreen;
			this.pictureBox1.Location = new System.Drawing.Point(471, 297);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 115);
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			// 
			// lblMontoT
			// 
			this.lblMontoT.BackColor = System.Drawing.Color.ForestGreen;
			this.lblMontoT.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMontoT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblMontoT.Location = new System.Drawing.Point(497, 384);
			this.lblMontoT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMontoT.Name = "lblMontoT";
			this.lblMontoT.Size = new System.Drawing.Size(124, 28);
			this.lblMontoT.TabIndex = 17;
			this.lblMontoT.Text = "0,00 Bs.F";
			// 
			// dgvIngresos
			// 
			this.dgvIngresos.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvIngresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Fecha,
									this.Tipo_Pago,
									this.Cantidad,
									this.Monto});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvIngresos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvIngresos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvIngresos.Location = new System.Drawing.Point(12, 73);
			this.dgvIngresos.Name = "dgvIngresos";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvIngresos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvIngresos.Size = new System.Drawing.Size(443, 338);
			this.dgvIngresos.TabIndex = 18;
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
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(12, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(459, 27);
			this.label1.TabIndex = 19;
			this.label1.Text = "CONSULTA DE INGRESOS EN DIVISAS ($)";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(483, 88);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(122, 186);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 20;
			this.pictureBox2.TabStop = false;
			// 
			// Ingresos_Divisas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HotTrack;
			this.ClientSize = new System.Drawing.Size(632, 423);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvIngresos);
			this.Controls.Add(this.lblMontoT);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnSalir);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Ingresos_Divisas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ingresos en divisas — Wil-Fred";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Pago;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.DataGridView dgvIngresos;
		private System.Windows.Forms.Label lblMontoT;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSalir;
	}
}
