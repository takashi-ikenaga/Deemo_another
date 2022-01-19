using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gene1Left : MonoBehaviour
{
    [SerializeField] Object1Pool object1Pool;
    [SerializeField] GameManager gameManager = default;
    private void Awake()
    {
        object1Pool.CreatePool(22);
    }

    public void SpawnNote(Vector3 pos)
    {
        gameManager.Addamount(1);
        object1Pool.GetObj(pos);
    }
}