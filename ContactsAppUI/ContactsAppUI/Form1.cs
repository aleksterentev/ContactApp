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

			public Form1()
			{
				InitializeComponent();
				BirthTimePicker1.MaxDate = DateTime.Now;
			}
			private void Form1_Load(object sender, EventArgs e)
			{

			}
			public List<Contact> _contactslistone = new List<Contact>();

			//private void label6_Click(object sender, EventArgs e)
			//        {
			//
			//        }

			private void button1_Click(object sender, EventArgs e)
			{
				var form2 = new AddContact();
				form2.Owner = this;
				form2.ShowDialog();
				var UpdatedDate = form2.Data;
				if (UpdatedDate != null)
				{
					_contactslistone.Add(UpdatedDate._contactsplus);
					listBox1.Items.Add(UpdatedDate.TxtBox);
				}

			}
			private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
			{
				if (listBox1.SelectedIndex >= 0)
				{
					Contact _contactsplus;
					_contactsplus = _contactslistone[listBox1.SelectedIndex];
					NameTextBox2.Text = _contactsplus.Name;
					SernameTextBox1.Text = _contactsplus.Sername;
					EmailTextBox4.Text = _contactsplus.Email;
					VkTextBox5.Text = _contactsplus.IdVk;
					BirthTimePicker1.Value = _contactsplus.Birth;
					PhoneTextBox3.Text = Convert.ToString(_contactsplus.Phone.Number);
				}
			}

			private void button5_Click(object sender, EventArgs e)
			{
				AddContact form2 = new Form();
				if (listBox1.SelectedIndex >= 0)
				{
					form2.Data._contactsplus = _contactslistone[listBox1.SelectedIndex];
					form2.Data.TxtBox = _contactslistone[listBox1.SelectedIndex].Sername;
					form2.ShowDialog();
					var UpdatedDate = form2.Data;
					_contactslistone.RemoveAt(listBox1.SelectedIndex);
					listBox1.Items.RemoveAt(listBox1.SelectedIndex);
					_contactslistone.Add(UpdatedDate._contactsplus);
					listBox1.Items.Add(UpdatedDate.TxtBox);
					NameTextBox2.Text = UpdatedDate._contactsplus.Name;
					SernameTextBox1.Text = UpdatedDate._contactsplus.Sername;
					EmailTextBox4.Text = UpdatedDate._contactsplus.Email;
					VkTextBox5.Text = UpdatedDate._contactsplus.IdVk;
					BirthTimePicker1.Value = UpdatedDate._contactsplus.Birth;
					PhoneTextBox3.Text = Convert.ToString(UpdatedDate._contactsplus.Phone.Number);
				}
			}


			private void button3_Click(object sender, EventArgs e)
			{
				DialogResult result = MessageBox.Show("Do you really want to delete the contact?\n" + _contactslistone[listBox1.SelectedIndex].Sername + " " + _contactslistone[listBox1.SelectedIndex].Name, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
				if (result == DialogResult.OK)
				{
					_contactslistone.RemoveAt(listBox1.SelectedIndex);
					listBox1.Items.RemoveAt(listBox1.SelectedIndex);
					NameTextBox2.Clear();
					SernameTextBox1.Clear();
					EmailTextBox4.Clear();
					PhoneTextBox3.Clear();
					VkTextBox5.Clear();
					BirthTimePicker1.Value = BirthTimePicker1.MaxDate;
				}
			}

			private void textBox2_TextChanged(object sender, EventArgs e)
			{

			}

			private void textBox5_TextChanged(object sender, EventArgs e)
			{

			}
		}
}
