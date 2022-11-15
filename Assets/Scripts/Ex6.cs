using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex6 : MonoBehaviour
{
    public int  days;
    // Start is called before the first frame update
    void Start()
    {
       if (days > 1 && days < 6){
       
            Debug.Log($"Day {days} does not belong to the weekend");
       }
        else if (days <1 || days > 7){
            Debug.Log($"Enter a valid day between 1-7 ");
        }
        else
         {
             Debug.Log ($"Day {days} belongs to the weekend");
         }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
