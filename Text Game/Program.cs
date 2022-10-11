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
                    Console.WriteLine($"The spider is dead! {player.name} win!");
                    while (true)
                    {
                        Console.WriteLine($"{player.name} finds a chest next to the dead spider, do you want to open it? \n Type 'y' to open. Type 'n' to ignore it");
                        string options = Console.ReadLine();
                        options = options.ToLower();
                        if (options == "n")
                        {
                            Console.WriteLine($"{player.name} continues on through the forest.");
                            break;
                        }
                        else if (options == "y")
                        {
                            while (true)
                            {
                                Console.WriteLine($"{player.name} opens the chest and finds two boxes labelled 1 and 2. Do you want to pick box 1 or box 2?");
                                string box = Console.ReadLine();
                                if (box == "1")
                                {
                                    Console.WriteLine($"{player.name} has found a chest plate! {player.name}'s armour is now {player.armour + 10}!");
                                    player.armour += 10;
                                    break;
                                }
                                else if (box == "2")
                                {
                                    player.health -= 5;
                                    Console.WriteLine($"A baby spider jumped out of the box and bit {player.name} in the hand for 5 damage! {player.name}'s health is now {player.health}.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Pick a valid box");
                                }
                            }
                        }
                        break;
                    }

                    break;
                }
            }

            Console.ReadLine();
        }
    }
}

