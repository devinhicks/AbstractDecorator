using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaSpawner : MonoBehaviour
{
    private IPizza m_Cheese;
    private IPizza m_Pepperoni;
    private IPizza m_Sausage;
    private IPizza m_Supreme;
    private IPizza m_BBQChicken;
    private IPizza m_Margherita;

    private AbstractFactory factory;

    public void SpawnCheesePizza()
    {
        factory = FactoryProducer.GetFactory(FactoryType.Pizza);
        m_Cheese = factory.GetPizza(ToppingType.Cheese);
        Debug.Log("Price: " + m_Cheese.GetPrice());
    }

    public void SpawnPepperoni()
    {
        factory = FactoryProducer.GetFactory(FactoryType.Pizza);
        m_Pepperoni = factory.GetPizza(ToppingType.Pepperoni);
        Debug.Log("Price: " + m_Pepperoni.GetPrice());
    }

    public void SpawnSausage()
    {
        factory = FactoryProducer.GetFactory(FactoryType.Pizza);
        m_Sausage = factory.GetPizza(ToppingType.Sausage);
        Debug.Log("Price: " + m_Sausage.GetPrice());
    }

    public void SpawnSupreme()
    {
        factory = FactoryProducer.GetFactory(FactoryType.Pizza);
        m_Supreme = factory.GetPizza(ToppingType.Supreme);
        Debug.Log("Price: " + m_Supreme.GetPrice());
    }

    public void SpawnBBQChicken()
    {
        factory = FactoryProducer.GetFactory(FactoryType.Pizza);
        m_BBQChicken = factory.GetPizza(ToppingType.BbqChicken);
        Debug.Log("Price: " + m_BBQChicken.GetPrice());
    }

    public void SpawnMargherita()
    {
        factory = FactoryProducer.GetFactory(FactoryType.Pizza);
        m_Margherita = factory.GetPizza(ToppingType.Margherita);
        Debug.Log("Price: " + m_Margherita.GetPrice());
    }
}
