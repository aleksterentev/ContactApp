using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApp
{
	/// <summary>
	/// Класс контактов
	/// </summary>
	[JsonObject(MemberSerialization.OptIn)]
	public class Contact : System.ICloneable
	{
		/// <summary>
		/// 
		/// </summary>
		private string _name;

		private string _sername;

		private NumberPhone _phone;

		private DateTime _birth;

		private string _eMail;

		private string _idVk;


		/// <summary>
		/// Имя
		/// </summary>
		[JsonProperty]
		public string Name
		{
			get { return _name; }
			set
			{
				if ((value.Length) > 50)
				{
					throw new ArgumentException("Длинна имени не должна превышать 50 символов.");
				}
				int i = 0;

				while (i < value.Length)
				{
					if ((value[i] < 'A') || (value[i] > 'z') || (value[i] > 'Z' && value[i] < 'a'))
					{
						throw new ArgumentException("Имя должно содержать только буквы.");
					}
					i++;
				}
				i = 0;
				if (value[i] >= 'a' && value[i] <= 'z')
				{
					throw new ArgumentException("Имя должно начинаться с заглавной буквы.");
				}
				_name = value;
			}

		}

		/// <summary>
		/// Фамилия
		/// </summary>
		[JsonProperty]
		public string Sername
		{
			get { return _sername; }
			set
			{
				if ((value.Length) > 50)
				{
					throw new ArgumentException("Длинна фамилии не должна превышать 50 символов.");
				}
				int i = 0;

				while (i < value.Length)
				{
					if ((value[i] < 'A') || (value[i] > 'z') || (value[i] > 'Z' && value[i] < 'a'))
					{
						throw new ArgumentException("Фамилия должна содержать только буквы.");
					}
					i++;
				}
				i = 0;
				if (value[i] >= 'a' && value[i] <= 'z')
				{
					throw new ArgumentException("Фамилия должна начинаться с заглавной буквы.");
				}
				_sername = value;
			}
		}

		/// <summary>
		/// Телефон
		/// </summary>
		[JsonProperty]
		public NumberPhone Phone
		{
			get
			{
				return _phone;
			}

			set
			{
				_phone = value;
			}

		}

		public readonly DateTime dateMin = new DateTime(1900, 01, 01);
		/// <summary>
		/// Дата рождения
		/// </summary>
		[JsonProperty]
		public DateTime Birth
		{
			get { return _birth; }
			set
			{
				if (value > DateTime.Now && value < dateMin)
				{
					throw new ArgumentException("Дата рождения должна быть меньше текущей даты и более чем 1900 год");
				}
				else _birth = value;
			}

		}
		/// <summary>
		/// Почта
		/// </summary>
		 [JsonProperty]
		public string Email
		{
			get
			{
				return _eMail;
			}

			set
			{

				if (value.Length > 50)
				{
					throw new ArgumentException(@"String is too long");
				}
				_eMail = value;
			}
		}
		/// <summary>
		/// ссылка ВКонтакте
		/// </summary>
		[JsonProperty]
		public string IdVk
		{
			get
			{
				return _idVk;
			}

			set
			{
				if (value.Length > 15)
				{
					throw new ArgumentException(@"String is too long");
				}

				_idVk = value;
			}
		}


		/// <summary>
		/// Клонирование
		/// </summary>
		/// <returns></returns>
		public object Clone()
		{
			return new Contact
			{
				Name = this.Name,
				Sername = this.Sername,
				Phone = this.Phone,
				Birth = this.Birth,
				Email = this.Email,
				IdVk = this.IdVk
			};
		}


	}
}
