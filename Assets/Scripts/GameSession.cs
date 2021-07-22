using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    [Header("time cfg")]
    [SerializeField]
    float timeAmount;

    [SerializeField]
    float timeToAdd;

    [SerializeField]
    Text time;
    // Start is called before the first frame update
    void Start()
    {
        timeAmount = 0;
        timeToAdd = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    void Timer()
    {
        time.text = (int)timeAmount + "";
        timeAmount += timeToAdd * Time.deltaTime;
    }
}
