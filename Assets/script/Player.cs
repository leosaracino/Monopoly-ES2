using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    int x = 0;
    int contx = 10;
    int conty = 10;
    int inv = 0;
    void Start()
    {
        DiceCheckZone.onAllDicesStop += andar;

    }

    void andar(int soma)
    {

        float dado = soma;
        for (int i = 0; i < soma; i++)
        {   
            if (contx > 0)
            {   
                if(inv == 0) 
                {
                    float y = -(float)1.05;
                    transform.position = transform.position + new Vector3(y, 0, 0);
                    contx--;
                }
                else
                {
                    float y = (float)1.05;
                    transform.position = transform.position + new Vector3(y, 0, 0);
                    contx--;
                }
            }
            else if (conty > 0)
            {
                if (inv == 0)
                {
                    float z = (float)1.05;
                    transform.position = transform.position + new Vector3(0, 0, z);
                    conty--;
                }
                else
                {
                    float z = -(float)1.05;
                    transform.position = transform.position + new Vector3(0, 0, z);
                    conty--;
                }
                
            }
            x++;
            switch (x)
            {
                case 20:
                    inv = 1;
                    break;
                case 40:
                    x = 0;
                    inv = 0;
                    break;
            }
            if (contx == 0 && conty == 0)
            {
                contx = 10;
                conty = 10;
            }

        }
        
    }
}
