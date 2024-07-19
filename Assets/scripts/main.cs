using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using YG;

public class main : MonoBehaviour {
    [SerializeField] int money;
    public int click;
    public Text moneyText;
    public int boost;
    
    public void Start(){

        if(YandexGame.SDKEnabled==true){

            LoadSaveCloud();
        }    

    moneyText.text = YandexGame.savesData.money.ToString();    

    StartCoroutine(Idlefarm());
      
    }
    public void ButtonClick(){

        money+=click;

        Mysave();
        
        moneyText.text = YandexGame.savesData.money.ToString();

    }
    
    private void OnEnable()=>YandexGame.GetDataEvent+=LoadSaveCloud;
    private void OnDisable()=>YandexGame.GetDataEvent-=LoadSaveCloud;
    public void Mysave(){
        YandexGame.savesData.money=money;
        YandexGame.savesData.boost=boost;
        YandexGame.savesData.click=click;
        YandexGame.SaveProgress();
    }
    public void LoadSaveCloud(){
        money=YandexGame.savesData.money;
        boost=YandexGame.savesData.boost;
        click=YandexGame.savesData.click;
     }
    
    IEnumerator Idlefarm(){
        yield return new WaitForSeconds(1);
        money+=boost;
        Mysave();
        moneyText.text = YandexGame.savesData.money.ToString();
        StartCoroutine(Idlefarm());
    } 
    public void ToShop(){
        SceneManager.LoadScene(1);
        Mysave();
    }
    void Update()
    {
        
    }
}