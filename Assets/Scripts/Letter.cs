using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letter : MonoBehaviour
{
    public string lower, upper, alt;

    private void Start() {
        if(LetterManager.lm.alt){
            GetComponentInChildren<Text>().text = alt;
        }else if(LetterManager.lm.mayus){
            GetComponentInChildren<Text>().text = upper;
        }else{
            GetComponentInChildren<Text>().text = lower;
        }
    }
    
    public void OnClick(){
        
        if(LetterManager.lm.alt){
            LetterManager.lm.AddLetter(alt);
        }else if(LetterManager.lm.mayus){
            LetterManager.lm.AddLetter(upper);
        }else{
            LetterManager.lm.AddLetter(lower);
        }
    }

    public void ShowLetter(){
        if(LetterManager.lm.alt){
            GetComponentInChildren<Text>().text = alt;
        }else if(LetterManager.lm.mayus){
            GetComponentInChildren<Text>().text = upper;
        }else{
            GetComponentInChildren<Text>().text = lower;
        }
    }
}
