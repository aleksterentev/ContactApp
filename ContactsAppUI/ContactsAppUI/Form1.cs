using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
	public partial class Form1 : Form
	{
		private List<Contacts> _contacts = new List<Contacts>();

		public Form1()
		{
			InitializeComponent();
			var project = new Project();
			this.Text = "Главное окно программы";
			this.Size = new Size(600, 450);
		}

		private void СontactsAppDesing_Load(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	}
}
