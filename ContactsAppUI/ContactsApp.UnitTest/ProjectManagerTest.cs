using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace ContactsApp.UnitTests
{
	[TestFixture]
	class ProjectManagerTest
	{
		private Contact _contact;
		private Project _project;
		[SetUp]
		public void InitProject()
		{
			_contact = new Contact();
			_contact.Sername = "Ivanon";
			_contact.Name = "Ivan";
			_contact.Phone.Number = 79832398876;
			_contact.Birth = new DateTime(1990, 02, 12);
			_contact.Email = "trh@mail.ru";
			_contact.IdVk = "23554578";
			_project = new Project();
		}
		[Test(Description = "Позитивный тест сериализации")]
		public void Test_Save_To_File_Correct_Value()
		{
			_project._contactslistone.Add(_contact);
			ProjectManager.SaveToFile(_project, Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
				 + "/source/repos/ContactsApp2/ContactsAppUI/ContactsApp.UnitTest/ContactsAppTest1.txt");

			string reference = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
			+ "/source/repos/ContactsApp2/ContactsAppUI/ContactsApp.UnitTest/ContactsAppTest2.txt");
			string actual = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
			  + "/source/repos/ContactsApp2/ContactsAppUI/ContactsApp.UnitTest/ContactsAppTest1.txt");

			Assert.AreEqual(reference, actual, "Тест пройден, если исключений не возникло");
		}
		[Test(Description = "Позитивный тест десериализации")]
		public void Test_Load_From_File_Correct_Value()
		{
			_project._contactslistone.Add(_contact);
			Project actualProject = new Project();

			actualProject = ProjectManager.LoadFromFile(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
			"/source/repos/ContactsApp2/ContactsAppUI/ContactsApp.UnitTest/ContactsAppTest2.txt");

			Assert.AreEqual(_project._contactslistone.Count, actualProject._contactslistone.Count, "Загрузка работает некоректно1");
			for (int i = 0; i != _project._contactslistone.Count; i++)
			{
				Assert.AreEqual(_project._contactslistone[i].Sername, actualProject._contactslistone[i].Sername,
						"Загрузка работает некоректно2");
				Assert.AreEqual(_project._contactslistone[i].Name, actualProject._contactslistone[i].Name,
						"Загрузка работает некоректно3");
				Assert.AreEqual(_project._contactslistone[i].Phone.Number, actualProject._contactslistone[i].Phone.Number,
						"Загрузка работает некоректно4");
				Assert.AreEqual(_project._contactslistone[i].IdVk, actualProject._contactslistone[i].IdVk,
						"Загрузка работает некоректно5");
				Assert.AreEqual(_project._contactslistone[i].Birth, actualProject._contactslistone[i].Birth,
						"Загрузка работает некоректно6");
				Assert.AreEqual(_project._contactslistone[i].Email, actualProject._contactslistone[i].Email,
						 "Загрузка работает некоректно7");
			}
		}
	}
}