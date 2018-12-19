using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TurnManager : MonoBehaviour {
    public const float t = .0166666666666666f;
    public float PTT = 8f;
    public bool PlayerTurn = true;
    public float CTT = 0f;
    public Image TurnCC;
    public Image TurnPL;
    public bool CutScene;
    public float DificultyCoef = 1;
    //causes game speed to increase
    public void TurnSys()
    
    {
        if (!CutScene) {
        if (PlayerTurn && PTT > 0 && !GetComponent<TRManager>().TRBool)
        {
            PTT -= DificultyCoef*t;
            Debug.Log("MY TURN");
            
        }
        else if (!PlayerTurn && CTT >0)
        {
            CTT -= DificultyCoef*t;
            Debug.Log("CTURN");
        }
        else if (!GetComponent<TRManager>().TRBool)
        {
            Debug.Log("Turn Over!");
            TurnHandOff();
            //Insert Cutscene animations in TurnHandOff()
        }
        TurnPL.fillAmount = PTT / 8f;
        TurnCC.fillAmount = CTT / 8f;
        }
    }
    public void TurnHandOff()
     {    if (PlayerTurn)
        {
            PlayerTurn = false;
            //Insert Cutscene animation Here (reminder set CScene to True then to false)
            CTT = 8;
            PTT = 0;
        }
        else
        {
            PlayerTurn = true;
            //Insert Cutscene animation Here (reminder set CScene to True then to false)
            PTT = 8;
            CTT = 0;
            if (!GetComponent<TRManager>().TRused)
            {
                GetComponent<TRManager>().TR += 2;
            }
            else
            {
                GetComponent<TRManager>().TRused = false;
            }
        }
    }
}
