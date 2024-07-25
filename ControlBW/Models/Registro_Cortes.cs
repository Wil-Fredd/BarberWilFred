
using System;

namespace ControlBW.Models
{
	public class Registro_Cortes
	{
		private string fechaI;
		
		public string FechaI
		{
			get { return fechaI; }
			set { fechaI = value; }
		}
		
		private string tipo;
		
		public string Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}
		
		private int cantidad;
		
		public int Cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}
		
		private float monto;
		
		public float Monto
		{
			get { return monto; }
			set { monto = value; }
		}
		public Registro_Cortes()
		{
		}
	}
}
