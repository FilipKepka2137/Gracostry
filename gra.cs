using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_wyrzutnia_rakiet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName;
            int playerHealth = 100;
            int playerDamage = 20;
            int enemyHealth = 50;
            int enemyDamage = 10;

            Console.WriteLine("Witaj na arenie!");
            Console.Write("Jak ci na imie?: ");
            playerName = Console.ReadLine();

            Console.WriteLine("Cześć, " + playerName + " Zaczynajmy!.");

            while (playerHealth > 0 && enemyHealth > 0)
            {
                Console.WriteLine("\n" + playerName + "'s HP: " + playerHealth);
                Console.WriteLine("HP Przeciwnika: " + enemyHealth);
                Console.WriteLine("1. Atak");
                Console.WriteLine("2. Obrona");
                Console.WriteLine("3. Ucieczka");

                Console.Write("Wybieraj co robisz (1-3): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine(playerName + " Atak");
                        enemyHealth -= playerDamage;
                        Console.WriteLine("Wróg traci " + playerDamage + " HP.");
                        break;
                    case "2":
                        Console.WriteLine(playerName + " broni się przed atakiem wroga.");
                        playerHealth -= enemyDamage / 2;
                        Console.WriteLine("Tracisz " + (enemyDamage / 2) + " HP.");
                        break;
                    case "3":
                        Console.WriteLine(playerName + " próbujesz uciec.");
                        if (new Random().Next(1, 3) == 1)
                        {
                            Console.WriteLine("Udało ci się uciec!");
                            enemyHealth = 0;
                        }
                        else
                        {
                            Console.WriteLine("Nie udało ci się uciec!");
                            playerHealth -= enemyDamage;
                            Console.WriteLine("Wróg cię zaatakował i tracisz " + enemyDamage + " HP.");
                        }
                        break;
                    default:
                        Console.WriteLine("Nie umiesz czytać czy pisać?");
                        break;
                }

                if (enemyHealth > 0)
                {
                    Console.WriteLine("\nPrzeciwnik cię atakuje!");
                    playerHealth -= enemyDamage;
                    Console.WriteLine("Tracisz " + enemyDamage + " HP.");
                }

                if (playerHealth <= 0)
                {
                    Console.WriteLine("\n" + playerName + " Game over! https://drive.google.com/file/d/1KZGcfUoanist1v5VRJDY2xOuh2kZ__XQ/view?usp=sharing");
                }
                else if (enemyHealth <= 0)
                {
                    Console.WriteLine("\nWygrywasz!!!");
                }
            }

            Console.WriteLine("\nKoniec");
            Console.ReadLine();
        }
    }
}
