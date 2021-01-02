using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class GeriSayim : MonoBehaviour
{

public int countdownTime;
public Text coundownDisplay;

private void Start() {
    StartCoroutine(CountdownToStart());
}

IEnumerator CountdownToStart()
{
    



while(countdownTime>0){
    coundownDisplay.text=countdownTime.ToString();

    yield return new WaitForSeconds(1f);
    countdownTime--;

 
}
   if(countdownTime == 0){
    
coundownDisplay.text="Kamerayı hazırlayın.";

  yield return new WaitForSeconds(5);
Application.LoadLevel("Sahne");


    }
//coundownDisplay.text="Başlıyoruz";

}


}
    

