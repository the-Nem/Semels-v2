using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X1 : MonoBehaviour
{

    public GameObject boxFall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Water") { boxFall.GetComponent<Rigidbody>().useGravity = true; }
    }

}
