using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using YG;
public class shop : MonoBehaviour
{
    public int money;
    public int boost;
    public int click;
    public Text moneyText;

    void Start()
    {
        if(YandexGame.SDKEnabled==true){

            LoadSaveCloud();
        }   

       StartCoroutine(Idlefarm());
    }
    public void Mysave(){

        YandexGame.savesData.money=money;
        YandexGame.savesData.boost=boost;
        YandexGame.savesData.click=click;
        YandexGame.SaveProgress();
        }

   
    private void OnEnable()=>YandexGame.GetDataEvent+=LoadSaveCloud;
    private void OnDisable()=>YandexGame.GetDataEvent-=LoadSaveCloud;
    public void LoadSaveCloud(){

        moneyText.text = YandexGame.savesData.money.ToString();
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
    public void toMenu(){
        SceneManager.LoadScene(0);
        Mysave();
    }
    void Update()
    {
       
    }
}