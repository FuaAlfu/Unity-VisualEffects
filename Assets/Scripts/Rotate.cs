using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2021.8.14
/// </summary>

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private float speed = 40.9f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
