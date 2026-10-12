using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float number = 22f;
        float numCap = 100f;
        while (number <= numCap)
        {
            print(number);
            number = number + 2;
        }
    }

        // Update is called once per frame
        void Update()
        {

        }
}
