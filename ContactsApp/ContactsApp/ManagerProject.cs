using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ContactsApp
{
	/// <summary>
	/// Сериализация
	/// </summary>
	public class ProjectManager
	{
		/// <summary>
		/// Сериализация
		/// </summary>
		/// <param name="data">Путь</param>
		/// <param name="project">Сериализуемый класс</param>
		// public static string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "/ContactsApp.notes";
		public static string _path = @"C:\Users\Василиса\MyMusickkk";
		public static void Serialization(Project data, string fpath)
		{
			JsonSerializer serializer = new JsonSerializer();
			using (StreamWriter sw = new StreamWriter(fpath))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				serializer.Serialize(writer, data);
			}
		}

		/// <summary>
		/// Десериализация
		/// </summary>
		/// <param name="path">путь к десериализуемому файлу</param>
		///  /// <param name="project">Объект десириализации</param>
		/// <returns>десериалиазуемый класс</returns>
		public static Project Deserialization(string fpath)
		{
			Project project = null;
			JsonSerializer serializer = new JsonSerializer();
			if (System.IO.File.Exists(_path) == false)
			{
				using (StreamWriter sw = new StreamWriter(fpath)) ;
			}
			using (StreamReader sr = new StreamReader(fpath))
			using (JsonReader reader = new JsonTextReader(sr))
			{
				project = (Project)serializer.Deserialize<Project>(reader);
			}

			return project;
		}

	}
}
