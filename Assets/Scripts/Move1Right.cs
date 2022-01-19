using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1Right : MonoBehaviour
{
 
    float speed;
    
    
    void Start()
    {
        speed =69;
        //StartCoroutine ("ScaleUp"); 
    }

    void Update()
    {
      
        transform.Translate((speed * Time.deltaTime)/16,-speed * Time.deltaTime,-speed * Time.deltaTime);
    }

    
}
