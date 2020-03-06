using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public PizzaSpawner m_Spawner;
    IPizza currentPizza;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            m_Spawner.SpawnCheesePizza();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            m_Spawner.SpawnPepperoni();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            m_Spawner.SpawnSausage();
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            m_Spawner.SpawnSupreme();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            m_Spawner.SpawnBBQChicken();
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            m_Spawner.SpawnMargherita();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            GameObject[] arr = GameObject.FindGameObjectsWithTag("Za");
            foreach (GameObject za in arr)
            {
                GameObject.Destroy(za);
            }

            currentPizza = null;
        }
    }
}
