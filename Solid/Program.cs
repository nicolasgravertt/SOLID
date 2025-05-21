using SingleResponsability;
using OpenClosed;
using LiskovSubtitution;
using InterfaceSegregation;
using DependencyInversion;

// 1. Single Responsability

// La idea de este principio es reducir la complejidad que tu codigo
// en este ejemplo se muestra como en vez de implementar el metodo de para imprimir el reporte del empleado
// directamente se delega el funcionamiento a otra clase, esto evita que el codigo se complejibilice y sea mas facil de mantener y leer

Employee employee = new Employee("Nicolas");
TimeSheetReport timeSheetReport = new TimeSheetReport();

Console.WriteLine(timeSheetReport.print(employee));

// 2. Open Close Principle

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

// 3. Liskov Substitution Principle

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

// 4. Interface Segregation

// Segregar Interfaces en interfaces mas pequeñas para no tener una cantidad enorme de metodos en una sola interfaz
// Esto impide que existan metodos innecesarios dentro de una clase que implemente la interfaz ya que esta
// no utiliza todos sus metodos.

// Ejemplo: Tenemos dos clases correspondiente a distintos proveedores de servicios de cloud

Amazon amazon = new Amazon();
Dropbox dropbox = new Dropbox();

// Dentro de estas clases uno pensaria que al ambas ser nubes les corresponderian los mismos metodos de una interfaze
// y tratariamos de crear una interface generica llamada CloudProvider la cual cuenta con todos los metodos
// el problema aca es que amazon ha implementado mas tecnologias que dropbox por lo que ciertos metodos quedarian
// obsoletos para drop box, es por esto que se segmenta los metodos en distintas interfaces dividiendolas
// segun sus funcionalidades

// estos metodos vienen de las interfaces ya segmentadas ya que estas son las que la clase amazon utiliza
amazon.createServer("192.168.1.1", "3000");
amazon.listServers();
amazon.getCDNAAdress();
amazon.storeFile(amazon.getCDNAAdress());
amazon.getFile(amazon.getCDNAAdress());

// En el caso de dropbox solo utiliza las interfaces que necesita y no una generica con metodos que no necesita
dropbox.getFile("path");
dropbox.storeFile("path");
// No tiene acceso a este metodo porque solo amazon ha implementado esta tecnologia
// dropbox.createServer("192.168.1.1","3001");

// Dependency Inversion

// Las clases de alto nivel ( Negocio ) no deben depender de clase de bajo nivel ( Trabajar en un disco,
// Transferir datos por una red, conectar con una base de datos ).

// Ejemplo: Tenemos una interfaz database que implementa los metodos CRUD de una base de datos comun y corriente
// Las declaramos como interfaces
Database mongoDatabase = new MongoDB();
Database mySQLDatabase = new MySQL();

// Aqui invertimos la dependencia, haciendo que las clases de bajo nivel ( Grabar en base de datos ) no dependan
// de clases de alto nivel ( Negocio ) Sino que ahora dependen de una abstraccion de una clase de alto nivel
// en este caso la clase de alto nivel depende de interfaces asociadas al funcionamiento de clases de bajo nivel
// y no esta directamente acoplada a un tipo de clase de bajo nivel ( Guardar en base de datos ) 
// .... Ver dentro de la clase de BudgetReport como esta declara una variable privada de tipo interface y crea el constructor con ella
BudgetReport mongoBudgetReport = new BudgetReport(mongoDatabase);
BudgetReport mySQLBudgetReport = new BudgetReport(mongoDatabase);

mongoBudgetReport.SaveReport("Reporte guardado en mongo");
mySQLBudgetReport.SaveReport("Reporte guardado en mySQL");