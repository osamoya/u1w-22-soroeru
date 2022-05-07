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
            //timecount‚ª1‚ğ’´‚¦‚½ê‡
            if (timeCount >= 1)
            {
                dispM++;
                timeCount -= 1;//M‚ğ‚P‚É‚µ‚ÄA1ˆø‚­

            }

            //M‚ª60‚É‚È‚Á‚½uŠÔ‚É1‘«‚·
            if (dispM >= 60)
            {
                dispH++;
                dispM = 0;
            }
            if (dispH >= 22&&isOpening)//’è
            {
                //‚±‚±‚É‰½‚ç‚©‚Ìˆ—
                Debug.Log("Time");
                GM.DoChange();
                isOpening = false;
                se.OnClickSE();
            }
            if (dispH >= 24)
            {
                Debug.Log("Ÿ‚Ì“ú");
                dispH = 10;
                dispM = 0;
                dispD++;
                GM.DoChange();
                isOpening = true;
                se.OnClickSE();
            }
            if (dispD>3&&!isOpening)
            {
                Debug.Log("I—¹I");
                this.GetComponent<FadeCover_Script>().OnClickFade();
            }
            s = ""+dispD+"“ú–Ú " +dispH+":"+dispM.ToString("D2");
        }
        else
        {
            s = "" + dispD + "“ú–Ú " + dispH + ":" + dispM.ToString("D2");
        }
        //•¶š—ñ‚É‚·‚é
        tmp.text = s;
    }
}
