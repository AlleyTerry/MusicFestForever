using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class ButtonCommands : MonoBehaviour
{
    public Button leftButton;

    public Button rightButton;
    // Start is called before the first frame update
    void Start()
    {
        leftButton.gameObject.SetActive(false);
        rightButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [YarnCommand("enableLeft")]
    public void EnableLeftButton()
    {
        leftButton.gameObject.SetActive(true);
    }

    [YarnCommand("enableRight")]
    public void EnableRightButton()
    {
        rightButton.gameObject.SetActive(true);
    }

    [YarnCommand("disableLeft")]
    public void DisableLeftButton()
    {
        leftButton.gameObject.SetActive(false);
    }

    [YarnCommand("disableRight")]
    public void DisableRightButton()
    { 
        rightButton.gameObject.SetActive(false);   
    }
}
