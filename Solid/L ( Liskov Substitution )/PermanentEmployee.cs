using System;

namespace LiskovSubtitution;
internal class PermanentEmployee : Employees
{
    public PermanentEmployee(int salary) : base(salary)
    {
    }
}

