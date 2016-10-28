using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Food
    {
    protected int id;
    protected int product;
    protected int health;
    protected int price;
    protected String name;

    public Food()
    {
        this.id = 0;
        this.health = 0;
        this.name = "Food";
        this.price = 0;

    }

    public void eat(Person person)
    {
        
        person.changeHealth(this.health);
        this.health = 0;
        this.name = "Eaten";
        this.price = 0;
        person.checkAlive();
    }
    

    public override string ToString()
    {
        return "ID: " + this.id + " name: " + this.name + " health: " + this.health + " price: " + price ;
    }

    public enum foods { Apple, RawMeat, BoiledMeat, FriedMeat, Orange, Broccoli}
}
public class Apple : Food
{
    public Apple()
    {
        this.id =(int)foods.Apple;
        this.health = 5;
        this.name = "Apple";
        this.price = 2;
    }
}

public class RawMeat : Food
{
    public RawMeat()
    {
        this.id = (int)foods.RawMeat;
        this.health = 10;
        this.name = "Raw Meat";
        this.price = 6;
    }
}



public class BoiledMeat : Food
{
    public BoiledMeat(RawMeat r)
    {
        r = null;
        this.product = 0;
        this.id = ++id;
        this.health = 20;
        this.name = "Boiled Meat";
        this.price = 12;
    }
    public BoiledMeat()
    {
        Console.WriteLine("You need Raw Meat to prepare Boiled Meat!");
    }
}



public class FriedMeat : Food
{
    public FriedMeat(RawMeat r)
    {
        r = null;
        this.id = (int)foods.FriedMeat;
        this.health = 35;
        this.name = "Fried Meat";
        this.price = 15;
    }
    public FriedMeat()
    {
        Console.WriteLine("You need Raw Meat to prepare Fried Meat!");
    }
}




