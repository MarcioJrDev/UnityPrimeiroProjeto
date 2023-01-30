using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaSwitch : MonoBehaviour
{
        public int diaSemana;   

    // Start is called before the first frame update
    void Start()
    {
            switch (diaSemana)
            {
                case 1:
                Debug.Log ("É Nois");
                    break;
                
                case 2:
                Debug.Log ("Num É Nois");
                    break;
                
                default:
                    Debug.Log("Sei Lá");
                    break;
            }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}