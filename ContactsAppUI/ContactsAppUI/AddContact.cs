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
	public partial class AddContact : Form
	{
		private Contact _contactsplus = new Contact();
		private NumberPhone _phone = new NumberPhone();

		public AddContact()
		{
			InitializeComponent();
			BirthTimePicker1.MaxDate = DateTime.Now;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_phone.Number = System.Int64.Parse(PhoneTextBox4.Text);
			_contactsplus.Sername = SernameTextBox1.Text;
			_contactsplus.Name = NameTextBox2.Text;
			_contactsplus.Birth = BirthTimePicker1.Value;
			_contactsplus.Phone = _phone;
			_contactsplus.Email = EmailTextBox5.Text;
			_contactsplus.IdVk = VkTextBox6.Text;
			_data.TxtBox = _contactsplus.Sername;
			_data._contactsplus = _contactsplus;
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form1 main = this.Owner as Form1;
			var form1 = new Form1();
			if (main != null)
			{
				Data = null;
			}
			this.Close();
		}

		private void AddContact_Load(object sender, EventArgs e)
		{
			if (Data._contactsplus != null)
			{
				SernameTextBox1.Text = Data._contactsplus.Sername;
				NameTextBox2.Text = Data._contactsplus.Name;
				EmailTextBox5.Text = Data._contactsplus.Email;
				VkTextBox6.Text = Data._contactsplus.IdVk;
				BirthTimePicker1.Value = Data._contactsplus.Birth;
				PhoneTextBox4.Text = Convert.ToString(Data._contactsplus.Phone.Number);
			}

		}
		public class DataInMainForm
		{
			public string TxtBox;
			public Contact _contactsplus;
		}
		private DataInMainForm _data = new DataInMainForm();
		public DataInMainForm Data
		{
			get
			{
				return _data;
			}
			set
			{
				_data = value;
			}
		}
	}
}
