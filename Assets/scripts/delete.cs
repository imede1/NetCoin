using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
public class delete : MonoBehaviour
{
    public void deleteprog(){
       YandexGame.ResetSaveProgress();
        YandexGame.SaveProgress();
    }
}