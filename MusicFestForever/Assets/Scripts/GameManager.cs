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
    public bool shoelaceMissionStart = false;
    public bool isEaten = true;
    public string sceneName;
    public bool shoelaceGet = false;

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

    // Update is called once per frame
    void Update()
    {
        sceneName = SceneManager.GetActiveScene().name;
        variableStorage.SetValue("$shoelaceMissionStart", shoelaceMissionStart);
        variableStorage.SetValue("$isEaten", isEaten);

        if (sceneName == "Tent" && isEaten )
        {
            isEaten = false;
            shoelaceMissionStart = true;
            dialogueRunner.StartDialogue("ShoelaceMissionStart");
        }
        if (sceneName == "Tent" && shoelaceGet )
        {
            shoelaceGet = false;
            shoelaceMissionStart = false;
            dialogueRunner.StartDialogue("ShoelaceMissionStart");
        }
        
    }
}
