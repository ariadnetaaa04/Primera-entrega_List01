using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex8 : MonoBehaviour
{ 
    public string month;
    /*
    public string month = january;
    public string month= february;
    public string month = march;
    public string month = april;
    public string month = may;
    public string month = june;
    public string month = july;
    public string month = august;
    public string month = september;
    public string month = october;
    public string month = november;
    public string month = december;
    */
    // Start is called before the first frame update
    void Start()
    {
        if (month == january || month == march || month == may || month == july || month == august || month == october || month == december)
    { Debug.Log ($"{month} has 31 days");}
    else if (month == april || month == june || month == september || month==november)
    {Debug.Log ($"{month} has 30 days");}
    else {Debug.Log($"{month} has 28 days");}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
