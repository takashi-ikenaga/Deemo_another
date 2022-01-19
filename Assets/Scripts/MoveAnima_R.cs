using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveAnima_R : MonoBehaviour
{
    public static int st_a_r=0;
    public void OnButtonClicked()
    {
        SceneManager.LoadScene("Anima_play_R");
    }
    public static int STreturn()
    {
        return st_a_r =1;
    }
}
