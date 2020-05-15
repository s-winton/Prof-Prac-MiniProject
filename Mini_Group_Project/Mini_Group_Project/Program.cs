﻿
using System;
using System.Threading;



namespace Mini_Group_Project
{
    public static class Globals
    {
        public static int dexterity = 4;
        public static int strength = 4;
        public static int hitpoints = 20;
        public static int intelligence = 4;
    }
    class Program
    {

        public static void magic()
        {
            Random rand = new Random();
            int damage;
            int ogrehealth = 30;

            Console.WriteLine("You prepare to cast a fireball attack");
            Console.ReadLine();

            if (Globals.intelligence >= 5)
            {
                damage = rand.Next(4, 6);
                Console.WriteLine("You hurl a fireball at him dealing " + damage + " damage\n");
                ogrehealth = ogrehealth - damage;
                Console.ReadLine();

                Console.WriteLine("The ogre flails around and ends up kicking you across the room\n");
                damage = rand.Next(1, 4);
                Console.WriteLine("That really hurt you take " + damage + " damage\n");
                Globals.hitpoints = Globals.hitpoints - damage;
            }
            else
            {
                damage = rand.Next(0, 3);
                Console.WriteLine("You hurl a fireball at him dealing " + damage + " damage\n");
                ogrehealth = ogrehealth - damage;
                Console.ReadLine();

                Console.WriteLine("The ogre laughs at such a pathetic attack and responds by kicking you\n");
                damage = rand.Next(3, 5);
                Console.WriteLine("That really hurt you take " + damage + " damage\n");
                Globals.hitpoints = Globals.hitpoints - damage;
            }
        }
        
        
        
        
        
        public static void dodge()
        {
            Random rand = new Random();
            int damage;
            
            Console.WriteLine("You prepare yourself for the ogres attack\n");
            Console.ReadLine();

            if (Globals.dexterity >= 3)
            {
                Console.WriteLine("you manage to dodge the ogres haymaker\n");
                Console.ReadLine();
            }
            else
            {
                damage = rand.Next(0, 2);
                Console.WriteLine("you attempt to dodge but still get hit and take " + damage + " damage\n");
                Globals.hitpoints = Globals.hitpoints - damage;
            }
        }
        
        
        
        
        
        
        public static void stab()
        {
            Random rand = new Random();
            int damage;
            int ogrehealth = 30;

            Console.WriteLine("you take a stab at the ogre");
            Console.ReadLine();

            if (Globals.strength >= 5)
            {

                damage = rand.Next(4, 7);
                Console.WriteLine("You deal " + damage + " damage to the ogre\n");
                ogrehealth = ogrehealth - damage;
                Console.ReadLine();

                Console.WriteLine("Just as you manage to pull your weapon out of the orge he punches you right in the face\n");
                damage = rand.Next(1, 4);
                Console.WriteLine("You took " + damage + " damage\n");
                Globals.hitpoints = Globals.hitpoints - damage;
            }
            else
            {
                damage = rand.Next(1, 5);
                Console.WriteLine("You deal " + damage + "damage to the ogre\n");
                ogrehealth = ogrehealth - damage;
                Console.ReadLine();

                Console.WriteLine("Just as you manage to pull your weapon out of the orge he punches you right in the face\n");
                damage = rand.Next(1, 4);
                Console.WriteLine("You took " + damage + " damage\n");
                Globals.hitpoints = Globals.hitpoints - damage;
            }


        }
        
                                       
        public static void fight()
        {
            int loot;            
            string temp;
            int choice;
            int ogrehealth = 30;
            Random rand = new Random();

            Console.WriteLine("The big fat ogre laughs as you go to challenge him");
            do
            {
                Console.WriteLine("You have " + Globals.hitpoints + " left");
                Console.WriteLine("what will you do?");
                Console.WriteLine("1. stab him");
                Console.WriteLine("2. use fireball");
                Console.WriteLine("3. dodge");
                Console.WriteLine("4. check health");
                temp = Console.ReadLine();
                choice = Convert.ToInt32(temp);

                switch (choice)
                {
                    case 1:
                        stab();
                        break;

                    case 2:
                        magic();
                        break;

                    case 3:
                        dodge();
                        break;
                }
                                                   
            } while ((ogrehealth !>= 0) || (Globals.hitpoints !>= 0));

            if (ogrehealth >= 0)
            {
                Console.WriteLine("The ogre falls with a great thud");
                Console.WriteLine("You loot the orge and see that there is a club, and a wizards hat.");
                Console.WriteLine("what will you take\n");
                Console.WriteLine("1. The Club");
                Console.WriteLine("2. The Wizards Hat");
                temp = Console.ReadLine();
                loot = Convert.ToInt32(temp);

                if (loot == 1)
                {
                    Console.WriteLine("You take the club, its a nice club");
                    Console.ReadLine();
                    Globals.strength = Globals.strength + 2;
                }
                else
                {
                    Console.WriteLine("You take the wizards hat, when you put it on you feel smarter");
                    Console.ReadLine();
                    Globals.intelligence = Globals.intelligence + 3;
                }
            }
            else
            {
                Death();                                          
            }


        }

        
        
        
        
        
        
        
        
        
        
