using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Result_Buttons_Entrance : MonoBehaviour
{
 [SerializeField] TextMeshProUGUI notehitsText = default;
    [SerializeField] TextMeshProUGUI maxcomboText = default;
    //[SerializeField] TextMeshProUGUI percentageText = default;
    
    // Start is called before the first frame update
    void Start()
    {
        int maxcombo = GameManager.MaxComboGet();
        int notehits = GameManager.NoteNumberGet();
        notehitsText.text = notehits.ToString();
        maxcomboText.text = maxcombo.ToString();
    }

}
