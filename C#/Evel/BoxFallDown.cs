using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxFallDown : MonoBehaviour
{
    public GameObject[] FallBoxes;

    //public GameObject XXbox;

    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Collider - OK");
            foreach(GameObject AnyWord in FallBoxes) 
            {
                AnyWord.GetComponent<Rigidbody>().useGravity = true;
                
                //AnyWord.SetActive(false);
                //Invoke("DestroyBoxes",1f);
            }
            //XXbox.GetComponent<Rigidbody>().useGravity = true;

        }
    }


    public void DestroyBoxes()
    {
        gameObject.SetActive(false);
    }
}
