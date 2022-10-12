using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Adventurer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isDead = false;
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
                            Console.WriteLine($"{player.name} attacked the spider with their {player.weapon.name} \n spider's health is now {e.health}.");
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
                        isDead = true;
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
                                            isDead = true;
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
                            Console.WriteLine($"{player.name} attacked the robber with their {player.weapon.name} \n Robber's health is now {enemy2.health} and their armour is now {enemy2.armour}.");
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
                        isDead = true;
                        break;
                    }

                    Console.WriteLine("By the fireplace, you find a mysterious bag! Do you want to look in the bag? \n Type 'y' to look in the bag. Type 'n' to leave the bag.");
                    while (true)
                    {
                        string options = Console.ReadLine();
                        options = options.ToLower();
                        if (options.Equals("y"))
                        {
                            player.health += 20;
                            player.armour += 30;
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

                    Console.WriteLine("As you continue your travels, you come across a small, secluded castle. A corrupt knight attacks you.");
                    knight enemyKnight = new knight();

                    while(player.health > 0 & enemyKnight.health > 0)
                    {
                        Console.WriteLine("Type 'a' to attack the corrupt knight");
                        string move = Console.ReadLine();
                        if (move.Equals("a"))

                        {
                            player.attack(enemyKnight, player.weapon);
                            Console.WriteLine($"{player.name} attacked the corrupt knight with their {player.weapon.name} \n Knight's health is now {enemyKnight.health} and their armour is now {enemyKnight.armour}.");
                        }
                        if (enemyKnight.health > 0)
                        {
                            enemyKnight.attack(player, enemyKnight.weapon);
                            Console.WriteLine($"The corrupt knight has attacked {player.name} with his sword! \n {player.name}'s health is now {player.health} and their armour is now {player.armour}");
                        }
                    }

                    if (enemyKnight.health <= 0)
                    {
                        Console.WriteLine($"The Knight is dead! {player.name} wins!");
                    }
                    else if (player.health <= 0)
                    {
                        Console.WriteLine($"{player.name} has died!");
                        isDead = true;
                        break;
                    }

                    break;
                }  
            }

            int score = player.health + player.armour;

            if (isDead == false)
            {

                Console.WriteLine($"Congrats! You have completed the game :) \n Your final armour was {player.armour}. \n Your final health was {player.health}. \n {player.name}'s final score is: {score}.");
            }
            else
            {
                Console.WriteLine($"You have lost the game :( \n Better luck next time! \n Your final armour was {player.armour}. \n Your final health was {player.health}. \n {player.name}'s final score is: {score}.");
            }

            string myConnectionStrng = "server=127.0.0.1;uid=root;" + "pwd=Deloitte1;database=gamescoreboard";
            MySqlConnection cnn;
            cnn = new MySqlConnection(myConnectionStrng);
            try
            {
                cnn.Open();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("Failed");
            }

            var cmd = new MySqlCommand();
            cmd.Connection = cnn;


            cmd.CommandText = $"INSERT INTO Scores (`CharacterName`, `Score`) VALUES ('{player.name}', {score})";
            cmd.ExecuteNonQuery();

            Console.WriteLine("Top scores");
            cmd.CommandText = "SELECT * FROM Scores ORDER BY `Score` DESC LIMIT 5";

            int rank = 1;

            using (MySqlDataReader reader = cmd.ExecuteReader())

            while (reader.Read())
            {
                Console.WriteLine(rank + ". " + "{0} {1}", reader.GetString(1), reader.GetInt32(2));
                    rank += 1;
            }

            cnn.Close();

            Console.ReadLine();

        }
    }
}

