﻿/*
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
	/// Description of intro.
	/// </summary>
	public partial class intro : Form
	{
		public intro()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Insertar inn = new Insertar();
			this.Hide();
			inn.ShowDialog();
			this.Close();			
		}
		
		
	}
}