        public static void flee()
        {




























        }
        public static void stair2()
        {


























        }
        public static void wall()
        {
            string temp;
            Console.WriteLine("You notice a wall shimmering slightly with strange magic");
            Console.WriteLine("Will you inspect it?");
            temp = Console.ReadLine();
            if (temp == yes) ;
            {
                Console.WriteLine("The wall appears to be an illusion");
                Console.WriteLine("As you proceed through the illusion. It disperses, leaving you standing in an open doorway leading to a room with a solitary staff standing in the centre");
                Console.WriteLine("Would you like to ");
            }
            else
            {
                Console.WriteLine("You carry on with your adventure");
            }



















        //298
        }
        public static void encounter1()
        {
            string temp;
            int choice;
            Console.WriteLine("You gahter your thoughts as ahead of you at the bottom of the stairs is a dimly lit corridir. Right in front of you you can barely make out a large shadow...");
            Console.WriteLine("Do you wish to investigate what this mysterious figure could be?");
            Console.WriteLine("1. Yes, I'm not afriad of anything!");
            Console.WriteLine("2. Hell no! I'd rahter go back up those stairs and find another way through this!");
            temp = Console.ReadLine();
            choice = Convert.ToInt32(temp);

            if (choice == 1)
            {
                Console.WriteLine("You approach the large figure....");
                Thread.Sleep(1000);
                Console.WriteLine("Gettting closer....");
                Thread.Sleep(1000);
                Console.WriteLine("The figure roars and charges at you!");
                Console.WriteLine("Its an Ogre!");
                Thread.Sleep(1000);

                Console.WriteLine("Do you wish to fight or flee?");
                Console.WriteLine("1. I'm getting out of here! (run back up the stairs)");
                Console.WriteLine("2. I'm too young to die! (make a break for it and run past the ogre)");
                Console.WriteLine("3. I can take him! (stand your ground and fight!)");
                temp = Console.ReadLine();
                choice = Convert.ToInt32(temp);

                switch (choice)
                {
                    case 1:
                        stair2();
                        break;
                    case 2:
                        flee();
                        break;
                    case 3:
                        fight();
                        break;
                }
            }
            else
            {
                stair2();
            }
        }

        public static void Stair1()
        {
            Random rand = new Random();
            string temp;
            int stairs;
            int slip;
            int damage;

            Console.WriteLine("After you cross the pit, you look ahead to see a stoney, narrow spiral staircase going down. It looks like its wet and covered in slippery mold.");
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
                    Thread.Sleep(2000);
                    slip = rand.Next(1, 5);

                    if (slip == 1)
                    {
                        i = i + 5;
                        Console.WriteLine("As you lift your left leg up to take another step, your right foot loses its footing!");
                        Thread.Sleep(2000);
                        Console.WriteLine("You tumble down the stairs!");
                        Thread.Sleep(500);
                        Console.WriteLine("Ouch!");
                        Thread.Sleep(800);
                        Console.WriteLine("Ow!");
                        Thread.Sleep(1000);
                        Console.WriteLine("Agh!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        damage = rand.Next(2, 8);
                        Globals.hitpoints = Globals.hitpoints - damage;

                        Console.WriteLine("You are bruised and broken after that brutal fall.");
                        Console.WriteLine("You took " + damage + " hitpoints of damage! You now have " + Globals.hitpoints + " hitpoints remaining!");
                        Console.ReadLine();
                        Console.Clear();
                        encounter1();
                    }
                    if (i >5 && slip !=1)
                    {
                        Console.Clear();
                        Console.WriteLine("You Safely decended the stairs");
                        Console.ReadLine();
                        Console.Clear();
                        encounter1();
                    }
                }
            }
            else
            {
                Console.WriteLine("You decide thats its not worth the hassle and look for another way...");
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

                if (Globals.strength <= 5)
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

                if (Globals.intelligence >= 3)
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
            Globals.strength = Globals.strength + 2;
            Globals.dexterity = Globals.dexterity - 2;
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
