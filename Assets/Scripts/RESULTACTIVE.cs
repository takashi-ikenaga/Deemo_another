using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RESULTACTIVE : MonoBehaviour
{
    public GameObject amountText;
    public GameObject hitText;
    public GameObject percentObject;
    public GameObject titleObject;
    public GameObject selectObject;
    public GameObject retryObject;
    public GameObject comboObject;
    public GameObject slashObject;
    public GameObject highObject;

    void Start()
    {
        amountText.SetActive(false);
        hitText.SetActive(false);
        percentObject.SetActive(false);
        titleObject.SetActive(false);
        selectObject.SetActive(false);
        retryObject.SetActive(false);
        comboObject.SetActive(false);
        StartCoroutine("amountAppear");
        StartCoroutine("hitAppear");
        StartCoroutine("percentAppear");
        StartCoroutine("titleAppear");
        StartCoroutine("selectAppear");
        StartCoroutine("retryAppear");
        StartCoroutine("comboAppear");
        slashObject.SetActive(false);
        StartCoroutine("slashAppear");
        highObject.SetActive(false);
        StartCoroutine("highAppear");
    }
 
    IEnumerator amountAppear()
    {
        yield return new WaitForSeconds(4.0f);
        amountText.SetActive(true);
    }
    IEnumerator slashAppear()
    {
        yield return new WaitForSeconds(4.25f);
        slashObject.SetActive(true);
    }

    IEnumerator hitAppear()
    {
        yield return new WaitForSeconds(4.5f);
        hitText.SetActive(true);
    }

    IEnumerator comboAppear()
     {
        yield return new WaitForSeconds(5.0f);
        comboObject.SetActive(true);
     }

    IEnumerator percentAppear()
    {
        yield return new WaitForSeconds(5.5f);
        percentObject.SetActive(true);
    }
    IEnumerator titleAppear()
    {
        yield return new WaitForSeconds(6.5f);
        titleObject.SetActive(true);   
    }
 
     IEnumerator selectAppear()
     {
        yield return new WaitForSeconds(6.5f);
        selectObject.SetActive(true);
     }
     IEnumerator retryAppear()
     {
        yield return new WaitForSeconds(6.5f);
        retryObject.SetActive(true);
     }
    
     IEnumerator highAppear()
     {
        yield return new WaitForSeconds(6.0f);
     }
}
