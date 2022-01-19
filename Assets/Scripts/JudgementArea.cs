using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;


public class JudgementArea : MonoBehaviour
{
    [SerializeField] float radius;
    [SerializeField] GameManager gameManager = default;
    [SerializeField] KeyCode keycode;
    //[SerializeField] GameObject particle;

    [SerializeField] GameObject PausePanel = default;
    [SerializeField] GameObject GOODPrefab;
    [SerializeField] GameObject NICEPrefab;
    [SerializeField] GameObject BADPrefab;
    /*[SerializeField] GameObject line1;
    [SerializeField] GameObject line2;
    [SerializeField] GameObject line3;
    [SerializeField] GameObject line4;
    [SerializeField] GameObject line5;
    [SerializeField] GameObject line6;
    [SerializeField] GameObject line7;
    [SerializeField] GameObject line8;
    */
    [SerializeField] PlayableDirector playableDirector;
    
    public void Update()
    {
        if(Input.GetKeyDown(keycode))
        {
            Debug.Log("ffff");
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
                float distance =Mathf.Abs(hit2D.transform.position.y- transform.position.y);
                if(distance < 2)
                {   Debug.Log("ffff");
                    gameManager.Addcombo(1);
                    gameManager.AddNotes(1);
                    gameManager.AddGood(1);
                    Instantiate(GOODPrefab,hit2D.transform.position, Quaternion.identity);
                    //Instantiate(particle,hit2D.transform.position,Quaternion.identity);
                }
                else if(distance < 4 && 2 <= distance)
                {
                    gameManager.Addcombo(1);
                    gameManager.AddNotes(1);
                    Instantiate(NICEPrefab,hit2D.transform.position, Quaternion.identity);
                }
                else
                {   gameManager.ResetCombo();
                    gameManager.Addcombo(0);
                    Instantiate(BADPrefab,hit2D.transform.position, Quaternion.identity);
                }
                hit2D.collider.gameObject.SetActive(false);
            }
        }
        else if(transform.position.y<-33)
        {
            gameManager.ResetCombo();
            gameManager.Addcombo(0);
        }
        
    }
    
    public void OnEnable() {
       MidiMaster.noteOnDelegate += NoteOn;
       MidiMaster.noteOffDelegate += NoteOff;
    }

    public void OnDisable() {
       MidiMaster.noteOnDelegate -= NoteOn;
       MidiMaster.noteOffDelegate -= NoteOff;
    }



    public void NoteOn(MidiChannel channel, int note, float velocity) {
     
        if(note <55 && note >44)
        {
            RaycastHit2D[] hits2D = Physics2D.CircleCastAll(transform.position, radius, Vector3.zero);
            if (hits2D.Length ==0)
            {
                return;
            }
            List<RaycastHit2D> raycastHit2Ds = hits2D.ToList();
            raycastHit2Ds.Sort((a,b) => (int)(a.transform.position.y - b.transform.position.y));
            // 0番目の要素を消す
            RaycastHit2D hit2D = raycastHit2Ds[0];

            if(hit2D)
            {
                float distance =Mathf.Abs(hit2D.transform.position.y- transform.position.y);
                if(distance < 2)
                {
                    gameManager.Addcombo(1);
                    gameManager.AddNotes(1);
                    Instantiate(GOODPrefab,hit2D.transform.position, Quaternion.identity);
                }
                else if(distance < 5)
                {
                    gameManager.Addcombo(1);
                     gameManager.AddNotes(1);
                    Instantiate(NICEPrefab,hit2D.transform.position, Quaternion.identity);
                }
                else
                {    gameManager.ResetCombo();
                    gameManager.Addcombo(0);
                     gameManager.AddNotes(1);
                    Instantiate(BADPrefab,hit2D.transform.position, Quaternion.identity);
                }
                hit2D.collider.gameObject.SetActive(false);
            }
        }

        if(note >63 && note < 75)
        {
            RaycastHit2D[] hits2D = Physics2D.CircleCastAll(transform.position, radius, Vector3.zero);
            if (hits2D.Length ==0)
            {
                return;

            }
            List<RaycastHit2D> raycastHit2Ds = hits2D.ToList();
            raycastHit2Ds.Sort((a,b) => (int)(a.transform.position.y - b.transform.position.y));
            // 0番目の要素を消す
            RaycastHit2D hit2D = raycastHit2Ds[0];

            if(hit2D)
            {
                float distance =Mathf.Abs(hit2D.transform.position.y- transform.position.y);
                if(distance < 2)
                {
                   
                    gameManager.Addcombo(2);
                    gameManager.AddNotes(1);
                    Instantiate(GOODPrefab,hit2D.transform.position, Quaternion.identity);
                }
                else if(distance < 5)
                {
                 
                    gameManager.Addcombo(2);
                     gameManager.AddNotes(1);
                    Instantiate(NICEPrefab,hit2D.transform.position, Quaternion.identity);
                }
                else
                {
                    gameManager.Addcombo(0);
                     gameManager.AddNotes(1);
                     Instantiate(BADPrefab,hit2D.transform.position, Quaternion.identity);
                }
                hit2D.collider.gameObject.SetActive(false);
            }
        }

        if(note ==60)
        {
           PausePanel.SetActive(true);
           playableDirector.Pause();
        }

        if(note <40 && note >35)
        {
            RaycastHit2D[] hits2D = Physics2D.CircleCastAll(transform.position, radius, Vector3.zero);
            if (hits2D.Length ==0)
            {
                return;
            }
            List<RaycastHit2D> raycastHit2Ds = hits2D.ToList();
            raycastHit2Ds.Sort((a,b) => (int)(a.transform.position.y - b.transform.position.y));
            // 0番目の要素を消す
            RaycastHit2D hit2D = raycastHit2Ds[0];

            if(hit2D)
            {
                float distance =Mathf.Abs(hit2D.transform.position.y- transform.position.y);
                if(distance < 2)
                {
                    gameManager.Addcombo(1);
                    gameManager.AddNotes(1);
                    Instantiate(GOODPrefab,hit2D.transform.position, Quaternion.identity);
                }
                else if(distance < 5)
                {
                    gameManager.Addcombo(1);
                     gameManager.AddNotes(1);
                    Instantiate(NICEPrefab,hit2D.transform.position, Quaternion.identity);
                }
                else
                {    gameManager.ResetCombo();
                    gameManager.Addcombo(0);
                     gameManager.AddNotes(1);
                    Instantiate(BADPrefab,hit2D.transform.position, Quaternion.identity);
                }
                hit2D.collider.gameObject.SetActive(false);
            }
        }

        if(note ==44)
        {
           PausePanel.SetActive(true);
           playableDirector.Pause();
        }
    }

   public void NoteOff(MidiChannel channel, int note) {
       Debug.Log("NoteOff: " + channel + ", " + note);
   }

    void OnDrawGizmosSelected()
    {
      Gizmos.color =Color.red;
      Gizmos.DrawSphere(transform.position,radius);   
    }
}

