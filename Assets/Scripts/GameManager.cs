using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Playables;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI countDownText = default;
    [SerializeField] KeyCode keycode;
    [SerializeField] GameObject PausePanel = default;

    [SerializeField] TextMeshProUGUI comboText = default;
    [SerializeField] TextMeshProUGUI hitText = default;
    [SerializeField] TextMeshProUGUI goodText = default;
    [SerializeField] TextMeshProUGUI maxcomboText = default;

    [SerializeField] PlayableDirector playableDirector;

    public static int maxcomboresult =0;
    public static int notenumber =0;
    public static int noteamount =0;
    public static int goodnote =0;
    
    public static int maxcombo =0;
    public static int macombo =0;

    void Start()
    {
        Application.lowMemory += OnLowMemory;
        Resources.UnloadUnusedAssets();
        System.GC.Collect();
        StartCoroutine(GameMain());
    }

    private void Update()
    {
        if(Input.GetKeyDown(keycode))
        {
           PausePanel.SetActive(true);
           playableDirector.Pause();
        }

        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    IEnumerator GameMain()
    {
        countDownText.text ="3";
        yield return new WaitForSeconds(1);
        countDownText.text ="2";
        yield return new WaitForSeconds(1);
        countDownText.text ="1";
        yield return new WaitForSeconds(1);
        countDownText.text =" ";
        yield return new WaitForSeconds(0.5f);
        playableDirector.Play();
    }
    // Update is called once per frame
    public void ResetCombo()
    {
        macombo = maxcombo;
        maxcombo=0;
        comboText.text =" ";
        if(maxcomboresult <macombo)
        {
            maxcomboresult = macombo;
        }        
        maxcomboText.text = maxcomboresult.ToString(); 
    }

    public void Addcombo(int combo)
    {
        if(combo == 1)
        {
        maxcombo += combo;
        comboText.text = maxcombo.ToString();
        }
    }

    public void AddNotes(int note)
    {
        notenumber +=note;
        hitText.text = notenumber.ToString();
    }

    public void Addamount(int note)
    {
        noteamount +=note;  
    }

     public void AddGood(int note)
    {
        goodnote +=note; 
        goodText.text = goodnote.ToString(); 
    }


    public static int MaxComboGet()
    {
        return maxcomboresult;    
    }

    public static int NoteNumberGet()
    {
        return notenumber;    
    }

    public static int NoteamountGet()
    {
        return noteamount;    
    }

    public static int GoodNoteGet()
    {
        return goodnote;    
    }


    public void OnEndEventA()
    {
        SceneManager.LoadScene("ResultScene_Anima");
    }

    public void OnRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

     private void OnLowMemory()
    {
        Debug.Log("メモリー不足を検知");
    }

}
