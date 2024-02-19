using System.Drawing;

namespace ListCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter List of colors> Done for end: ");
            List<string> colorList = new List<string>();
            string input = Console.ReadLine();
            while (input != "Done") 
            { 
                colorList.Add(input);
                input = Console.ReadLine();
            }
            Console.WriteLine("Koj Element da iztriesh 0-" +
                (colorList.Count -1) + " ? ");
            int index = int.Parse(Console.ReadLine());
            colorList.RemoveAt(index);


            colorList[0] = "Pink";

            //for(int i = 0; i < colorList.Count; i++)
            //{
            //    Console.WriteLine(colorList[i]);
            //}

            foreach (string redBox in colorList)
            {
                Console.WriteLine(redBox);
            }
        }
    }
}
