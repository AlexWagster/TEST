using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOL_Practice_3;

namespace OOL_Practice_3
{
    internal class Player
    {
        //SET VARIABLES
        protected string PlayerID;
        public int Position, Money;

        //CONSTRUCTOR METHOD
        public Player(string PlayerID)
        {
            Position = 0;
            Money = 2000;
        }

        //TURN
        public void Turn()
        {
            if (Position == 13)
            {
                Console.WriteLine("Turn lost");
            }
            else
            {
                if (Position == 0)
                {
                    Money += 500;
                }
                Roll();
            }
        }

        //DICE ROLL
        public void Roll()
        {
            {
                Random random = new Random();
                int die1 = random.Next(7);
                Console.WriteLine("Die 1 is " + die1);
                int die2 = random.Next(7);
                Console.WriteLine("Die 2 is " + die2);
                int dietotal = die1 + die2;
                if (die1 == die2)
                {
                    PlayerMovement(dietotal);
                    Console.WriteLine("Double, roll again!");
                    Roll();
                }
                else
                {
                    PlayerMovement(dietotal);
                }
            }
        }
        //MOVEMENT
        public void PlayerMovement(int dietotal)
        {
            Position += dietotal;
            OwnerCheck(MyBoard);
        }

        //CHECK OWNER
        public void OwnerCheck(string MyBoard)
        {
            if (MyBoard.Slot[Position].Owner == null)
            {
                Console.WriteLine("Would you like to buy " + MyBoard.Slot[Position].Name + "?");
                string buyoption = Convert.ToString(Console.ReadLine);
                if (buyoption == "Yes")
                {
                    Money -= MyBoard.Slot[Position].Cost;
                    MyBoard.Slot[Position].Owner = PlayerID;
                }
            }
            else
            {
                Console.WriteLine("Owned by " MyBoard.Slot[Position].Owner);
                Money -= (50 * MyBoard.Slot[Position].Level);
            }
        }

    }
}
