using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class timegage : MonoBehaviour
{  /// タイマーのゲージ 残り時間に応じて fillAmount を操作
    [SerializeField] Image timerGauge;
    [SerializeField] KeyCode keycode;
    [SerializeField] PlayableDirector playableDirector;
    float f;
 
    // Start is called before the first frame update
    void Start()
    {
        // ゲージを0にする
        timerGauge.fillAmount = 0f;
 
    }
 
    // Update is called once per frame
    void Update()
    {
        if (f < 126)
        {
            if(Input.GetKeyDown(keycode))
            {
                playableDirector.Pause();
            }
            // ゲージに0.01を足していく
            timerGauge.fillAmount += 0.00793651f *Time.deltaTime;
        }
    }
}