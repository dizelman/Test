using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicScene : MonoBehaviour
{
    public bool workers = true;
    public GameObject WorkersObg;
    [Space(5)]
    public bool ground = true;
    public GameObject GroundObg;
    [Space(5)]
    public bool truck = true;
    public GameObject TruckObg;

    void Start()
    {
        WorkersObg.SetActive(workers);
        GroundObg.SetActive(ground);
        TruckObg.SetActive(truck);
    }

    
   
}
