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
                    while (e.health > 0 & player.health > 0)
                    {
                        Console.WriteLine("Type 'a' to attack the spider");
                        string move = Console.ReadLine();
                        if (move.Equals("a"))
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
                    if (e.health <= 0)
                    {
                        Console.WriteLine($"The spider is dead! {player.name} wins!");
                    }
                    else if (player.health <= 0)
                    {
                        Console.WriteLine($"{player.name} has died!");
                        break;
                    }
                    while (true)
                    {
                        Console.WriteLine($"{player.name} finds a chest next to the dead spider, do you want to open it? \n Type 'y' to open. Type 'n' to ignore it");
                        while (true) {
                            string options = Console.ReadLine();
                            options = options.ToLower();
                            if (options.Equals("n"))
                            {
                                Console.WriteLine($"{player.name} continues on through the forest.");
                                break;
                            }
                            else if (options.Equals("y"))
                            {
                                while (true)
                                {
                                    Console.WriteLine($"{player.name} opens the chest and finds two boxes labelled 1 and 2. Do you want to pick box 1 or box 2?");
                                    string box = Console.ReadLine();
                                    if (box.Equals("1"))
                                    {
                                        Console.WriteLine($"{player.name} has found a chest plate! {player.name}'s armour is now {player.armour + 10}!");
                                        player.armour += 10;
                                        break;
                                    }
                                    else if (box.Equals("2"))
                                    {
                                        player.health -= 5;
                                        Console.WriteLine($"A baby spider jumped out of the box and bit {player.name} in the hand for 5 damage! {player.name}'s health is now {player.health} and their armour is now {player.armour}.");
                                        if (player.health <= 0)
                                        {
                                            Console.WriteLine($"{player.name} has died!");
                                            Console.ReadLine();
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Pick a valid box");
                                    }
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Pick a valid option.");
                            }
                        }
                        break;
                    }
                    Console.WriteLine("As you travel through the forest, you come a fireplace. From the shadows, a robber with a sword attacks you.");
                    robber enemy2 = new robber();

                    while (enemy2.health > 0 & player.health > 0)
                    {

                        Console.WriteLine("Type 'a' to attack the robber");
                        string move = Console.ReadLine();
                        if (move.Equals("a"))
                        {
                            player.attack(enemy2, player.weapon);
                            Console.WriteLine($"You have hit the robber with your {player.weapon} \n Robber's health is now {enemy2.health} and their armour is now {enemy2.armour}.");
                        }
                        if (enemy2.health > 0)
                        {
                            enemy2.attack(player, enemy2.weapon);
                            Console.WriteLine($"Robber has attacked {player.name} with his sword! \n {player.name}'s health is now {player.health} and their armour is now {player.armour}");
                        }

                    }
                    if (enemy2.health <= 0)
                    {
                        Console.WriteLine($"The robber is dead! {player.name} wins!");
                    }
                    else if (player.health <= 0)
                    {
                        Console.WriteLine($"{player.name} has died!");
                    }

                    Console.WriteLine("By the fireplace, you find a mysterious bag! Do you want to look in the bag? \n Type 'y' to look in the bag. Type 'n' to leave the bag.");
                    while (true)
                    {
                        string options = Console.ReadLine();
                        options = options.ToLower();
                        if (options.Equals("y"))
                        {
                            player.health += 20;
                            player.armour += 20;
                            Console.WriteLine($"{player.name} has found a bunch of armour and medicine. {player.name}'s health is {player.health} and {player.name}'s armour is now {player.armour}");
                            break;
                        }
                        else if (options.Equals("n"))
                        {
                            Console.WriteLine($"{player.name} continues with their journey.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Pick a valid option.");
                        }
                    }
                    break;
                }  
            }

            Console.ReadLine();
        }
    }
}

