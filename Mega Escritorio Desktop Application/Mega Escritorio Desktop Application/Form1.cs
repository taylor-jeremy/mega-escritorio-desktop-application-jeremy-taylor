using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mega_Escritorio_Desktop_Application
{
	public partial class Form1 : Form
	{
		decimal drawerPrice;
		decimal surfacePrice;
		decimal deskSize;
		decimal drawer;
		decimal deliveryPrice;
		decimal totalCost;

		public Form1()
		{
			InitializeComponent();
		}

		public void GetPriceQuote()
		{
			const decimal basePrice = 200;

			// make sure width and depth start out at 0
			width.Value = 0;
			depth.Value = 0;

			deskSize = width.Value * depth.Value;

			drawer = System.Convert.ToDecimal(numberDrawers);
			drawerPrice = drawer * 50;

			if (surfaceMaterial.Text == "oak")
			{
				surfacePrice = 200;
			}
			else if (surfaceMaterial.Text == "laminate")
			{
				surfacePrice = 100;
			}
			else
			{
				surfacePrice = 50;
			}

			if (orderDays.Text == "3" && deskSize <= 1000)
			{
				deliveryPrice = 60;
			}
			else if (orderDays.Text == "3" && deskSize >= 1001 && deskSize <= 1999)
			{
				deliveryPrice = 70;
			}
			else if (orderDays.Text == "3" && deskSize >= 2000)
			{
				deliveryPrice = 80;
			}
			else if (orderDays.Text == "5" && deskSize <= 1000)
			{
				deliveryPrice = 40;
			}
			else if (orderDays.Text == "5" && deskSize >= 1001 && deskSize <= 1999)
			{
				deliveryPrice = 50;
			}
			else if (orderDays.Text == "5" && deskSize >= 2000)
			{
				deliveryPrice = 60;
			}
			else if (orderDays.Text == "7" && deskSize <= 1000)
			{
				deliveryPrice = 30;
			}
			else if (orderDays.Text == "7" && deskSize >= 1001 && deskSize <= 1999)
			{
				deliveryPrice = 30;
			}
			else
			{
				deliveryPrice = 40;
			}

			totalCost = basePrice + surfacePrice + deliveryPrice;

			priceQuote.Text = totalCost.ToString("yyyy MMMM dd");
		}

		private void value_Enter(object sender, EventArgs e)
		{
			// Select the answer in the NumericUpDown control.
			NumericUpDown answerBox = sender as NumericUpDown;

			NumericUpDown n;
			try
			{
				if (answerBox != null)
					n = answerBox;
			}

			catch (NullReferenceException)
			{
				MessageBox.Show("You must enter a valid positive two decimal number for the measurement.");
			}
		}

		private void submitButton_Click(object sender, EventArgs e)
		{
			GetPriceQuote();
			submitButton.Enabled = false;
		}
	}


}
