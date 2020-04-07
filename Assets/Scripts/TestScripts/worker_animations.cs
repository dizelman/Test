using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worker_animations : MonoBehaviour
{
    public bool pick_ = false;
    public bool flower_ = false;
    public bool tree_ = false;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

   
    void Update()
    {
        Pick();
        Flower();
        Tree();
    }

    void Pick()
    {
        if (pick_)
        {
            flower_ = false;
            tree_ = false;
            anim.SetBool("pick", pick_);
        }
    }

    void Flower()
    {
        if (flower_)
        {
            pick_ = false;
            tree_ = false;
            anim.SetBool("flower", flower_);
        }
    }

    void Tree()
    {
        if (tree_)
        {
            pick_ = false;
            flower_ = false;
            anim.SetBool("tree", tree_);
        }
    }
}
