using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instant1Right : MonoBehaviour
{
    [SerializeField] Gene1Right gene1Right = default;

    // Start is called before the first frame update
    public void NoteEvent1()
    {
        gene1Right.SpawnNote(new Vector3(3,72,150));
    }
    public void NoteEvent2()
    {
        gene1Right.SpawnNote(new Vector3(13,72,150));
    }
    public void NoteEvent3()
    {
        gene1Right.SpawnNote(new Vector3(23,72,150));
    } 
    public void NoteEvent4()
    {
        gene1Right.SpawnNote(new Vector3(34,72,150));
    } 
   
}