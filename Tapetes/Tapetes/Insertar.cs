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
						
		Calcular inn = new Calcular(clickpintura, clickflores);
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
	}
}
