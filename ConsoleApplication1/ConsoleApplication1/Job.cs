using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
    
    [Serializable]
    class Job
    { //Need to add different jobs and skill required
    private int salary;
    private String role;
    private String companyName;

    private Job()
    {
        this.salary = 1000;
        this.role = "none";
        this.companyName = "company";
    }

    public static Job getJob()
    {
        return new Job();
    }

    public override string ToString()
    {
        return "\nSalary: " + salary + " Role: " + this.role + " Company: " + this.companyName; 
    }

}

