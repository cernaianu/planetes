using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetBrowser : MonoBehaviour
{
    public List<GameObject> planets = null;
    public AudioSource sfx;

    public void activatePlanet(string key)
    {
        sfx.Play();
        foreach(GameObject planet in planets)
        {
            if (planet.tag.Equals(key))
                planet.SetActive(true);
            else planet.SetActive(false);
        }
    }
}
