using Solid;


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
