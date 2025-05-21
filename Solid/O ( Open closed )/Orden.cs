using System;

namespace OpenClosed;

public class Orden
{
    private Envios shipping;

    public Orden(Envios shipping)
    {
        this.shipping = shipping;
    }

    public void setShipping(Envios shipping)
    {
        this.shipping = shipping;
    }

    public string getShippingCost()
    {
        return shipping.getCost(this);
    }
    public string getShippingDate()
    {
        return shipping.getDate(this);
    }
}
