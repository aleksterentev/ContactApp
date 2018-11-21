using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
	public class Contacts : ICloneable
	{
		/// <summary>
		/// Имя
		/// </summary>
		public string Name
		{
			get
			{
				return FirstLetterToUpper(_name);
			}

			set
			{
				if (value.Length > 50)
				{
					throw new ArgumentException(@"String is too long");
				}
			}
		}

		/// <summary>
		/// Фамилия
		/// </summary>
		public string Sername
		{
			get
			{
				return FirstLetterToUpper(_sername);
			}

			set
			{
				if (value.Length > 50)
				{
					throw new ArgumentException(@"String is too long");
				}
			}
		}

		/// <summary>
		/// Телефон
		/// </summary>
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

		/// <summary>
		/// Дата рождения
		/// </summary>
		public string Birth
		{
			get { return _birth; }

			set
			{
				if (value.Length > 10)
				{
					throw new ArgumentException(@"String is too long");
				}

				string year;
				year = "";

				for (int i = 0; i < value.Length; i++)
				{

					if (value[i] == '.')
					{
						break;
					}

					year = year + value[i];

				}


				if (Convert.ToInt32(year) < 1900)
				{
					throw new ArgumentException(@"Date must be more than 1900");
				}

				_birth = value;

			}

		}
		/// <summary>
		/// Почта
		/// </summary>
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
		/// Перевод первой буквы в верхний регистр
		/// </summary>
		/// <param name="str">Строка которую надо перевести</param>
		/// <returns>Строка с переведенным регистром</returns>
		public static string FirstLetterToUpper(string str)
		{
			if (str.Length > 0) { return Char.ToUpper(str[0]) + str.Substring(1); }
			return "";
		}
		/// <summary>
		/// Клонирование
		/// </summary>
		/// <returns></returns>
		public object Clone()
		{
			return new Contacts
			{
				Name = this.Name,
				Sername = this.Sername,
				Phone = this.Phone,
				Birth = this.Birth,
				Email = this.Email,
				IdVk = this.IdVk
			};
		}

		private string _name;
		private string _sername;
		private NumberPhone _phone;
		private string _birth;
		private string _eMail;
		private string _idVk;
	}
}
