using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class CustomCommands : MonoBehaviour
{
    public GameObject sprite;

    public AudioSource soundSource;

    public AudioClip wetSplat;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    [YarnCommand("revealSprite")]
    public void RevealSprite()
    {
        sprite.SetActive(true);
    }

    [YarnCommand("hideSprite")]
    public void HideSprite()
    {
        sprite.SetActive(false);
    }

    [YarnCommand("playSplat")]
    public void PlaySplat()
    {
        soundSource.PlayOneShot(wetSplat);
    }

}
