using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventurer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your character's name?");
            string name = Console.ReadLine();
            player player = new player(name);
            while (true)
            {

                // giving the player their name

                Console.WriteLine("Pick a weapon \n 1. Sword \n 2. Knife \n");
                sword s = new sword();
                string weapon = Console.ReadLine();
                weapon = weapon.ToLower();

                if (weapon.Equals("1") | weapon.Equals("sword"))
                {
                    player.weapon = s;
                }
                else if (weapon.Equals("2") | weapon.Equals("knife"))
                {
                    knife k = new knife();
                    player.weapon = k;
                }
                else
                {
                    Console.WriteLine("Pick a valid weapon");

                }

                if (player.weapon != null)
                {
                    Console.WriteLine("Your adventure begins!");
                    Console.WriteLine($"A giant spider has attacked {player.name}");
                    spider e = new spider();
                    while (e.health > 0)
                    {
                        Console.WriteLine("Type 'a' to attack the spider");
                        string move = Console.ReadLine();
                        if (move == "a")
                        {
                            player.attack(e, player.weapon);
                            Console.WriteLine($"You have hit the spider with your {player.weapon} \n spider's health is now {e.health}.");
                        }
                        if (e.health > 0)
                        {
                            e.attack(player, e.weapon);
                            Console.WriteLine($"Spider has attacked {player.name} with its fangs! \n {player.name}'s health is now {player.health}");
                        }
                    }
                    Console.WriteLine("The spider is dead! You win!");
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}

