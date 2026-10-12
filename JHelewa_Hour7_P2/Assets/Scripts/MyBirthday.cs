using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int days = 1; days < 28; days++)
        {
            print(days);

            if (days == 27)
            {
                days++;
                print("It's my birthday!");
                for (int marchDays = 29; marchDays <= 31; marchDays++)
                    print(marchDays);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
