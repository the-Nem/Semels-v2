using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallFall1 : MonoBehaviour
{
    //public GameObject FirBal_1;
    //public GameObject FirBal_2;
    //public GameObject FirBal_3;

    public GameObject[] FireBalls;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject item in FireBalls)
        {
            item.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Player") { FallBall_1(); Invoke("FallBall_2",1f); Invoke("FallBall_3",1.5f); }
        if (other.gameObject.tag == "Player")
        {
            foreach (GameObject item in FireBalls)
            {
                item.SetActive(true); Invoke("Destroy", 2f);
            } 
        }
    }
    //void FallBall_1() { FirBal_1.SetActive(true); Invoke("Destroy", 2f); }
    //void FallBall_2() { FirBal_2.SetActive(true); Invoke("Destroy", 2f); }
    //void FallBall_3() { FirBal_3.SetActive(true); Invoke("Destroy", 2f); }
    void Destroy() { Destroy(gameObject); }

}
