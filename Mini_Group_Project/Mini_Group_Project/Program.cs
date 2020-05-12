
using System;
using System.Threading;

// William edit test

namespace Mini_Group_Project
{
    class Program
    {
       
        private static int strength = 4;
        private static int hitpoints = 20;
        private static int intelligence = 4;

        public static void Stair1()
        {
            Random rand = new Random();
            string temp;
            int stairs;
            int slip;

            Console.WriteLine("After you cross the pit, you look ahead to see a stoney, narrow spiral staircase going down. It looks like its wet and covered in slipery mould.");
            Console.WriteLine("Will you try to walk down the staircase or follow a different route?");
            Console.WriteLine("1. It's only a staircase, whats the danger?");
            Console.WriteLine("2. No way! It looks way too dangerous, I might slip!");
            temp = Console.ReadLine();
            stairs = Convert.ToInt32(temp);

            if (stairs == 1)
            {
                Console.WriteLine("You proceeed cautiously down the stairs....");
                Thread.Sleep(500);

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Slowly down the staris you take a step...");
                    Thread.Sleep(500);
                    slip = rand.Next(1, 5);

                    if (slip == 1)
                    {
                        i = i + 5;
                        Console.WriteLine("As you lift your left leg up to take another step, your right foot loses its footing!");
                        Thread.Sleep(2000);
                        Console.WriteLine("You tumble down the stairs!");
                        Thread.Sleep(500);
                        Console.WriteLine("Ouch!");
                        Thread.Sleep(200);
                        Console.WriteLine("Ow!");
                        Thread.Sleep(200);
                        Console.WriteLine("Agh!");
                    }
                }
                Console.Clear();
                Console.WriteLine("You Safely decended the stairs");
            }
            else
            {
                Console.WriteLine("You decide thats its not worht the hassle and look for another way...");
            }

        }
                           
        public static void Door1()
        {
            Random rand = new Random();
            int jump;
            int gap;
            string temp;

            Console.Clear();

            Console.WriteLine("You open the door with the big one on it, as you open the door you start to smell a foul stench.");
            Console.WriteLine("You walk into the room and notice a pit in the middle of the room and the stench is coming from the bottom. The only way across is the pillars that are spread out across the pit");
            Console.WriteLine("will you try to cross or go back?");
            Console.WriteLine("1. cross");
            Console.WriteLine("2. go back");
            temp = Console.ReadLine();
            gap = Convert.ToInt32(temp);

            if (gap == 1)
            {
                Console.WriteLine("You attempted to cross the pit");
                jump = rand.Next(1, 20);

                if (jump > 10)
                {
                    Console.WriteLine("You made it over the pit good job");
                    Console.ReadLine();
                    Stair1();
                }
                else
                {
                    Console.WriteLine("As you were jumping over the pit you tripped on mid air and fell to your death");
                    Console.ReadLine();
                    Death();
                }
            }
            else
            {
                Console.WriteLine("You turn around finding yourself to affraid and go back into the first room");
                Console.ReadLine();
                Main();
            }

        }


        
        
        
        
        
        public static void Door2()
        {
            string temp;
            int choice;

            Console.Clear();

            Console.WriteLine("You open the door with the big two on it");
            Console.WriteLine("You enter the room only to see two doors one made of iron and one that seems to have some sort of magic protecting it");
            Console.WriteLine("what will you do");
            Console.WriteLine("1. try to open the iron door");
            Console.WriteLine("2. try to open the magic door");
            temp = Console.ReadLine();
            choice = Convert.ToInt32(temp);

            if (choice == 1)
            {
                Console.WriteLine("You walk up to the iron door and kick it");

                if (strength <= 5)
                {
                    Console.WriteLine("You just broke your foot good job");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The door flies open with your mighty kick allowing you into the next room");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("you attempt to open the door using what little magic knowledge you have");
                Console.ReadLine();

                if (intelligence >= 3)
                {
                    Console.WriteLine("the door opens turns out idiots can use magic");
                    Console.ReadLine();
                }
            }

        }









        public static void Door3()
        {
            Console.Clear();

            Console.WriteLine("You open the door with the big three on it");
            Console.WriteLine("You walk into the room and only find a pair of metal boots you put them on, for some reason they make you feel stronger");
            strength = strength + 2;
            Console.ReadLine();
            Main();
        }



        public static void Death()
        {
            Console.Clear();

            Console.WriteLine("You have died, press enter to exit the game");
            Console.ReadLine();
        }






        static void Main()
        {
            Random rand = new Random();
            string temp;
            int Starterdoor;

            Console.Clear();

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
