using System;
namespace _6praka
{
	public class ClassInOut
	{
		public ClassInOut()
		{
            Program clas = new Program();


            if (clas.window == 0)
            {
                Console.WriteLine("Введите изначалбный путь:");
                string input = Console.ReadLine();
                clas.Reading(input);
            }
            if (clas.window == 1)
            {
                Console.Clear();
                Console.WriteLine("Введите путь куда хотите записать файл:");
                string output = Console.ReadLine();
                clas.Saving(output);
            }
        }
	}
}

