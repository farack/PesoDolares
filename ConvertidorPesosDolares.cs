/*
 * Created by SharpDevelop.
 * User: jmanu_000
 * Date: 24/10/2013
 * Time: 07:58 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace convertir
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
	
			
			
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(PesosTxB.Text=="0"||TipoCambioTxB.Text=="0"){
				MessageBox.Show("Error ");
			}
			
			double Dolar;
			
			double Mpeso;
			if(!double.TryParse(	PesosTxB.Text, out Mpeso)){
			   			 MessageBox.Show("Error ");
			return;  			  
			}
			
				
			double TCambio;
			if(!double.TryParse(	TipoCambioTxB.Text, out TCambio )){
			   			 MessageBox.Show("Error");
			return;   
			}
			
		
		
			Dolar=Mpeso/TCambio;
			DolarsTxB.Text=Dolar.ToString();

  
			
		}
		
		void DoClick(object sender, EventArgs e)
		{
			
		}
	}
}
