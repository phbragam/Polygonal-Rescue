using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolar : MonoBehaviour
{
    new Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 forca = new Vector3(h, 0f, v);

        rigidbody.AddForce(forca);

    }
}
