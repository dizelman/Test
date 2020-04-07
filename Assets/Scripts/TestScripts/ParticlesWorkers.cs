using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesWorkers : MonoBehaviour
{
    public ParticleSystem sparks;
    public ParticleSystem smoke;


    public void PlaySparks()
    {
        sparks.Play();
    }

    public void PlaySmoke()
    {
        smoke.Play();
    }
    public void StopSmoke()
    {
        smoke.Stop();
    }
}
