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
            shoelaceMissionStart = true;
            dialogueRunner.StartDialogue("ShoelaceMissionStart");
            
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
