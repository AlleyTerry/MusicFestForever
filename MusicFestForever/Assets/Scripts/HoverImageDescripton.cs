using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverImageDescripton : MonoBehaviour
{
    public GameObject DescriptionImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnMouseEnter()
    {
        DescriptionImage.SetActive(true);
        
        Debug.Log("you are hovering over me");
    }
    
    private void OnMouseExit()
    {
        DescriptionImage.SetActive(false);
    }
}

