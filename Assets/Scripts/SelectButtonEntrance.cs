using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectButtonEntrance : MonoBehaviour
{
    [SerializeField] GameObject PausePanel = default;

    public void ButtonClicked ()
    {
        PausePanel.SetActive(true);
　　}
}
