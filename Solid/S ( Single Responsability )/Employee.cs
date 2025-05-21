using System;

namespace SingleResponsability;
internal class Employee
{
    private string name;

    public Employee(string name)
    {
        this.name = name;
    }

    public string Name { get => name; set => name = value; }
}
