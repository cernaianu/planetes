using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxSpinner : MonoBehaviour
{
    
    [SerializeField]
    private float rotationSpeed;
    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotationSpeed);
    }
}
