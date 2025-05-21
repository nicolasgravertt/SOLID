using System;
namespace OpenClosed;
public interface Envios
{
    string getCost(Orden orden);
    string getDate(Orden orden);
}
