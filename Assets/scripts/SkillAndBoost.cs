using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using YG;
public class ClickAndBoost : MonoBehaviour
{
    public int money;
    public int boost;
    public int click;

    public Text moneyText;

    public Button firstButton;
    public Button secondButton;
    public Button thirdButton;
    public Button fourthButton;
    public Button fifthButton;
    public Button sixButton;
    public Button sevenButton;
    public Button eaghtButton;
    public Button nineButton;
    public Button tenButton;
    
    
    public bool shopclick_1;
    public bool shopclick_2;
    public bool shopclick_3;
    public bool shopclick_4;
    public bool shopclick_5;
    public bool shopBoost_1;
    public bool shopBoost_2;
    public bool shopBoost_3;
    public bool shopBoost_4;
    public bool shopBoost_5;

    void Start()
    {
        if(YandexGame.SDKEnabled==true){

            LoadSaveCloud();
        } 
        
        moneyText.text = YandexGame.savesData.money.ToString();

        StartCoroutine(Idlefarm());

        if (shopclick_1 == true)
        {
            firstButton.interactable = false;
        }
        if (shopclick_2 == true)
        {
            secondButton.interactable = false;
        }
        if (shopclick_3 == true)
        {
            thirdButton.interactable = false;
        }
        if (shopclick_4 == true)
        {
            fourthButton.interactable = false;
        }
        if (shopclick_5 == true)
        {
            fifthButton.interactable = false;
        }
        if (shopBoost_1 == true)
        {
            sixButton.interactable = false;
        }
        if (shopBoost_2 == true)
        {
            sevenButton.interactable = false;
        }
        if (shopBoost_3 == true)
        {
            eaghtButton.interactable = false;
        }
        if (shopBoost_4 == true)
        {
            nineButton.interactable = false;
        }
        if (shopBoost_5 == true)
        {
            tenButton.interactable = false;
        }

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

        money=YandexGame.savesData.money;
        boost=YandexGame.savesData.boost;
        click=YandexGame.savesData.click;
        shopclick_1=YandexGame.savesData.shopclick_1;
        shopclick_2=YandexGame.savesData.shopclick_2;
        shopclick_3=YandexGame.savesData.shopclick_3;
        shopclick_4=YandexGame.savesData.shopclick_4;
        shopclick_5=YandexGame.savesData.shopclick_5;
        shopBoost_1=YandexGame.savesData.shopBoost_1;
        shopBoost_2=YandexGame.savesData.shopBoost_2;
        shopBoost_3=YandexGame.savesData.shopBoost_3;
        shopBoost_4=YandexGame.savesData.shopBoost_4;
        shopBoost_5=YandexGame.savesData.shopBoost_5;
   
    }

    public void shopclickget1()
    {
        if (money >= 35 && shopclick_1 == false)
        {
            money-=35;
            click+=1;
            shopclick_1=true;
            firstButton.interactable = false;
            YandexGame.savesData.money=money;   
            YandexGame.savesData.click=click; 
            YandexGame.savesData.shopclick_1=shopclick_1;
            YandexGame.SaveProgress();
            
        }
    }
    public void shopclickget2()
    {
        if (money >= 250 && shopclick_2 == false)
        {
            money-=250;
            click+=2;
            shopclick_2=true;
            secondButton.interactable = false;
            YandexGame.savesData.money=money;
            YandexGame.savesData.click=click;
            YandexGame.savesData.shopclick_2=shopclick_2;
            YandexGame.SaveProgress();
        }
    }
    public void shopclickget3()
    {
        if (money >= 750 && shopclick_3 == false)
        {
            money-=750;
            click+=3;
            shopclick_3=true;
            thirdButton.interactable = false;
            YandexGame.savesData.money=money;
            YandexGame.savesData.click=click;
            YandexGame.savesData.shopclick_3=shopclick_3;
            YandexGame.SaveProgress();
        }
    }
    public void shopclickget4()
    {
        if (money >= 2500 && shopclick_4 == false)
        {
            money-=2500;
            click+=5;
            shopclick_4=true;
            fourthButton.interactable = false;
            YandexGame.savesData.money=money;
            YandexGame.savesData.click=click;
            YandexGame.savesData.shopclick_4=shopclick_4;
            YandexGame.SaveProgress();
        }
    }
    public void shopclickget5()
    {
        if (money >= 9000 && shopclick_5 == false)
        {
            money-=9000;
            click+=7;
            shopclick_5=true;
            fifthButton.interactable = false;
            YandexGame.savesData.money=money;
            YandexGame.savesData.click=click;
            YandexGame.savesData.shopclick_5=shopclick_5;
            YandexGame.SaveProgress();
        }
    }
    public void shopboostget1()
    {
        if (money >= 50 && shopBoost_1 == false)
        {
            money-=50;
            boost+=1;
            shopBoost_1=true;
            sixButton.interactable = false;
            YandexGame.savesData.money=money;
            YandexGame.savesData.boost=boost;
            YandexGame.savesData.shopBoost_1=shopBoost_1;
            YandexGame.SaveProgress();
        }
    }
    public void shopboostget2()
    {
        if (money >= 500 && shopBoost_2 == false)
        {
            money-=500;
            boost+=2;
            shopBoost_2=true;
            sevenButton.interactable = false;
            YandexGame.savesData.money=money;
            YandexGame.savesData.boost=boost;
            YandexGame.savesData.shopBoost_2=shopBoost_2;
            YandexGame.SaveProgress();
        }
    }
    public void shopboostget3()
    {
        if (money >= 1500 && shopBoost_3 == false)
        {
            money-=1500;
            boost+=3;
            shopBoost_3=true;
            eaghtButton.interactable = false;
            YandexGame.savesData.money=money;
            YandexGame.savesData.boost=boost;
            YandexGame.savesData.shopBoost_3=shopBoost_3;
            YandexGame.SaveProgress();
        }
    }
    public void shopboostget4()
    {
        if (money >= 5000 && shopBoost_4 == false)
        {
            money-=5000;
            boost+=5;
            shopBoost_4=true;
            nineButton.interactable = false;
            YandexGame.savesData.money=money;
            YandexGame.savesData.boost=boost;
            YandexGame.savesData.shopBoost_4=shopBoost_4;
            YandexGame.SaveProgress();
        }
    }
    public void shopboostget5()
    {
        if (money >= 9500 && shopBoost_5 == false)
        {
            money-=9500;
            shopBoost_5=true;   
            boost+=7;
            tenButton.interactable = false;
            YandexGame.savesData.money=money;
            YandexGame.savesData.boost=boost;
            YandexGame.savesData.shopBoost_5=shopBoost_5;
            YandexGame.SaveProgress();
        }
    }
    IEnumerator Idlefarm(){
        yield return new WaitForSeconds(1);
        money+=boost;
        Mysave();
        StartCoroutine(Idlefarm());
    } 
    public void toMenu(){
        SceneManager.LoadScene(0);
        Mysave();
    }
    void Update()
    {
       moneyText.text=money.ToString();
    }
}
