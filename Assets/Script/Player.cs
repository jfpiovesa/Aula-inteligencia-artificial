using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    private Vector3 pos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        pos = transform.position;
        pos.x += speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        pos.z += speed * Input.GetAxis("Vertical") * Time.deltaTime;

        transform.position = pos;
    }
}
