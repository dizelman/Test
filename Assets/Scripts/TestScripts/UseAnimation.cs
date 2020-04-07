using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseAnimation : MonoBehaviour
{
    public bool useAnimations = false;//включить анимации или пусть будет статичное
    public GameObject[] obg;
    public track_animations tr_animScript;

    void Start()
    {
        if (useAnimations)
        {
            for (int i = 0; i < obg.Length; i++)
            {
                obg[i].SetActive(true);
            }

            tr_animScript.enabled = true;
        }
        else
        {
            for (int i = 0; i < obg.Length; i++)
            {
                obg[i].SetActive(false);
            }

            tr_animScript.enabled = false;
        }
       
    }

   
}
