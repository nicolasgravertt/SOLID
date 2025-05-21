using System;

namespace LiskovSubtitution;
internal class ContractualEmployee : Employees
{
    public ContractualEmployee(int salary) : base(salary)
    {
    }
}

