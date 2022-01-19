using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveHomeSceneButton : MonoBehaviour
{
     public void ButtonClicked () 
    {
        SceneManager.LoadScene("TitleScene");
　　}
}
