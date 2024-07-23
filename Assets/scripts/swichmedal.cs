using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class swichmedal : MonoBehaviour
{
      [SerializeField] private Sprite[] bottonSprites;
      [SerializeField] private Image targetgold;
      [SerializeField] private Image targetsilver;
      [SerializeField] private Image targetbronz;
    
        public bool gold_medal;
        public bool silver_medal;
        public bool bronz_medal;
      
    void Start()
    {
        if(YandexGame.SDKEnabled==true){

            LoadSaveCloud();
        } 

        if(gold_medal==true){

            targetgold.sprite = bottonSprites[1];

        }
        
        else{

            targetgold.sprite = bottonSprites[0];

        }

        if(silver_medal==true){

            targetsilver.sprite = bottonSprites[2];

        }
        else{
            
            targetsilver.sprite = bottonSprites[0];

        }

        if(bronz_medal==true){

            targetbronz.sprite = bottonSprites[3];

        }
        else{
            
            targetbronz.sprite = bottonSprites[0];

        }
    }
    private void OnEnable()=>YandexGame.GetDataEvent+=LoadSaveCloud;
    private void OnDisable()=>YandexGame.GetDataEvent-=LoadSaveCloud;
    public void LoadSaveCloud(){

        gold_medal=YandexGame.savesData.gold_medal;
        silver_medal=YandexGame.savesData.silver_medal;
        bronz_medal=YandexGame.savesData.bronz_medal;
   
    }
  
}
