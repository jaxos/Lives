using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static Person p = null;
        static void Main(string[] args)
        {
            //  Logic window = new Logic();
            //  Logic.hello();
            //  window.menu();


            menu();
        /*
        Population x = new Population();


            for (int i = 0; i < x.length(); i++)
            {
                String name = "XYZ";
                x.addPerson(Person.makePerson(name));
            }
            Console.WriteLine("x.length(): " + x.length());
            
            
            Console.WriteLine("pop.ToString" + x.ToString());
           
            

            Person adam = Person.makePerson("Adam");
            Person eva = Person.makePerson("Eva");
            
            Console.WriteLine(adam.ToString());
            Console.WriteLine(eva.ToString());
            
            Person child = eva.sexWith(adam);

            if(child != null) Console.WriteLine(child.ToString());
            Place place = new Place();
            Place p1 = new Place();
            Place p2 = new Place();
            
           
            Console.WriteLine(place.ToString());
            place.buy(adam);
            Console.WriteLine(place.ToString());
            place.makeParty(4, adam);

            Food food = new Food();
            Console.WriteLine( food.ToString());
            Apple ap = new Apple();
            Console.WriteLine(ap.ToString());
            RawMeat raw = new RawMeat();

            BoiledMeat boiled = new BoiledMeat();
            FriedMeat fried = new FriedMeat();
            adam.eatPoison();
            Console.WriteLine(adam.ToString());
            raw.eat(adam);
            Console.WriteLine(adam.ToString());
            Console.WriteLine(ap.ToString());
            ap.eat(adam);
            ap.eat(adam);
            Console.WriteLine(adam.ToString());

            /* Console.WriteLine(adam.ToString());
             adam.eatFood();
             Console.WriteLine(adam.ToString());
             adam.eatPoison();
             Console.WriteLine(adam.ToString());

             adam.eatFood();
             Console.WriteLine(adam.ToString());
             adam.eatFood();
             Console.WriteLine(adam.ToString());
             adam.eatPoison();
             Console.WriteLine(adam.ToString());
             adam.eatPoison();
             Console.WriteLine(adam.ToString());
             */
             
            Console.ReadKey(); //WAIT FOR CLOSING

            

        }
        public static void menu()
        {
           
            
            
            int choice = 10000;
            while (choice != 0)
            {

                Console.WriteLine("=========================");
                Console.WriteLine("Your character: \n");
                if (p != null) { Console.WriteLine(p.ToString()); }
                else
                {
                    Console.WriteLine("No character created at the moment.");
                }
                Console.WriteLine("=========================");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Create your person.");
                Console.WriteLine("2. See the inventory.");
                Console.WriteLine("3. Check your money.");
                Console.WriteLine("4. Eat.");
                Console.WriteLine("5.");
                Console.WriteLine("6.");
                Console.WriteLine("7. See your family.");
                Console.WriteLine("8. Save game.");
                Console.WriteLine("9. Load game.");
                Console.WriteLine("0. Exit game :(");



                char read = Console.ReadKey(true).KeyChar;
                choice = read-48;
                //Console.WriteLine(read + " - this is the key + this is choice - " + choice);
                
                while (choice <0 || choice >9) // sprawdzanie czy to jest liczba całkowita
                {
                    Console.WriteLine("Type in a valid number");
                    read = Console.ReadKey(true).KeyChar;
                    choice = read-48;

                }
                
                //Console.WriteLine("Choice: " + choice);


                switch (choice)
                {
                    case 1:
                        
                        Console.WriteLine("What name should your character have?");
                        String name = Console.ReadLine();
                        if (p == null) { p = Person.makePerson(name); }
                        else
                        {
                            Console.WriteLine("Your character is already created. PRESS ENTER TO CONTINUE...");
                            Console.ReadKey();
                        }

                            break;
                    case 2:
                        if (p == null) { Console.WriteLine("No character created..."); }
                        else { Console.Clear(); Console.WriteLine(p.getInventory()); }
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case 3:
                        if(p==null) { Console.WriteLine("No character created...");}
                        else { Console.Clear(); Console.WriteLine("Your money: " + p.checkMoney()); }
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;

                    case 4:
                        int choice2 = 10000;
                        if (p == null) { Console.WriteLine("No character created..."); }
                        else { Console.Clear(); Console.WriteLine(p.getInventory()); }
                        switch (choice2)
                        {
                            case 1:
                                /*I HAVE NO IDEA WHAT I AM DOING*/
                                Console.WriteLine("Click enter!");
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                        
                    case 8:
                        
                        // Construct a BinaryFormatter and use it to serialize the data to the stream.
                        BinaryFormatter formatters = new BinaryFormatter();
                        if (p == null) { Console.WriteLine("You have to create a character to save game!\nClick to continue..."); Console.ReadKey(); ; }
                        else
                        {
                            FileStream fss = new FileStream("DataFile.dat", FileMode.Create);
                            try
                            {
                                if (p != null) formatters.Serialize(fss, p);
                            }
                            catch (SerializationException e)
                            {

                                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                                throw;
                            }
                            finally
                            {
                                fss.Close();
                                Console.WriteLine("Game has been saved");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        break;

                    case 9:
                        FileStream fso = new FileStream("DataFile.dat", FileMode.Open);
                        try
                        {
                            BinaryFormatter formattero = new BinaryFormatter();

                            // Deserialize the hashtable from the file and 
                            // assign the reference to the local variable.
                            
                            p = (Person)formattero.Deserialize(fso);
                        }
                        catch (SerializationException e)
                        {
                            Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                            throw;
                        }
                        finally
                        {
                            fso.Close();
                        }
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("choice: " + choice);
                        break;

                }
                Console.Clear();

            }


        }
    }
}