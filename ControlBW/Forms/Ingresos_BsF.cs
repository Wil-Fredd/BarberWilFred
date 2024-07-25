
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using ControlBW.Models;
using System.IO;

namespace ControlBW.Forms
{

	public partial class Ingresos_BsF : Form
	{
		List<Registro_Cortes> listCortes = new List<Registro_Cortes>();
		public Ingresos_BsF()
		{
			InitializeComponent();
			if (File.Exists("Registro_Cortes.txt"))
			{
				Transferir_Datos();
			}
			Cargar_Datos();
			Calcular_Monto();

		}
		void BtnSalirClick(object sender, EventArgs e)
		{
			DialogResult Respuesta = MessageBox.Show("¿Estás seguro que deseas salir?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (Respuesta == DialogResult.Yes)
				{
					Dispose();
				}			
		}
		
		private void Transferir_Datos()
		{
			string[] lineas = File.ReadAllLines("Registro_Cortes.txt");
			foreach (string linea in lineas) 
			{
				string[] partes = linea.Split(';');
				Registro_Cortes cortes = new Registro_Cortes() {FechaI = partes[0], Tipo = partes[1], Cantidad = int.Parse(partes[2]), Monto = float.Parse(partes[3])};
				listCortes.Add(cortes);
			}
		}
		
		private void Cargar_Datos()
		{
			foreach (Registro_Cortes ingresos in listCortes)
			{
				if (ingresos.Tipo == "Pago movil" || ingresos.Tipo == "Efectivo (Bs.F)")
				{
					int datos = dgvIngresos.Rows.Add();
					dgvIngresos.Rows[datos].Cells["Fecha"].Value = ingresos.FechaI;
					dgvIngresos.Rows[datos].Cells["Tipo_Pago"].Value = ingresos.Tipo;
					dgvIngresos.Rows[datos].Cells["Cantidad"].Value = ingresos.Cantidad;
					dgvIngresos.Rows[datos].Cells["Monto"].Value = ingresos.Monto;
				}
			}
		}
		private void Calcular_Monto()
		{
			float resultado = 0f;
			foreach (System.Windows.Forms.DataGridViewRow row in dgvIngresos.Rows)
			{
				resultado += Convert.ToSingle(row.Cells["Monto"].Value);
			}
			lblMontoT.Text = resultado.ToString() + " Bs.F";
		}
	}
}