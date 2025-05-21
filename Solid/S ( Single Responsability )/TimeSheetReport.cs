using System;

namespace SingleResponsability;

internal class TimeSheetReport
{
    public string print(Employee employee)
    {
        return employee.Name;
    }
}
