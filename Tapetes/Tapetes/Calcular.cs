/*
 * Created by SharpDevelop.
 * User: CC2_PC36
 * Date: 20/11/2024
 * Time: 07:26 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tapetes
{
	/// <summary>
	/// Description of Calcular.
	/// </summary>
	public partial class Calcular : Form
	{
		int click;
		int clickflo;
		int clickfrut;
		int met;
		int resuase;
		int resultrabaja;
		public Calcular(int clickk, int clickf, int clickff, int meti, int resua, int restr)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			click=clickk;
			clickflo=clickf;
			clickfrut=clickff;
			met=meti;
			resuase=resua;
			resultrabaja=restr;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void Button5Click(object sender, EventArgs e)
		{
			click=click*40;
			lblpintura.Text=click.ToString();
			clickflo=clickflo*10;
			lblflor.Text=clickflo.ToString(); 
			clickfrut=clickfrut*150;
			lblfruta.Text=clickfrut.ToString();
			lblaserrin.Text=met.ToString();
			lblcostoaserrin.Text=resuase.ToString();
			lbltrabajadores.Text=resultrabaja.ToString();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
				Insertar inn = new Insertar();
			this.Hide();
			inn.ShowDialog();
			this.Close();		
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			comprado inn = new comprado();
			this.Hide();
			inn.ShowDialog();
			this.Close();
		}
	}
}
