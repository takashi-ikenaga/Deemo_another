using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Prefabdelete : MonoBehaviour
{
    public float deleteTime;
 
    void Start()
    {
        Destroy(gameObject, deleteTime);
    }
}