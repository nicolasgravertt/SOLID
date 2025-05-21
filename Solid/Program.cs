using SingleResponsability;
using OpenClosed;
using LiskovSubtitution;
//using InterfaceSegregation;
//using DependencyInjection;

// Single Responsability

// La idea de este principio es reducir la complejidad que tu codigo
// en este ejemplo se muestra como en vez de implementar el metodo de para imprimir el reporte del empleado
// directamente se delega el funcionamiento a otra clase, esto evita que el codigo se complejibilice y sea mas facil de mantener y leer

Employee employee = new Employee("Nicolas");
TimeSheetReport timeSheetReport = new TimeSheetReport();

Console.WriteLine(timeSheetReport.print(employee));

// Open Close Principle

// La idea de este principio es que una clase este abierta para extension y cerrada para modificacion.
// El libro de guru plantea que evitemos modificar las clases para evitar romperlas, es por esto que implementamos un patron de diseño strategy
// el cual nos permite generar nuevas clases para manejar el calculo de los envios, de esta manera evitamos modificar un solo metodo que administra el calculo de los envios
// y nos enfocamos unicamente en generar nuevo codigo sin romper el otro ( Abierto para extension, Cerrado para modificacion )

Aire aire = new Aire();
Tierra tierra = new Tierra();

Orden orden = new Orden(aire);

Console.WriteLine(orden.getShippingCost());
Console.WriteLine(orden.getShippingDate());

orden.setShipping(tierra);

Console.WriteLine(orden.getShippingCost());
Console.WriteLine(orden.getShippingDate());

// Liskov Substitution Principle

// El principio de substitucion liskov dice que hijos de una super clase pueden reemplazar a la super clase
// sin que esta rompa el codigo

Employees employees = new Employees(4000);
ContractualEmployee contractual = new ContractualEmployee(2000);
PermanentEmployee permanent = new PermanentEmployee(6000);

Console.WriteLine(employees.CalcBonus(contractual));
Console.WriteLine(contractual.CalcBonus(contractual));
Console.WriteLine(permanent.CalcBonus(contractual));

Console.WriteLine(employees.CalcSalary(permanent));
Console.WriteLine(contractual.CalcSalary(contractual));
Console.WriteLine(permanent.CalcSalary(employees));

// Aqui vemos como reemplazando la clase padre por cualquiera de sus clases hijas no rompen el codigo.

// importante destacar que para cumplir con este principio es importante seguir estas normas:
// los parametros de los metodos siempre deben ser de una clase mayor ejemplo: Comer(Animal animal)
// este metodo puede recibir toda clase hija de animal
// caso contrario con la devolucion de objetos en un metodo ejemplo: comprarGato(): Animal
// los metodos no deben retornar una clase padre sino una clase en concreto
// otra norma es que un metodo de una subclase no debe arrojar excepciones que la clase padre no maneje. 

// Interface Segregation

// Dependency Injection