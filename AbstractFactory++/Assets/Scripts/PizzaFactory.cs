using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaFactory : AbstractFactory
{
    public override IPizza GetPizza(ToppingType tType)
    {
        IPizza currentPizza;

        switch (tType)
        {
            case ToppingType.Cheese:
                IPizza cheeseZa = new CheesePizza();
                currentPizza = cheeseZa;
                return currentPizza;
            case ToppingType.Pepperoni:
                IPizza pepZa = new CheesePizza();
                pepZa = new Pepperoni(pepZa);
                currentPizza = pepZa;
                return currentPizza;
            case ToppingType.Sausage:
                IPizza sausageZa = new CheesePizza();
                sausageZa = new Sausage(sausageZa);
                currentPizza = sausageZa;
                return currentPizza;
            case ToppingType.Supreme:
                IPizza supremeZa = new CheesePizza();
                supremeZa = new Supreme(supremeZa);
                currentPizza = supremeZa;
                return currentPizza;
            case ToppingType.BbqChicken:
                IPizza bbqZa = new CheesePizza();
                bbqZa = new BBQChicken(bbqZa);
                currentPizza = bbqZa;
                return currentPizza;
            case ToppingType.Margherita:
                IPizza margZa = new CheesePizza();
                margZa = new Margherita(margZa);
                currentPizza = margZa;
                return currentPizza;
        }
        return null;
    }
}
