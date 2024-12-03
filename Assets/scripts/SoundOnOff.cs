using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Change : MonoBehaviour {
    [SerializeField] private Sprite[] bottonSprites;
    [SerializeField] private Image targetButton;

    public void ChangeSprites(){
           if(targetButton.sprite== bottonSprites[0]){

            targetButton.sprite = bottonSprites[1];
            return;
           } 
            targetButton.sprite= bottonSprites[0];
    }

    public bool isOn;

    private void Start () {

        isOn=true;
    }
    public void OnOffSound(){

        if(!isOn){
            AudioListener.volume= 1f;
            isOn=true;
        }
        else{
            AudioListener.volume= 0f;
            isOn=false;
        }
    }
}
