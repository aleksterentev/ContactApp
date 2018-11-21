using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class NumberPhone
    {
		/// <summary>
		/// номер телефона содержит 11 цифр и начинается с 7
		/// </summary>
		public int Number
		{
			get { return _number; }

			set
			{

				int count = (value == 0) ? 1 : 0;
				while (value != 0)
				{
					count++;
					value /= 10;
				}

				if (count != 11)
				{
					throw new ArgumentException(@"Must be exactly 11 numbers");
				}

				int firstDigit = (int)(value / Math.Pow(10, (int)Math.Log10(value)));

				if (firstDigit != +7)
				{
					throw new ArgumentException(@"Number should start from +7");
				}

				_number = value;

			}

		}
		private int _number;
	}
}
