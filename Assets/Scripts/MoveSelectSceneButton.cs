using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveSelectSceneButton : MonoBehaviour
{
     public void ButtonClicked ()
    {
        SceneManager.LoadScene("SelectScene");
　　}
}
