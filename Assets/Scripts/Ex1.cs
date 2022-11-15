using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    public float x = 7;
    public float y = 2;
    public float z = 1;
    public float result;

    // Start is called before the first frame update
    void Start()
    {
     result = x + y + z; 
     {
        Debug.Log($"{x} + {y} + {z}= {result}"); 
     }
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
