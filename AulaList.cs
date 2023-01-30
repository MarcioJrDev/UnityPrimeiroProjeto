using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaList : MonoBehaviour
{

    public List<int> idade = new List<int>();


    void Start()
    {
       idade.Add(1);
       idade.Add(2);
       idade.Add(3);

    
    foreach (int item in idade)
    {
        Debug.Log(item);
    }
    }

    void Update()
    {

    }
}