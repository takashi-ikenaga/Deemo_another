using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1Left : MonoBehaviour
{
    float speed;

    void Start()
    {
        speed =23;
        //StartCoroutine ("ScaleUp"); 
    }

    void Update()
    {
        transform.Translate(-(speed * Time.deltaTime)/6,-speed * Time.deltaTime*3,-speed * Time.deltaTime*3);
    }


    /*IEnumerator ScaleUp()
    {
        for(;;)
        {
        for ( float i = 0 ; i < 60; i+=1f ){
            transform.localScale += new Vector3(i/36,i/36,0);
            yield return new WaitForSeconds(0.05f);
            if(i ==45)
            {
            transform.localScale= new Vector3(1/5, 1/5, 1/5);
            i=1;
            }
        
        }
        }
    }*/
}
