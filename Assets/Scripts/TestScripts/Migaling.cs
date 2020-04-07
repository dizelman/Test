using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Migaling : MonoBehaviour
{
    public bool useRotation = true; //крутить?
    public float speedRotation = 3f;
   
    [Space(10)]
    public bool mig = true; //мигать?
    public   SpriteRenderer spr;
    public Vector4 color = new Vector4(255, 192, 0,1);
    public float speedBlinking = 10f;
   


    private void Start()
    {

       
    }


    void Update()
    {

        if (mig)
        {
            float alf = Mathf.Sin(Time.time * speedBlinking);
            spr.color = new Vector4(color.x, color.y, color.z, alf);
        }
        else
        {
            spr.color = new Vector4(color.x, color.y, color.z,color.w);
        }
       

        if(useRotation)
        transform.Rotate(0, speedRotation, 0);
    }
}
