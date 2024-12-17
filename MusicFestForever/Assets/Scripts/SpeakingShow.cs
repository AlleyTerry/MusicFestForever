using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SpeakingShow : MonoBehaviour
{
    public GameObject character;
    public Vector3 endCharacterPos;
    public Vector3 startingCharacterPos;
    public float duration = 3.0f;
    public float elapsedTime;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime = Time.deltaTime;
    }
    [YarnCommand ("TaraMove")]
    public void TaraMove()
    {
        character = GameObject.Find("Tara");
        startingCharacterPos = character.transform.position;
        endCharacterPos = new Vector3(character.transform.position.x, character.transform.position.y, character.transform.position.z -3);
        
        float percentage = elapsedTime / duration;
        character.transform.position = Vector3.Lerp(startingCharacterPos, endCharacterPos, 0.5f);
       // character.transform.position = Vector3.Lerp(endCharacterPos, startingCharacterPos - new Vector3(0,5,0), 0.5f);
    }
    
    
    [YarnCommand("JennieMove")]
    public void JennieMove()
    {
        character = GameObject.Find("Jennie");
        startingCharacterPos = character.transform.position;
        endCharacterPos = new Vector3(character.transform.position.x, character.transform.position.y , character.transform.position.z-3);
        //elapsedTime = Time.deltaTime;
        float percentage = elapsedTime / duration;
        character.transform.position = Vector3.Lerp(startingCharacterPos, endCharacterPos, 0.5f);
       // character.transform.position = Vector3.Lerp(endCharacterPos, startingCharacterPos - new Vector3(0,5,0), 0.5f);
       
    }
    
    [YarnCommand ("VolunteerMove")]
    public void VolunteerMove()
    {
        character = GameObject.Find("Volunteer");
        startingCharacterPos = character.transform.position;
        endCharacterPos = new Vector3(character.transform.position.x, character.transform.position.y, character.transform.position.z-3);
        elapsedTime = Time.deltaTime;
        float percentage = elapsedTime / duration;
        character.transform.position = Vector3.Lerp(startingCharacterPos, endCharacterPos, 0.5f);
       // character.transform.position = Vector3.Lerp(endCharacterPos, startingCharacterPos - new Vector3(0,5,0), 0.5f);
    }
    
    [YarnCommand ("GlitterglueMove")]
    public void GlitterglueMove()
    {
        character = GameObject.Find("Glitterglue");
        startingCharacterPos = character.transform.position;
        endCharacterPos = new Vector3(character.transform.position.x, character.transform.position.y, character.transform.position.z-3);
        elapsedTime = Time.deltaTime;
        float percentage = elapsedTime / duration;
        character.transform.position = Vector3.Lerp(startingCharacterPos, endCharacterPos, 0.5f);
    }
    
    [YarnCommand ("FishkingMove")]
    public void FishkingMove()
    {
        character = GameObject.Find("fishking_0");
        startingCharacterPos = character.transform.position;
        endCharacterPos = new Vector3(character.transform.position.x, character.transform.position.y, character.transform.position.z-3);
        elapsedTime = Time.deltaTime;
        float percentage = elapsedTime / duration;
        character.transform.position = Vector3.Lerp(startingCharacterPos, endCharacterPos, 0.5f);
    }
    
    [YarnCommand ("SecurityMove")]
    public void SecurityMove()
    {
        character = GameObject.Find("Security");
        startingCharacterPos = character.transform.position;
        endCharacterPos = new Vector3(character.transform.position.x, character.transform.position.y, character.transform.position.z-3);
        elapsedTime = Time.deltaTime;
        float percentage = elapsedTime / duration;
        character.transform.position = Vector3.Lerp(startingCharacterPos, endCharacterPos, 0.5f);
    }

    
}
