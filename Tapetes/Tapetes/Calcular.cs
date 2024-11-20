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
		public Calcular()
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
			comprado inn = new comprado();
			this.Hide();
			inn.ShowDialog();
			this.Close();				
		}
	}
}
