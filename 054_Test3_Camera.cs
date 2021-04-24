using System;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            float filmBackWidth = float.Parse(Console.ReadLine());
            while (filmBackWidth <= 0)
            {
                Console.WriteLine("Invalid filmBackWidth. Please input again.");
                filmBackWidth = float.Parse(Console.ReadLine());
            }
            float fLength, fov;
            if (mode == "fLength")
            {
                fLength = float.Parse(Console.ReadLine());
                while (fLength <= 0)
                {
                    Console.WriteLine("Invalid fLength. Please input again.");
                    fLength = float.Parse(Console.ReadLine());
                }
                fov = (float)(2 * (Math.Atan(filmBackWidth / (2 * fLength))));
                Console.WriteLine("fLength = {0}, fov = {1}", fLength, fov);
            }
            else if (mode == "fov")
            {
                fov = float.Parse(Console.ReadLine());
                while (fov < 0.1 || fov > 6.28)
                {
                    Console.WriteLine("Invalid fov. Please input again.");
                    fov = float.Parse(Console.ReadLine());
                }
                fLength = (float)(filmBackWidth / (2 * (Math.Tan(fov / 2))));
                Console.WriteLine("fLength = {0}, fov = {1}", fLength, fov);
            }
        }
    }
}
