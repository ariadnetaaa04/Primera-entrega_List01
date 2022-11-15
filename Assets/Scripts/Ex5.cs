using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
    public int y;
    public int x;
    // Start is called before the first frame update
    void Start()
    {
        if (x > y)
        {
            Debug.Log($"The number {x} it's greater than {y}");
        }

        else
        {
            Debug.Log($"The number {x} it's lesser than {y}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
