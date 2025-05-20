using System;

namespace Solid;
public interface Envios
{
    string getCost(Orden orden);
    string getDate(Orden orden);
}
