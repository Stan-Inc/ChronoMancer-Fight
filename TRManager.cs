using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TRManager : MonoBehaviour {
    public float TR;
    public bool TRBool;
    public bool TRused;
    public Image TRImage;
    public const float t = .0166666666666666f;
    // Pls Change this Constant to a more acurate 1/60 fraction
    void Start () {
        TR = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (TR > 8)
        {
            TR = 8;
        }
        if (Input.GetButton("TR") && TR > 0 && GetComponent<TurnManager>().PlayerTurn)
        {
            TR -= GetComponent<TurnManager>().DificultyCoef * t;
            TRBool = true;
            TRused = true;
        }
        else if (Input.GetButton("TR") && TR > 0 && !GetComponent<TurnManager>().PlayerTurn)
        {
            TR -= GetComponent<TurnManager>().DificultyCoef*1.5f *t;
            TRBool = true;
            TRused = true;
        }
        else
        {  
            TRBool = false;
            
        }
        if (TR < 0)
            TR = 0;
        TRImage.fillAmount= TR/8f;
	}
}
