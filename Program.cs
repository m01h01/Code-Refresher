﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Code_Refresher
{
    internal class Program
    {
        static List<Player> players = new List<Player>();
        static string FirstLetter;

        static void Main(string[] args)
        {
            
            Player player1 = new Player("Billy", 12);
            Player player2 = new Player("Victor", 33);
            Player player3 = new Player("Sally", 67);
            Player player4 = new Player("Janell", 45);
            Player player5 = new Player("Hudson", 30);

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Add(player4);
            players.Add(player5);

        Menu:;
            Console.WriteLine($"\nPlayers" +
                $"\n1 - Display PLayers" +
                $"\n2 - Display PLayers with an Odd Number" +
                $"\n3 - Display PLayers starting with a letter" +
                $"\n4 - Add PLayers");
            Console.Write($"Enter your choice: ");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":

                    for (int i = 0; i < players.Count; i++)
                    {
                        Console.WriteLine(players[i]);
                    }
                    Console.WriteLine($"-------------------------------\n\n\n");
                    break;
                case "2":
                    DisplayOddNumber(players);
                    Console.WriteLine($"-------------------------------\n\n\n");
                    break;
                case "3":
                    DisplayFirstLetterOfName(players);
                    Console.WriteLine($"-------------------------------\n\n\n");
                    break;
                case "4":
                    AddPlayer(players);
                    Console.WriteLine($"-------------------------------\n\n\n");
                    break;
                default:
                    Console.WriteLine("Pick the right choice 1 to 4");
                    break;

            } goto Menu;

        }

        public static void DisplayOddNumber(List<Player> players)
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Number % 2 != 0)
                {
                    Console.WriteLine(players[i]);
                }
            }
        }

        public static void DisplayFirstLetterOfName(List<Player> players)
        {
            Console.Write($"Enter the letter: ");
            string enter = Console.ReadLine();
            int i;

            for (i = 0; i < players.Count; i++)
            {
                string playerName = players[i].Name[0].ToString();
                if (enter == playerName || enter == playerName.ToLower())
                {
                    Console.WriteLine(players[i]);

                }
                else
                {
                    playerName = FirstLetter;

                }

            }
            
            if(FirstLetter == enter) 
            { 
                Console.WriteLine($"No Player's Name starts with {enter}"); 
            }  

        }
         
        public static void AddPlayer(List<Player> player)
        {
            Console.Write($"Enter Name: ");
            string name = Console.ReadLine();

            Console.Write($"Enter Number: ");
            string number = Console.ReadLine();
            bool isNumber = int.TryParse(number, out int Num);

            if (isNumber)
            {
                player.Add(new Player(name, Num));
            }

            else
            {
                Console.WriteLine("Enter Number Value");
            }

        }
    }//class 
}//namespace
