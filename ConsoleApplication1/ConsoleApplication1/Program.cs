﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Logic window = new Logic();
          //  Logic.hello();
          //  window.menu();
           Population x = new Population();


            /*for (int i = 0; i < x.length(); i++)
            {
                String name = "XYZ";
                x.addPerson(Person.makePerson(name));
            }
            Console.WriteLine("x.length(): " + x.length());
            
            
            Console.WriteLine("pop.ToString" + x.ToString());
           */
            

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
    }
}
