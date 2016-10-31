using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    [Serializable]
    class Wallet
    {
    private int money;

    public Wallet(){
        this.money = 0;
    }

    public void income(int value)
    {
        this.money += value;
    }
    public void outcome(int value)
    {
        this.money -= value;
    }
    public int checkMoney()
    {
        return this.money;
    }

    public override string ToString()
    {
        return "\nWallet: " + this.money + "zl";
    }


}

