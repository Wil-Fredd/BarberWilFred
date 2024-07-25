
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ControlBW.Models;
using ControlBW.Forms;
using System.IO;

namespace ControlBW
{
	public partial class MainForm : Form
	{
		List<Registro_Cortes> listCortes = new List<Registro_Cortes>();
		public MainForm()
		{
			InitializeComponent();
			if (File.Exists("Registro_Cortes.txt"))
			{
				Transferir_Datos();
			}
			
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			DialogResult Respuesta = MessageBox.Show("¿Estás seguro que deseas salir?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (Respuesta == DialogResult.Yes)
				{
					Dispose();
				}			
		}
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			if (validarTipo_Pago() == false)
			{
				return;
			}
			if (validarCantidad() == false)
			{
				return;
			}
			if (validarMonto() == false)
			{
				return;
			}
			Registro_Cortes misCortes = new Registro_Cortes();
			misCortes.FechaI = dtpFecha.Text;
			misCortes.Tipo = cmbTipo_Pago.SelectedItem.ToString();
			misCortes.Cantidad = Convert.ToInt32(txtCantidad.Text);
			misCortes.Monto = float.Parse(txtMonto.Text);
			listCortes.Add(misCortes);
			Guardar_Datos();
			Clear();
		}
		private void Guardar_Datos()
		{
			StreamWriter archivo = new StreamWriter("Registro_Cortes.txt", true);
			archivo.WriteLine(dtpFecha.Text + ";" + cmbTipo_Pago.SelectedItem + ";" + txtCantidad.Text + ";" + txtMonto.Text);
			archivo.Close();
		}
		
		private void Transferir_Datos()
		{
			string[] lineas = File.ReadAllLines("Registro_Cortes.txt");
			foreach (string linea in lineas) 
			{
				string[] partes = linea.Split(';');
				Registro_Cortes cortes = new Registro_Cortes() {FechaI = partes[0], Tipo = partes[1], Cantidad = int.Parse(partes[2]), Monto =  float.Parse(partes[3])};
				listCortes.Add(cortes);
			}
		}
		void BtnConsultaBsFClick(object sender, EventArgs e)
		{
			Ingresos_BsF IngresosBsF = new Ingresos_BsF();
			IngresosBsF.Show();
		}
		
		void BtnConsultarDivisasClick(object sender, EventArgs e)
		{
			Ingresos_Divisas IngresosDolar = new Ingresos_Divisas();
			IngresosDolar.Show();
		}
		
		private void Clear()
		{
			cmbTipo_Pago.SelectedIndex = 0;
			txtCantidad.Clear();
			txtMonto.Clear();
		}
		// ------- * VALIDACIONES * -------
		int num; float numF;
		private bool validarTipo_Pago()
		{
			if (string.IsNullOrEmpty(cmbTipo_Pago.Text))
			{
				erpError.SetError(cmbTipo_Pago, "Debe ingresar un tipo de pago");
					return false;
			}
			else
			{
				erpError.SetError(cmbTipo_Pago, "");
				return true;
				}
			}
		private bool validarCantidad()
		{		
			if(!int.TryParse(txtCantidad.Text, out num) || txtCantidad.Text == "")
			{
				erpError.SetError(txtCantidad, "Debe ingresar un valor númerico");
				txtCantidad.Focus();
				return false;
			}
			else
			{
				erpError.SetError(txtCantidad, "");
				return true;
				}
			}
		private bool validarMonto()
		{
			if(!float.TryParse(txtMonto.Text, out numF) || string.IsNullOrEmpty(txtMonto.Text))
			{
				erpError.SetError(txtMonto, "Debe ingresar un valor númerico");
				txtMonto.Focus();
				return false;
			}
			else
			{
				erpError.SetError(txtMonto, "");
				return true;
			}
		}
	}
}
