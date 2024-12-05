using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Yarn.Unity;

public class VideoPlay : MonoBehaviour
{
    public VideoClip eels;

    public VideoPlayer eelsSource;

    public GameObject eelsVideoImage;

    public GameObject eelsVideoRawImage;
    // Start is called before the first frame update
    void Start()
    {
        eelsVideoImage.SetActive(false);
        eelsVideoRawImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [YarnCommand("playEels")]
    public void PlayEels()
    {
        eelsVideoImage.SetActive(true);
        eelsVideoRawImage.SetActive(true);
        eelsSource.Play();
    }

    [YarnCommand("stopEels")]

    public void StopEels()
    {
        eelsVideoImage.SetActive(false);
        eelsVideoRawImage.SetActive(false);
    }
    
}
