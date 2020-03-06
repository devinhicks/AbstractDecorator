using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryProducer : MonoBehaviour
{
    public static AbstractFactory GetFactory(FactoryType factoryType)
    {
        // room to add more factories
        switch(factoryType)
        {
            case FactoryType.Pizza:
                AbstractFactory pizzaFactory = new PizzaFactory();
                return pizzaFactory;
        }
        return null;
    }
}
