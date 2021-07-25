using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2021.7.20
/// </summary>

public class Controller : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> cubesPositions;

    [SerializeField]
    private GameObject[] particles;

    // Update is called once per frame
    void Update()
    {
       // ParticlesPlay();
    }

    //private void ParticlesPlay()
    //{
    //    if(Input.GetKeyDown(KeyCode.Space))
    //    {
    //        cubesPositions = new List<GameObject>();
    //        for (int i = 0; i < particles.Length; i++)
    //        {
    //           cubesPositions.Add(Instantiate(particles[i]) as GameObject);
    //        }
 
    //    }
    //}
}
