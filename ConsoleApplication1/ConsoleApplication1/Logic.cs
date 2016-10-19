using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Logic
    {
        private Person human = null;
        public static void hello()
        {
            Console.WriteLine("Welcome to our Human 2.0 project!\nThis is a very complex project" + 
                "so try not to mess up and don't kill your private human!");
        }
        public void menu()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine(
                "1. Create your human!\n" +
                "2. Feed your human\n" +
                "3. Give a poison for your human...\n" +
                "4. KILL your human\n" +
                "5.Exit Game\n");
            int read = Console.Read();
            while (read<1 && read>5)
            {
                read = Console.Read();
            }
            if (read == 1) {
                Console.Clear();
                Console.WriteLine("What will be the name of your human?");
                this.human = Person.makePerson(Console.ReadLine());
                Console.WriteLine(this.human.getName() + "has been created");
                        }
                else if (read == 2) { this.human.eatFood(); }
                else if (read == 3) { this.human.eatPoison(); }
                else if (read == 4) { this.human = null; }
                else if (read == 5) { Environment.Exit(0);  }

        }

    }
}
