using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {
    
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start() {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update() {
        ManageState();
    }

    private void ManageState() {
        // Returns the next states
        // Var can be used as a shortcut when a variable is declared and initialized.
        var nextStates = state.GetNextStates();

        for(int i = 0; i < nextStates.Length; i++){
            if(Input.GetKeyDown(KeyCode.Alpha1 + i) || Input.GetKeyDown(KeyCode.Keypad1 + i)) {
                state = nextStates[i];
            } 
        }

        textComponent.text = state.GetStateStory();
    }
}
