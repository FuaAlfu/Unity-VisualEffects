using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2021.7.20
/// </summary>
public class CleanUp : MonoBehaviour
{
    [SerializeField]
    private float timer = 2.7f;
    
    void Start()
    {
        Destroy(gameObject, timer);
    }
}
