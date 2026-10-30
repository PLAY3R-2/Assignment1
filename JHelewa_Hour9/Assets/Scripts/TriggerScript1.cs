using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript1 : MonoBehaviour
{
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " has entered the" + gameObject.tag);
    }
    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " is still in the" + gameObject.tag);
    }

    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " has left the" + gameObject.tag);
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
