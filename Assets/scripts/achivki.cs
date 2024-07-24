using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using YG;

public class achivki : MonoBehaviour
{
    public int money;
    public int boost;
    public bool gold_medal;
    public bool silver_medal;
    public bool bronz_medal;
    public Button goldButton;
    public Button silverButton;
    public Button bronzButton;
    void Start()
    {
        if(YandexGame.SDKEnabled==true){

            LoadSaveCloud();

        }

        StartCoroutine(Idlefarm());

        if (gold_medal == true)
        {
            goldButton.interactable = false;
        }
        if (silver_medal == true)
        {
            silverButton.interactable = false;
        }
        if (bronz_medal == true)
        {
            bronzButton.interactable = false;
        }

    }
    private void OnEnable()=>YandexGame.GetDataEvent+=LoadSaveCloud;
    private void OnDisable()=>YandexGame.GetDataEvent-=LoadSaveCloud;
    public void Mysave(){

        YandexGame.savesData.money=money;
        YandexGame.SaveProgress();

    }
    public void LoadSaveCloud(){
        money=YandexGame.savesData.money;
        boost=YandexGame.savesData.boost;
        gold_medal=YandexGame.savesData.gold_medal;
        silver_medal=YandexGame.savesData.silver_medal;
        bronz_medal=YandexGame.savesData.bronz_medal;
    }

    public void get_gold_medal(){

        goldButton.interactable = false;
        gold_medal=true;
        YandexGame.savesData.gold_medal=gold_medal;
        YandexGame.SaveProgress();
    }
    public void get_silver_medal(){

        silverButton.interactable = false;
        silver_medal=true;
        YandexGame.savesData.silver_medal=silver_medal;
        YandexGame.SaveProgress();
    }
    public void get_bronz_medal(){

        bronzButton.interactable = false;
        bronz_medal=true;
        YandexGame.savesData.bronz_medal=bronz_medal;
        YandexGame.SaveProgress();
    }

    IEnumerator Idlefarm(){
        yield return new WaitForSeconds(1);
        money+=boost;
        Mysave();
        StartCoroutine(Idlefarm());
    } 

    public void ToMenu(){

        SceneManager.LoadScene(0);
        Mysave();
    }
    void Update()
    {
        
    }
}
