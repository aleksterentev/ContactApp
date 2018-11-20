using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsAppUI
{
	public partial class СontactsAppDesing : Form
	{
		public СontactsAppDesing()
		{
			InitializeComponent();
			this.Text = "Главное окно программы";
			this.Size = new Size(400, 250);
			
			//Создаем кнопку
			var button = new Button();
			button.Text = "Сменить заголовок окна";
			button.Size = new Size(150, 25);
			button.Location = new Point(150, 150);
			
			//Помещаем кнопку на форму
			this.Controls.Add(button);
		}

		private void СontactsAppDesing_Load(object sender, EventArgs e)
		{

		}
	}
}
