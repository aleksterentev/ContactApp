using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ContactsApp
{
	public class ManagerProject
	{
		/// <summary>
		/// Сериализация
		/// </summary>
		/// <param name="path">Путь</param>
		/// <param name="project">Сериализуемый класс</param>
		public void Serialization(string path, Project project)
		{
			JsonSerializer serializer = new JsonSerializer();
			using (StreamWriter sw = new StreamWriter(path))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				serializer.Serialize(writer, project);
			}
		}

		/// <summary>
		/// Десериализация
		/// </summary>
		/// <param name="path">путь к десериализуемому файлу</param>
		/// <returns>десериалиазуемый класс</returns>
		public Project Deserialization(string path)
		{
			Project project = null;
			JsonSerializer serializer = new JsonSerializer();
			using (StreamReader sr = new StreamReader(path))
			using (JsonReader reader = new JsonTextReader(sr))
			{
				project = (Project)serializer.Deserialize(reader);
			}

			return project;
		}
	}
}
