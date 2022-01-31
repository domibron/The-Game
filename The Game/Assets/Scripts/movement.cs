using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            transform.position += Vector3.right;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            transform.position += Vector3.left;

        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += Vector3.forward;

        if (Input.GetKey(KeyCode.DownArrow))
            transform.position += Vector3.back;
        Input.GetKey
        if (Input.GetKeyDown(KeyCode.Space))
            transform.position = new Vector3(0, 0.5f, 0);
    }
}
