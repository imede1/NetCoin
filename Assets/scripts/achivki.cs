using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using YG;

public class achivki : MonoBehaviour
{
    public int money;
    public int click;
    public int boost;
    void Start()
    {
        if(YandexGame.SDKEnabled==true){

            LoadSaveCloud();

        }
        StartCoroutine(Idlefarm());
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
