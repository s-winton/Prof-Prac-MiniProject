
using System;
// William edit test

namespace Mini_Group_Project
{
    class Program
    {

        private static int strength = 0;
        private static int hitpoints = 20;
        private static int intelligence = 0;


        public static void Door1()
        {
            Console.WriteLine("");
            Console.ReadLine();
        }

        public static void Door2()
        {
            Console.WriteLine("");
            Console.ReadLine();
        }

        public static void Door3()
        {
            Console.WriteLine("");
            Console.ReadLine();
        }



        static void Main(string[] args)
        {
            Random rand = new Random();
            string temp;
            int Starterdoor;
            
            Console.WriteLine("You wake up dazed and confused lying on a hard floor, you stand up and all you have on you is a broken dagger and some ragged clothing.");
            Console.WriteLine("As you look around the room confused you notice three doors none of them have locks and should be able to just open, what door do you go through?: ");
            Console.WriteLine("Door 1?");
            Console.WriteLine("Door 2?");
            Console.WriteLine("Door 3?");
            temp = Console.ReadLine();
            Starterdoor = Convert.ToInt32(temp);

            switch (Starterdoor)
            {
                case 1:
                    Door1();
                    break;

                case 2:
                    Door2();
                    break;

                case 3:
                    Door3();
                    break;
            }
        }
    }
}
