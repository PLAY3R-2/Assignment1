using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxis("Horizontal")/20;
        float mY = Input.GetAxis("Vertical")/20;
        transform.Translate(mX, mY, 0);
    }
}
