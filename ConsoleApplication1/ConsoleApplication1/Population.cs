using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Population
    {
      //We'll see if this class will be useful
        
        private Person[] people = null;
        private static int popNumber=0;

        public Population()
        {
            this.people = new Person[20];
        }
        public void addPerson(Person person)
        {
            int i = popNumber++;
            people[i] = person;
        }
        public override string ToString()
        {
            String all= "";
             for(int i= 0; i < 5; i++) {   
                all += people[i].ToString() + "\n";
            }
            return all;

        }

        public int length()
        {
            return people.Length;
        }






    }

