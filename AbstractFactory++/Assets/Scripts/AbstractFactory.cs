using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractFactory
{
    public abstract IPizza GetPizza(ToppingType tType);
}
