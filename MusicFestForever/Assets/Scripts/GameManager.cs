using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;
using Yarn;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static CustomCommands customCommands;
    public GameObject sprite;
    public GameObject spriteChild;
    //variables
    public InMemoryVariableStorage variableStorage;
    public DialogueRunner dialogueRunner;
    public bool intro = true;
    public bool drinkAttempt = false;
    public bool findJennie = false;
    public bool Glitterglue = false;
    public bool shoelaceMissionStart = false;
    public bool isEaten = false;
    public string sceneName;
    public bool shoelaceGet = false;
    public bool hasPass = false;
    public bool hasFabric = false;
    public bool theEnd = false;
    public bool contrabandBox = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            

        }
        else
        {
            Destroy(gameObject);
            
            
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    [YarnCommand("ShoelaceGet")]
    public bool ShoelaceGet()
    {
        shoelaceGet = true;
        return shoelaceGet;
    }

    [YarnCommand("FabricGet")]
    public bool FabricGet()
    {
        hasFabric = true;
        
        return hasFabric;
    }
    
    [YarnCommand("HasPass")]
    public bool HasPass()
    {
        hasPass = true;
        return hasFabric;
    }
    // Update is called once per frame
    void Update()
    {
        sceneName = SceneManager.GetActiveScene().name;
        variableStorage.SetValue("$shoelaceMissionStart", shoelaceMissionStart);
        variableStorage.SetValue("$isEaten", isEaten);
        variableStorage.SetValue("$hasPass", hasPass);
        variableStorage.SetValue("$hasFabric", hasFabric);

        if (sceneName == "Field" && intro)
        {
                intro = false;
                drinkAttempt = true;
                dialogueRunner.StartDialogue("Intro");
                
        }
        if (sceneName == "Tent" && drinkAttempt)
        {
            drinkAttempt = false;
            findJennie = true;
            dialogueRunner.StartDialogue("drinkAttempt");
                
        }
        if (sceneName == "Field" && findJennie)
        {
            
            findJennie = false;
            Glitterglue = true;
            dialogueRunner.StartDialogue("findJennie");
                
        }
        if (sceneName == "Porta" && Glitterglue)
        {
            
            Glitterglue = false;
            isEaten = true;
            dialogueRunner.StartDialogue("Glitterglue");
                
        }

        if (sceneName == "Tent" && isEaten )
        {
            isEaten = false;
            contrabandBox = true;
            dialogueRunner.StartDialogue("ShoelaceMissionStart");
            
        }

        if (sceneName == "Porta" && contrabandBox)
        {
            sprite = GameObject.Find("fabricParent"); 
            spriteChild = sprite.transform.GetChild(0).gameObject;
            spriteChild.SetActive(true);
            contrabandBox = false;
        }
        
        if (sceneName == "Tent" && hasFabric  )
        {
            hasFabric = false;
            shoelaceMissionStart = true;
            dialogueRunner.StartDialogue("ShoelaceBegin");
        }
        if (sceneName == "Tent" && shoelaceGet )
        {
            shoelaceGet = false;
            shoelaceMissionStart = false;
            dialogueRunner.StartDialogue("ShoelaceMissionStart");
            hasPass = true;
        }

        if (sceneName == "Porta" )
        {
            
        }

        if (sceneName == "Porta" && hasPass)
        {
            hasPass = false;
            theEnd = true;
            dialogueRunner.StartDialogue("SecurityIntro");
        }

        if (sceneName == "Backstage" && theEnd)
        {
            theEnd = false;
            dialogueRunner.StartDialogue("JennieFishKing");
        }

    }
}
