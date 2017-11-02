using System;
using System.Collections.Generic;
using System.Text;

namespace RoomsGame
{
    class GameEnigne
    {
        public Player Player1 { get; set; }
        public Item Item1 { get; set; }
        public Room CurrentRoom { get; set; }
        public Room RoomMiddle { get; set; }
        public Room RoomLeft { get; set; }
        public Room RoomRight { get; set; }

        public GameEnigne()
        {

        }


        public void StartGame()
        {
            Console.WriteLine("The game Has Begun!");
            InstanicateObjects();
            CreateRelationsShips();
            CurrentRoom = RoomMiddle;
            StartGameLoop();
        }

     

        private void InstanicateObjects()
        {
            Player1 = new Player("Daniel", 100);
            Item1 = new Item("Key");
            RoomMiddle = new Room("Middle", "Starting Room");
            RoomLeft = new Room("Left", "Room to the Left");
            RoomRight = new Room("Right", "Room to the Right");
        }

        private void CreateRelationsShips()
        {
            RoomMiddle.LeftNeighbor = RoomLeft;
            RoomMiddle.RightNeighbor = RoomRight;
            RoomLeft.RightNeighbor = RoomMiddle;
            RoomRight.LeftNeighbor = RoomMiddle;
        }

        private void StartGameLoop()
        {
            Console.WriteLine("Welcome to the game!");
            Console.WriteLine("You start in the Room: " + CurrentRoom.Name);
            while (true)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Press R for Right and L for Left");

                string Command = Console.ReadLine();

                if (Command.Equals("R"))
                {
                    // GO Right!
                    if(CurrentRoom.RightNeighbor != null)
                    {
                      CurrentRoom = CurrentRoom.RightNeighbor;
                      PlayerHasEnteredNewRoom();
                    }
                    else
                    {
                        Console.WriteLine("There are no room to the right!");
                    }
                    
                }
                else if (Command.Equals("L"))
                {
                    // GO Left
                    if (CurrentRoom.LeftNeighbor != null)
                    {
                        CurrentRoom = CurrentRoom.LeftNeighbor;
                        PlayerHasEnteredNewRoom();
                    }
                    else
                    {
                        Console.WriteLine("There are no room to the left!");
                    }
                }
                else
                {
                    Console.WriteLine("You have used a wrong Command");
                }

            }
        }

        private void PlayerHasEnteredNewRoom()
        {
            Console.WriteLine("You have Entered a New Room!");
            Console.WriteLine("The Name of the Room is: " + CurrentRoom.Name);
            Console.WriteLine(CurrentRoom.Description);
        }
    }
}
