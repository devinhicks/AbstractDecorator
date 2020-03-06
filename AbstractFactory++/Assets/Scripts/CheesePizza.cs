using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheesePizza : IPizza
{
    float m_PizzaPrice = 8.0f; // base price for all pizza varieties
    string prefabPath = "CheesePizza";
    public GameObject za; // game object to be instantiated

    public float GetPrice()
    {
        return m_PizzaPrice;
    }

    public GameObject BakePizza() // loads GameObject into type
    {
        return za;
    }

    public CheesePizza() // load prefab from memory and instantiate
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        za = GameObject.Instantiate(prefab);
    }
}
