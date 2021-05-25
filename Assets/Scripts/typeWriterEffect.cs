using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class typeWriterEffect : MonoBehaviour
{

    public float speed = 0.1f;

    public string fullText;
    private string currentText="";


    
    private void OnEnable()
    {
        fullText = this.GetComponent<Text>().text;
        StartCoroutine(showText());
    }

    private void Update()
    {
        
    }
    IEnumerator showText()
    {
        for(int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(speed);
        }
    }
    
}
