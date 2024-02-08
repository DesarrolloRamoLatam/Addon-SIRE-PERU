using BLL;
using System;
using System.Windows.Forms;
using DTO.Sire;
using System.Collections.Generic;

namespace UI
{
	

	public partial class FrmSireVentas : Form
	{
		private SireBLL sireBLL;
		public FrmSireVentas()
		{
			InitializeComponent();
			cboAño.SelectedItem = "2023";
			cboPeriodo.SelectedItem = "Febrero";
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{

		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void FrmSireVentas_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

			if (rbSire.Checked)
			{
				sireBLL = new SireBLL();

				List<Registros> resultComprobantesVentas = sireBLL.GetRegistrosSireVenta();
				
			}

		}
	}
}
