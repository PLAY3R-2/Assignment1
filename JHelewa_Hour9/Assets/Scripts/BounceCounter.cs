using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    // Start is called before the first frame update
    int totalBounce = 0;
    void OnCollisionEnter(Collision collision)
    {
        totalBounce++;
        
        print(totalBounce);
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
