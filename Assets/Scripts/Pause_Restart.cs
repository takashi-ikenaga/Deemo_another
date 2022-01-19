using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class Pause_Restart : MonoBehaviour
{
  public PlayableDirector playableDirector;
  [SerializeField] GameObject PausePanel = default;

  public void puase()
  {
    playableDirector.Pause();
  }
  public void restart()
  {
    playableDirector.Resume();
    PausePanel.SetActive(false);
  }
}
