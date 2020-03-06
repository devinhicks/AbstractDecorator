using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaDecorator : IPizza
{
    protected IPizza m_DecoratedPizza;

    public PizzaDecorator(IPizza pizza)
    {
        m_DecoratedPizza = pizza;
    }

    public virtual float GetPrice()
    {
        return m_DecoratedPizza.GetPrice();
    }

    public virtual GameObject BakePizza()
    {
        return m_DecoratedPizza.BakePizza();
    }
}

public class Pepperoni : PizzaDecorator
{
    float m_PizzaPrice = 3.0f;
    string prefabPath = "Pepperoni";
    GameObject za;

    public Pepperoni(IPizza pizza) : base(pizza)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        za = GameObject.Instantiate(prefab);
    }

    public override float GetPrice()
    {
        return base.GetPrice() + m_PizzaPrice;
    }
}

public class Supreme : PizzaDecorator
{
    float m_PizzaPrice = 8.0f;
    string prefabPath = "Supreme";
    GameObject za;

    public Supreme(IPizza pizza) : base(pizza)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        za = GameObject.Instantiate(prefab);
    }

    public override float GetPrice()
    {
        return base.GetPrice() + m_PizzaPrice;
    }
}

public class Sausage : PizzaDecorator
{
    float m_PizzaPrice = 4.0f;
    string prefabPath = "Sausage";
    GameObject za;

    public Sausage(IPizza pizza) : base(pizza)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        za = GameObject.Instantiate(prefab);
    }

    public override float GetPrice()
    {
        return base.GetPrice() + m_PizzaPrice;
    }
}

public class BBQChicken : PizzaDecorator
{
    float m_PizzaPrice = 6.0f;
    string prefabPath = "BBQChicken";
    GameObject za;

    public BBQChicken(IPizza pizza) : base(pizza)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        za = GameObject.Instantiate(prefab);
    }

    public override float GetPrice()
    {
        return base.GetPrice() + m_PizzaPrice;
    }
}

public class Margherita : PizzaDecorator
{
    float m_PizzaPrice = 5.0f;
    string prefabPath = "Margherita";
    GameObject za;

    public Margherita(IPizza pizza) : base(pizza)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        za = GameObject.Instantiate(prefab);
    }

    public override float GetPrice()
    {
        return base.GetPrice() + m_PizzaPrice;
    }
}