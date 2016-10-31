using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    [Serializable]
    class Place
    {
    /*place of residence
    has different parameters:
    - number of hous livers
    - luxury
    - if house or apartment
    - floor (if apartment)
    -...
        */
    private int id;
    private static int idCount = 0;
    private Person owner = null;
    private Person[] residents;
    private types type;
    private int price;
    private int residentsN;
    private int floors;
    private lux luxury;
    private Boolean buyable;

    enum types { Apartment, House };
    enum lux { Poor, Standard, Luxury}; 

    public Place()
    {
        this.id = ++idCount;
        this.owner = null;
        this.type = (types)0;
        this.price = 0;
        this.residentsN = 3;
        this.floors = 1;
        this.luxury = (lux)1;
        this.buyable = true;



    }
    public void buy(Person p)
    {
        if (p.checkMoney() >= this.price)
        {
            this.owner = p;
            this.buyable = false;

        }
    //p.checkMoney() > this.price ? (owner = p) : return;
    }

    public void sell()
    {
        this.buyable = true;
    }

    public void makeParty(int visitors, Person person)
    {
        //        residents.Contains(person) && this.residentsN * 3 > visitors ? Console.WriteLine("Let's PARTY!!!");
        //: (residents.Contains(person) ? Console.WriteLine("There is not enough room..."): Console.WriteLine("The partymaker is not a resident of this place...")) ;
        if (this.owner == person && this.residentsN  > visitors)
        {
            Console.WriteLine("Let's PARTY!!!");
        } else if (this.owner == person)
        {
            Console.WriteLine("Not enough room...");
        }else
        {
            Console.WriteLine("The Partymaker is not a resident of this place!");
        }

    }

    


    public override string ToString()
    {
        return "Id: " + id + " Type: " + this.type + " idCount: " + idCount+
            " Owner: " + this.owner;
    }

    //private 
}

