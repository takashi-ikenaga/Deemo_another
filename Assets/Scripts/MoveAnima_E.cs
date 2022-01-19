using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveAnima_E : MonoBehaviour
{
    public static int st_a_e=0;
    
    public void OnButtonClicked()
    {
        SceneManager.LoadScene("Anima_Play");
    }
    public static int STreturn()
    {
        return st_a_e=1;
    }
}
