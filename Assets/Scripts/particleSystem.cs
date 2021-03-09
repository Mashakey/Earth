using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class particleSystem : MonoBehaviour
{
    private ParticleSystem ps;
   
    public GameObject Slider1;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        Slider sl = Slider1.GetComponent<Slider>();

        ps = GetComponent<ParticleSystem>();

        if (sl.value >= 1)
            ps.Stop();
        else
            ps.Play();
    }
    }
