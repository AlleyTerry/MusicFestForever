using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class CustomCommands : MonoBehaviour
{
    public GameObject sprite;
    public GameObject lightersprite;

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
    [YarnCommand("deleteSprite")]
    public void DeleteSprite()
    {
        Destroy(sprite);
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
    
     [YarnCommand("deletelighterSprite")]
     public void DeleteLighterSprite()
     {
         Destroy(lightersprite);
     }   
    
    [YarnCommand("reveallighterSprite")]
    public void RevealLighterSprite()
    {
        lightersprite.SetActive(true);
    }
    
    [YarnCommand("hidelighterSprite")]
    public void HideLighterSprite()
    {
        lightersprite.SetActive(false);
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
