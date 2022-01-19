using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Playables;

public class MoveEntrance_R : MonoBehaviour
{
    public static int st_e_r =0;

    void Start()
    {
        st_e_r=1;
    }
    
    public void OnButtonClicked()
    {
        SceneManager.LoadScene("Entrance_Play_R");
    }

    public static int STreturn()
    {
        return st_e_r;
    }
}
