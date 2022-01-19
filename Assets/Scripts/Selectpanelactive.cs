using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectpanelactive : MonoBehaviour
{

    public GameObject sphereObject;
    public GameObject cubeObject;
 
    void Start()
    {
        sphereObject.SetActive(false);
        cubeObject.SetActive(false);
        StartCoroutine("SphereAppear");
        StartCoroutine("CubeAppear");
    }
 
    IEnumerator SphereAppear()
    {
        yield return new WaitForSeconds(8.0f);
        sphereObject.SetActive(true);
        
    }
 
     IEnumerator CubeAppear()
     {
        yield return new WaitForSeconds(8.0f);
        cubeObject.SetActive(true);
     }
}
