using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabEffect : MonoBehaviour
{
   public float deleteTime;
   public GameObject particleObject;

    void Start()
    {
        Instantiate(particleObject, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
        Destroy(gameObject, deleteTime);
    }
}
