using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour {
    [SerializeField]
    private float speed;
   
    [SerializeField]
    private float yPosition;
    float x;
    float y;
    float z;

    // Use this for initialization
    void Start()
    {
        x = -2.0f;
        z = Random.Range(-1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        x += Time.deltaTime * speed;
        y = yPosition;

        if(x >= 2.0f)
        {
            x = -2.0f;
        }

        transform.position = new Vector3(x, y, z);
    }
}
