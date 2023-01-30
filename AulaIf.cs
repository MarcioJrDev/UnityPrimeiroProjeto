using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaIf : MonoBehaviour
{
        public bool isAlive;   

    // Start is called before the first frame update
    void Start()
    {
            if(isAlive == true)
            {
                Debug.Log("Vivo");
            }

            else
            {
                Debug.Log("Morto");
            }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
