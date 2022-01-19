using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class SelectButtonAnima : MonoBehaviour
{
       [SerializeField] GameObject PausePanel = default;
       
      public void ButtonClicked ()
    {
      PausePanel.SetActive(true);
    }
}
