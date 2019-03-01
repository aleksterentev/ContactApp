using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
	public class Project
	{
		/// <summary>
		/// Список контактов
		/// </summary>
		public List<Contact> _contactslistone = new List<Contact>();
		public List<Contact> Sort(List<Contact> _contactslistone)
		{
			_contactslistone.Sort(delegate (Contact x, Contact y)
			{
				return x.Sername.CompareTo(y.Sername);
			});
			return _contactslistone;
		}
		public static Project Birthday(Project data, DateTime today)
		{
			Project returnProject = new Project();
			for (int i = 0; i < data._contactslistone.Count; i++)
			{
				if ((data._contactslistone[i].Birth.Day == today.Day) && (data._contactslistone[i].Birth.Month == today.Month))
				{
					returnProject._contactslistone.Add(data._contactslistone[i]);
				}
			}
			return returnProject;
		}
	}
}
