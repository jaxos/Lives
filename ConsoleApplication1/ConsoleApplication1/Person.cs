using Lives;
using System;

[Serializable]
public class Person
{
    private int id;
    private String name;
    private String surname;
    private String sex;
    private int age;
    private int health;
    private Boolean alive = true;
    private int promiles;
    private Wallet wallet;
    private Inventory inventory;
    private Clothes[] clothes;
    private Job job;
    private Place[] places;
    private static int idcount;
    
	private Person()
	{
	}

    private Person(String name)
    {

        int sexn = (new Random()).Next(1, 1002);
        this.name = name;
        this.surname = ".";   
        this.age = 0;
        this.id = (Person.idcount++)+1;
        this.health = 100;
        this.wallet = new Wallet();
        this.job =  Job.getJob();
        this.inventory = new Inventory();

        if (sexn % 2 == 0)
        {
            System.Threading.Thread.Sleep(20);
           // Console.WriteLine("SEXN:" + sexn); //debugging line for Random number
            this.sex = "Male";     
        }
        else
        {
            System.Threading.Thread.Sleep(20);
            this.sex = "Female";
            //Console.WriteLine("SEXN:" + sexn);//debugging line for Random number

        }
    }
    public static Person makePerson(String name)
    {
        return new Person(name);
    }

    public void changeHealth(int value)
    {
        this.health += value;
    }



    public void eatPoison()
    {
        this.health -= 50;
        
        Console.WriteLine(this.name + " ate POISON!");
        if (this.health <= 0)
        {
            this.health = 0;
            this.alive = false;
        }
    }

    public Person sexWith(Person second)
    {
        if (this.sex != second.sex)
        {
            return new Person("JohnDoe");
        }
        else
        {
            Console.WriteLine("Can't have child with a person of a same sex");
            return null;
        }
    }

    public void checkAlive()
    {
        if (this.health > 0) this.alive = true;
        else this.alive = false;

    }
    public int checkMoney()
    {
        return this.wallet.checkMoney();
    }

    public void newJob()
    {
        this.job = Job.getJob();
    }

    

    public override string ToString()
    {
        return "Person id: " + this.id + ", name: " + this.name + ", sex: " + this.sex + "\nage: " + this.age
            + ", health: " + this.health + ", alive: " + this.alive +
             this.wallet.ToString() +
             this.job.ToString() + "\n";
             //+this.inventory.ToString()+"\n";
    }

    public String getInventory()
    {
        return this.inventory.ToString();
    }

    
    public String getName()
    {
        return this.name;
    }

   



}
