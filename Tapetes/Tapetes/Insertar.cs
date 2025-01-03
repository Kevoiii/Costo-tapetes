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
		public int metrostra;
		public int clicktorta;
		public int cantidad;
		public int botellass;
		public int botanap;
		public int botanag;
		
		
		
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
			  metrostra = intancho*intlargo*10; 
			  cantidad=metros*20;
			  resultadoaserrin = cantidad*20;
			  resultadotrabajadores= int.Parse(lbltrabajadores.Text);
			  resultadotrabajadores=resultadotrabajadores*metrostra; 
			
			
			
			Calcular inn = new Calcular(clickpintura, clickflores, clickfruta, metros, resultadoaserrin, resultadotrabajadores, metrostra,clicktorta, cantidad, botellass, botanap, botanag);
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
		
		void BtntortasClick(object sender, EventArgs e)
		{
			clicktorta=int.Parse(lbltortas.Text);
			clicktorta++;
			lbltortas.Text=clicktorta.ToString();
		}
		void BtnbotellaClick(object sender, EventArgs e)
		{
			botellass=int.Parse(lblbotellas.Text);
			botellass++;
			lblbotellas.Text=botellass.ToString();
		}
		void BtnbpClick(object sender, EventArgs e)
		{
			botanap=int.Parse(lblbotanap.Text);
			botanap++;
			lblbotanap.Text=botanap.ToString();
		}
		void BtnbgClick(object sender, EventArgs e)
		{
			botanag=int.Parse(lblbotanag.Text);
			botanag++;
			lblbotanag.Text=botanag.ToString();
		}
	}
}
