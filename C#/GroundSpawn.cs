//using System;
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn : MonoBehaviour
{
    //public GameObject Box;
    public Transform ZeroXYZ;
    public int yHeight=3;
    public int xWidth=300;

    public  GameObject[] Enviroment;
    //private GameObject[] Enviroment = new GameObject[8];

    private int randomBox;




    // Start is called before the first frame update
    void Start()
    {
        RandomBox();
        //randomBox = Random.Range(0, Enviroment.Length);








        //BoxSpawn();
        //BoxSpawn2();
        WorldCreate();
        //Enviroment[]= GameObject.FindGameObjectsWithTag("Enemy");
    }

    private void RandomBox()
    {

        //Enviroment[0] = GameObject.Find("BBB");
        //Enviroment[1] = GameObject.Find("B2-2");
        //Enviroment[2] = GameObject.Find("RescourceTree");
        //Enviroment[3] = GameObject.Find("RescourceMetall");
        //Enviroment[4] = GameObject.Find("RescourceOil");
        //Enviroment[5] = GameObject.Find("B2-3");
        //Enviroment[6] = GameObject.Find("B2-4");
        //Enviroment[7] = GameObject.Find("B2-5");
    }

    private void WorldCreate()
    {

        int y = 0;

        for ( int i = 0; i < xWidth; i += 3)
        {

            if (i == 3) { Instantiate(Enviroment[0], ZeroXYZ); }


            randomBox = Random.Range(0, Enviroment.Length);
            var cell = Instantiate(Enviroment[randomBox], ZeroXYZ);

            
            if (i % 2 == 0) { y += Random.Range(-1, 2); }

            cell.transform.localPosition = new Vector3(i, y, 0);


        }
    }

    private void BoxSpawn()
    {
        //create spawning inside players big sphere collider, for lire 10 boxes forward



        //int y = 0;

        //for (int i = 0; i < xWidth; i+=3)
        //{
        //    var cell = Instantiate(Box, ZeroXYZ);
        //    if (i % 2 == 0) { y += Random.Range(-1, 2); }
            
        //    cell.transform.localPosition = new Vector3(i, y, 0);

        //}





    }

    private void BoxSpawn2()
    {
        //create spawning inside players big sphere collider, for lire 10 boxes forward



        //  int groundHeight = 30;

        //for (int i = 0; i < xWidth; i += 3)
        //{
        //    if (i % 2 == 0) { groundHeight += Random.Range(-1, 2); }

        //    for (int y = groundHeight; y >0; y--)
        //    {

        //        var cell = Instantiate(Box, ZeroXYZ);
        //        //cell.transform.localPosition = new Vector3(i, 3, 0);
        //        cell.transform.localPosition = new Vector3(i,y, 0);
        //    }

        //}





    }
//xxxxsssssssfdssdfewfewfe








    // Update is called once per frame
    void Update()
    {




    }
}
