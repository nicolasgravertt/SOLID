using System;
namespace DependencyInversion;
internal class BudgetReport
{
    private Database database;

    public BudgetReport(Database database) {  this.database = database; }

    public void SaveReport(string reportName)
    {
        Console.WriteLine("Procesando reporte...");
        database.insert();
    }
}
