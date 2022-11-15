using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    public int age;
    public string name;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"hello, {name} ! You are {age} years old");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
