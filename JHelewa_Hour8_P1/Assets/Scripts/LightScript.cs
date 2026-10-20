using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Light lightComponent;
    void Start()
    {
        lightComponent = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (lightComponent != null)
            {
                lightComponent.enabled = !lightComponent.enabled;
            }
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (lightComponent != null)
                {
                    lightComponent.enabled = lightComponent.enabled;
                }
            
        }
    }
}
