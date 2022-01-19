using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveEntrance_E : MonoBehaviour
{
    public static int st_e_e=0;
    
    public void OnButtonClicked()
    {
        SceneManager.LoadScene("Entrance_Play");
    }
    public static int STreturn()
    {
        return st_e_e=1;
    }
}
