using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class falseprefab : MonoBehaviour
{
   [SerializeField] float radius;
   [SerializeField] GameManager gameManager = default;

    public void Update()
    {
        RaycastHit2D[] hits2D = Physics2D.CircleCastAll(transform.position, radius, Vector3.zero);
            if (hits2D.Length ==0)
            {
                return;
            }
            List<RaycastHit2D> raycastHit2Ds = hits2D.ToList();
            raycastHit2Ds.Sort((a,b) => (int)(a.transform.position.y - b.transform.position.y));
            RaycastHit2D hit2D = raycastHit2Ds[0];
        if(hit2D)
        { 
            hit2D.collider.gameObject.SetActive(false);
            gameManager.ResetCombo();
            gameManager.Addcombo(0);
        }
    }

    void OnDrawGizmosSelected()
    {
      Gizmos.color =Color.red;
      Gizmos.DrawSphere(transform.position,radius);   
    }

}
