using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class City
	{
		public string name;
		public string center_gu;
		public int maxGu;

		public string[] gus;

		public void CallCity()
		{
			Console.WriteLine("이 광역시 이름은 : " + name + "광역시");
			Console.WriteLine(name + "광역시의 시청 위치는 " + center_gu);
			Console.WriteLine(name + "광역시가 가지고 있는 지구의 수는 " + maxGu + "구");
		}

		public void PrintAllGu()
		{
			Console.WriteLine("모든 " + name + "광역시의 지구들..");

			for (int i = 0; i < gus.Length; i++)
			{
				Console.WriteLine(gus[i] + "구");
			}
		}

		public void FindGu(string gu_name)
		{
			bool count = false;

			for(int i =0; i < gus.Length; i++)
            {
				if (gu_name == gus[i])
                {
					count = true;
                }
			}

			if(count == true)
            {
				Console.WriteLine(name + "광역시의 구입니다.");
			}
			else
			{
				Console.WriteLine(name + "광역시의 구가 아닙니다..");
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			City incheon = new City();
			City daegu = new City();


			incheon.name = "인천";
			incheon.center_gu = "남동구";
			incheon.maxGu = 8;

			incheon.gus = new String[]
			{
				"중","동","미추홀","연수","남동","부평","계양","서"
			};


			incheon.CallCity();
			incheon.PrintAllGu();
			incheon.FindGu("미추홀");

			daegu.name = "대구";
			daegu.center_gu = "중구";
			daegu.maxGu = 7;

			daegu.gus = new String[]
			{
			"중","동","서","남","북","수성","달서"
			};


			daegu.CallCity();
			daegu.PrintAllGu();
			daegu.FindGu("달서");
		}
	}
}
