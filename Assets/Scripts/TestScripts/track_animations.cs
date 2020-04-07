using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class track_animations : MonoBehaviour
{

    public bool truck_ = false;
    public bool bobcat_ = false;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        Truck();
        BobCat();
    }

    void Truck()
    {
        if (truck_)
        {
            bobcat_ = false;
            anim.SetBool("truck", truck_);
        }
    }

    void BobCat()
    {
        if (bobcat_)
        {
            truck_ = false;
            anim.SetBool("bobcat", bobcat_);
        }
    }
}
