using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayText : MonoBehaviour
{
    
    private bool isDisplaying = false;
    public Text planetText; 
    private void OnMouseOver()
    {
        isDisplaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDisplaying)
        {
            planetText.enabled = true;
            planetText.text =  this.tag;
        }
        else planetText.enabled = false;
        isDisplaying = false;
        

    }
}
