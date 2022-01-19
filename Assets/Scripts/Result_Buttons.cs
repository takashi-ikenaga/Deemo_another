using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Result_Buttons : MonoBehaviour
{   
    [SerializeField] TextMeshProUGUI notehitsText = default;
    [SerializeField] GameObject scoreText = default;
    [SerializeField] TextMeshProUGUI maxcomboText = default;
    [SerializeField] TextMeshProUGUI amountText = default;
    [SerializeField] TextMeshProUGUI percentageText = default;

    private string key1 = "HIGH SCORE";
    private string key2 = "HIGH SCORE";
    private string key3 = "HIGH SCORE";
    private string key4 = "HIGH SCORE";
    // Start is called before the first frame update
    void Start()
    {
        int maxcombo = GameManager.MaxComboGet();
        int notehits = GameManager.NoteNumberGet();//上側
        int noteamount = GameManager.NoteamountGet();
        int goodnote = GameManager.GoodNoteGet();

        int score_a_r=0;
        int score_a_e=0;
        int score_e_r=0;
        int score_e_e=0;
        int ol_score =0;

        double percentagehit = (((double)notehits/(double)noteamount)*70);
        double percentagecombo = (((double)maxcombo/(double)noteamount)*25);
        double percentagegood = (((double)goodnote/(double)noteamount)*5);

        double percentageall= percentagecombo+percentagegood+percentagehit;

        float percentages = (float)percentageall;
        
        int st_a_r1 = MoveAnima_R.STreturn();
        int st_a_e1 = MoveAnima_E.STreturn();
        int st_e_r1 = MoveEntrance_R.STreturn();
        int st_e_e1 = MoveEntrance_E.STreturn();

        notehitsText.text = notehits.ToString();
        maxcomboText.text = maxcombo.ToString();
        amountText.text = noteamount.ToString();
        percentageText.text = percentages.ToString("F");

        scoreText.SetActive(false);
  
        if(st_a_r1 == 1)
        {
            ol_score = (int)percentages;
            if(ol_score > score_a_r)
            {
             score_a_r =ol_score;
             scoreText.SetActive(true);
             PlayerPrefs.SetInt (key1,score_a_r);
             PlayerPrefs.Save ();
            }
             ol_score =0;
             st_a_r1 =0;
        }

        else if(st_a_e1 == 1)
        {
            ol_score =(int)percentages;
            if(ol_score > score_a_e)
            {
             score_a_e =ol_score;
             scoreText.SetActive(true);
             PlayerPrefs.SetInt (key2,score_a_e);
             PlayerPrefs.Save ();
            }
            ol_score =0;
             st_a_e1 =0;
        }
        else if(st_e_r1 == 1)
        {
            ol_score =(int)percentages;
            if(ol_score > score_e_r)
            {
             score_e_r =ol_score;
             scoreText.SetActive(true);
             PlayerPrefs.SetInt (key3,score_e_r);
             PlayerPrefs.Save ();
            }
            ol_score =0;
             st_e_r1 =0;
        }
        else if(st_e_e1 == 1)
        {
            ol_score =(int)percentages;
            if(ol_score > score_e_e)
            {
             score_e_e =ol_score;
             scoreText.SetActive(true);
             PlayerPrefs.SetInt (key4,score_e_e);
             PlayerPrefs.Save ();
            }
            ol_score =0;
            st_e_e1 =0;
        }
    }

}
