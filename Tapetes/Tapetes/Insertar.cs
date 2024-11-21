/*
 * Created by SharpDevelop.
 * User: CC2_PC36
 * Date: 20/11/2024
 * Time: 07:25 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tapetes
{
	/// <summary>
	/// Description of Insertar.
	/// </summary>
	public partial class Insertar : Form
		
	{
		public int clickpintura;
		public int clickflores;
		public int clickfruta;
		public int clicktrabaj;
		public int intancho;
		public int intlargo;
		public int metros;
		public int resultadoaserrin;
		public int resultadotrabajadores;
		
		
		
		public Insertar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		 
		
		void Button5Click(object sender, EventArgs e)
		{
			string ancho=txtancho.Text;
			 intancho = int.Parse(ancho);
			 string largo= txtlargo.Text;
			 intlargo = int.Parse(largo);
			  metros = intancho*intlargo;
			  resultadoaserrin = metros*20;
			resultadotrabajadores=metros*10;
			lbltrabajadores.Text=resultadotrabajadores.ToString();
			Calcular inn = new Calcular(clickpintura, clickflores, clickfruta, metros, resultadoaserrin, resultadotrabajadores);
			this.Hide();
			inn.ShowDialog();
			this.Close();				
						
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			intro inn = new intro();
			this.Hide();
			inn.ShowDialog();
			this.Close();	
		}
		
		void BtnpinturaClick(object sender, EventArgs e)
		{
			clickpintura= int.Parse( lblpintura.Text );
			clickpintura++;
			lblpintura.Text=clickpintura.ToString();
						
		}
		
		void BtnfloresClick(object sender, EventArgs e)
		{
			
			clickflores= int.Parse( lblflores.Text );
			clickflores++;
			lblflores.Text=clickflores.ToString();			
		}
		
		void BtnfrutaClick(object sender, EventArgs e)
		{
			clickfruta=int.Parse(lblfruta.Text);
			clickfruta++;
			lblfruta.Text=clickfruta.ToString();
		}
		
		void BtntrabajaClick(object sender, EventArgs e)
		{
			clicktrabaj=int.Parse(lbltrabajadores.Text);
			clicktrabaj++;
			lbltrabajadores.Text=clicktrabaj.ToString();
		
			
			
			
			
			
			
		}
	}
}
