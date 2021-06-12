using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn2 : MonoBehaviour
{
    //public GameObject Box;
    public Transform ZeroXYZ;
    public int yHeight = 3;
    public int xWidth = 300;

    //public GameObject[] Enviroment_X;
    private GameObject[] Enviroment_X =new GameObject [10];

    //public GameObject[] Enviroment_Layer2;
    private GameObject GroundLayer2;

    //public GameObject[] Enviroment_Res;
    private GameObject[] Enviroment_Res =new GameObject [14];

    public GameObject DeadGround;


    private int randomBox_X;
    private int[] YRange = new int[] { -3, 0, 3, 3 };
    private int rand_YRange;
    private int LayerResRand4, LayerResRand5, LayerResRand6, LayerResRand7, LayerResRand8, LayerResRand9, LayerResRand10;




    // Start is called before the first frame update
    void Start()
    {
        DeadGround = GameObject.Find("DeadGround");
        AssignObj2Script();
        WorldCreate();

    }

    private void AssignObj2Script()
    {
        Enviroment_X[0] = GameObject.Find("B2-1");
        Enviroment_X[1] = GameObject.Find("B2-2");
        Enviroment_X[2] = GameObject.Find("B2-3");
        Enviroment_X[3] = GameObject.Find("ResTree");
        Enviroment_X[4] = GameObject.Find("ResMetall");
        Enviroment_X[5] = GameObject.Find("ResOil");
        Enviroment_X[6] = GameObject.Find("B2-4");
        Enviroment_X[7] = GameObject.Find("B2-5");
        Enviroment_X[8] = GameObject.Find("B2-6");
        Enviroment_X[9] = GameObject.Find("B2-7");

        GroundLayer2 = GameObject.Find("Ground");

        Enviroment_Res[0] = GameObject.Find("Gr-1");
        Enviroment_Res[1] = GameObject.Find("GrRes-1");
        Enviroment_Res[2] = GameObject.Find("GrRes-2");
        Enviroment_Res[3] = GameObject.Find("Gr-2");
        Enviroment_Res[4] = GameObject.Find("Gr-3");
        Enviroment_Res[5] = GameObject.Find("Gr-4");
        Enviroment_Res[6] = GameObject.Find("Gr-5");
        Enviroment_Res[7] = GameObject.Find("Gr-6");
        Enviroment_Res[8] = GameObject.Find("Gr-7");
        Enviroment_Res[9] = GameObject.Find("Gr-8");
        Enviroment_Res[10] = GameObject.Find("Gr-9");
        Enviroment_Res[11] = GameObject.Find("Gr-10");
        Enviroment_Res[12] = GameObject.Find("Gr-11");
        Enviroment_Res[13] = GameObject.Find("Gr-12");








    }

    private void WorldCreate()
    {

        int y = 0;

        for (int i = 0; i < xWidth; i += 3)
        {

            if (i == 3) { Instantiate(Enviroment_X[0], ZeroXYZ); }


            randomBox_X = Random.Range(0, Enviroment_X.Length);
            rand_YRange = Random.Range(0, YRange.Length);

            LayerResRand4 = Random.Range(0, Enviroment_Res.Length);
            LayerResRand5 = Random.Range(0, Enviroment_Res.Length);
            LayerResRand6 = Random.Range(0, Enviroment_Res.Length);
            LayerResRand7 = Random.Range(0, Enviroment_Res.Length);
            LayerResRand8 = Random.Range(0, Enviroment_Res.Length);
            LayerResRand9 = Random.Range(0, Enviroment_Res.Length);
            LayerResRand10 = Random.Range(0, Enviroment_Res.Length);

            var cell = Instantiate(Enviroment_X[randomBox_X], ZeroXYZ);
            //var cell_2 = Instantiate(Enviroment_Layer2[0], ZeroXYZ);
            var cell_2 = Instantiate(GroundLayer2, ZeroXYZ);
            //var cell_3 = Instantiate(Enviroment_Layer2[0], ZeroXYZ);
            var cell_3 = Instantiate(GroundLayer2, ZeroXYZ);
            var cell_4 = Instantiate(Enviroment_Res[LayerResRand4], ZeroXYZ);
            var cell_5 = Instantiate(Enviroment_Res[LayerResRand5], ZeroXYZ);
            var cell_6 = Instantiate(Enviroment_Res[LayerResRand6], ZeroXYZ);
            var cell_7 = Instantiate(Enviroment_Res[LayerResRand7], ZeroXYZ);
            var cell_8 = Instantiate(Enviroment_Res[LayerResRand8], ZeroXYZ);
            var cell_9 = Instantiate(Enviroment_Res[LayerResRand9], ZeroXYZ);
            var cell_10 = Instantiate(Enviroment_Res[LayerResRand10], ZeroXYZ);
            var Cell_11 = Instantiate(DeadGround, ZeroXYZ);

            //if (i % 2 == 0) { y += Random.Range(-1, 2); }
            if (i % 2 == 0) { y += YRange[rand_YRange]; }

            cell.transform.localPosition = new Vector3(i, y, 0);
            cell_2.transform.localPosition = new Vector3(i, y - 3, 0);
            cell_3.transform.localPosition = new Vector3(i, y - 6, 0);
            cell_4.transform.localPosition = new Vector3(i, y - 9, 0);
            cell_5.transform.localPosition = new Vector3(i, y - 12, 0);
            cell_6.transform.localPosition = new Vector3(i, y - 15, 0);
            cell_7.transform.localPosition = new Vector3(i, y - 18, 0);
            cell_8.transform.localPosition = new Vector3(i, y - 21, 0);
            cell_9.transform.localPosition = new Vector3(i, y - 24, 0);
            cell_10.transform.localPosition = new Vector3(i, y - 27, 0);
            Cell_11.transform.localPosition = new Vector3(i, y - 30, 0);





        }
    }
    //xxxxsssssssfdssdfewfewfe

    // Update is called once per frame
    void Update()
    {




    }
}
