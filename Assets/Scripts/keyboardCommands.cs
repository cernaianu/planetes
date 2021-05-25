using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardCommands : MonoBehaviour
{
    [SerializeField]
    private lightRotator lr;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.L))
        {
            if(lr.speed <= 450)
                lr.speed++;
        }
        else if(lr.speed >= 10)
        {
            lr.speed = lr.speed - 5;
        }
    }
}
