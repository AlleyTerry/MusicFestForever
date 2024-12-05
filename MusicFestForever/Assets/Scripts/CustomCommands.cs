using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class CustomCommands : MonoBehaviour
{
    public GameObject sprite;

    public AudioSource soundSource;

    public AudioClip wetSplat;
    public AudioClip crunch;
    public AudioClip cheer;
    public AudioClip explosion;
    public AudioClip lighter;

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

    [YarnCommand("playCrunch")]
    public void PlayCrunch()
    {
        soundSource.PlayOneShot(crunch);
    }

    [YarnCommand("playCheer")]
    public void PlayCheer()
    {
        soundSource.PlayOneShot(cheer);   
    }

    [YarnCommand("playLighter")]
    public void PlayLighter()
    {
        soundSource.PlayOneShot(lighter);
    }

    [YarnCommand("playExplosion")]
    public void PlayExplosion()
    {
        soundSource.PlayOneShot(explosion);
    }

}
