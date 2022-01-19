using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gene1Right : MonoBehaviour
{
    [SerializeField] ObjectPool objectPool;
    [SerializeField] GameManager gameManager = default;
    
    private void Awake()
    {
        objectPool.CreatePool(24);
    }

    public void SpawnNote(Vector3 pos)
    {
        gameManager.Addamount(1);
        objectPool.GetObj(pos);
    }
}