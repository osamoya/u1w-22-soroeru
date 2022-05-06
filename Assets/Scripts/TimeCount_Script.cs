using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount_Script : MonoBehaviour
{
    float timeCount;
    bool isCounting;
    int deg = 0;
    int dispM=0;
    int dispH=12;
    string s;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        isCounting = true;
        text = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting)
        {
            timeCount += Time.deltaTime;
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
            if (dispH == 24)//定時
            {
                //ここに何らかの処理
                isCounting = false;
            }
            s = "" +dispH+":"+dispM;
        }
        else
        {
            s = "CLOSE";
        }
        //文字列にする
        text.text = s;
    }
}
