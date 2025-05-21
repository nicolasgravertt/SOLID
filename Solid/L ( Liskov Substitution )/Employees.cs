using System;

namespace LiskovSubtitution;
internal class Employees
{
    private int salary;

    public Employees(int salary)
    {
        this.salary = salary;
    }
    public virtual int CalcSalary(Employees employee)
    {
        return salary;
    }
    public virtual int CalcBonus(Employees employee) { 
        return salary / 2;
    }
}
