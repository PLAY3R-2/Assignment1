using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public int lampcount = 9;
    public float lampdist = 1.5f;
    public float lampoff = .5f;
    void Start()
    {
        for (int lamps = 0; lamps < lampcount; lamps++)
        {
            float lampplace = lampoff + (lamps * lampdist);
            Vector3 gapdist = new Vector3(lampplace, 0, -5);
            Quaternion norotate = new Quaternion(0, 0, 0, 0);
            Instantiate(prefab, gapdist, norotate);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}