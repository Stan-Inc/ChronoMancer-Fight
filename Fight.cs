using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour {
public TurnManager Turns;
    public TRManager TR;
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetButton("CutScene"))
            GetComponent<TurnManager>().CutScene = true;
        //Used For Debuging, Remember to Remove
        Turns.GetComponent<TurnManager>().TurnSys();

        
        if (GetComponent<TRManager>().TRBool || (GetComponent<TurnManager>().PlayerTurn && !GetComponent<TurnManager>().CutScene) )
        {
            PlayerControl();
        }
        GetComponent<TurnManager>().CutScene = false;
        //remove this line after CutScenes are actualy implemented
    }
    void PlayerControl()
        //Probobly only enter/select will be put here for final and all other input will be put in a different void Controlls here will be restricted durring enemy turns and CutScenes
    {
        if (Input.GetButton("Horizontal"))
            Debug.Log("Menu HZ");
        if (Input.GetButton("Vertical"))
            Debug.Log("Menu VT");
        if (Input.GetButton("Submit"))
            Debug.Log("Menu ENT");
        
    } 
   
}