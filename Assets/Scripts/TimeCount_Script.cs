using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TimeCount_Script : MonoBehaviour
{
    [SerializeField] GameManager_Script GM;
    [SerializeField] SoundSE_Script se;
    float timeCount;
    bool isCounting;
    bool isOpening;
    int dispM=0;
    int dispH=0;
    int dispD = 1;
    string s;
    Text text;
    TextMeshProUGUI tmp;
    // Start is called before the first frame update
    void Start()
    {
        isCounting = true;
        isOpening = true;
        tmp = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting)
        {
            timeCount += Time.deltaTime*50;
            //timecountが1を超えた場合
            if (timeCount >= 1)
            {
                dispM++;
                timeCount -= 1;//Mを１にして、1引く

            }

            //Mが60になった瞬間に1足す
            if (dispM >= 60)
            {
                dispH++;
                dispM = 0;
            }
            if (dispH >= 22&&isOpening)//定時
            {
                //ここに何らかの処理
                Debug.Log("Time");
                GM.DoChange();
                isOpening = false;
                se.OnClickSE();
            }
            if (dispH >= 24)
            {
                Debug.Log("次の日");
                dispH = 10;
                dispM = 0;
                dispD++;
                GM.DoChange();
                isOpening = true;
                se.OnClickSE();
            }
            if (dispD>3&&!isOpening)
            {
                Debug.Log("終了！");
                this.GetComponent<FadeCover_Script>().OnClickFade();
            }
            s = ""+dispD+"日目　\n" +dispH+":"+dispM.ToString("D2");
        }
        else
        {
            s = "" + dispD + "日目　\n " + dispH + ":" + dispM.ToString("D2");
        }
        //文字列にする
        tmp.text = s;
    }
}
