using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaFor : MonoBehaviour
{
    //For é um laço/loop de repetição

    /*Laço (loop) de repetição de uma estrutura que executa um conjunto e instruções enquanto uma determinada condição é verdadeira */

    public int[] arrayInt = {1,2,3,4};

    void Start()
    {
        //for (valorInicial; CondiçãoFinal; ValorIncremental)
        // // ++ é o incremento que é igual i += 1;
        // for (int i = 0; i < 10; i++)
        // {
        //     Debug.Log(i);
        // }
    

    foreach (int valor in arrayInt)
    {
        Debug.Log(valor);
        }
    }
}