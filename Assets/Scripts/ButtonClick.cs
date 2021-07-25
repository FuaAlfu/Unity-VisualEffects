using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2021.7.25
/// </summary>

public class ButtonClick : MonoBehaviour
{
    [SerializeField]
    AudioClip hoverFVX, clickFVX;

    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Hover()
    {
        audioSource.PlayOneShot(hoverFVX);
    }

    public void Click()
    {
        audioSource.PlayOneShot(clickFVX);
    }
}
