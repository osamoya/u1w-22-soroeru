using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount_Script : MonoBehaviour
{
    [SerializeField] GameManager_Script GM;
    [SerializeField] SoundSE_Script se;
    float timeCount;
    bool isCounting;
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
            timeCount += Time.deltaTime*10;
            //timecountÇ™1Çí¥Ç¶ÇΩèÍçá
            if (timeCount >= 1)
            {
                dispM++;
                timeCount -= 1;//MÇÇPÇ…ÇµÇƒÅA1à¯Ç≠

            }

            //MÇ™60Ç…Ç»Ç¡ÇΩèuä‘Ç…1ë´Ç∑
            if (dispM >= 60)
            {
                dispH++;
                dispM = 0;
            }
            if (dispH >= 13)//íËéû
            {
                //Ç±Ç±Ç…âΩÇÁÇ©ÇÃèàóù
                Debug.Log("Time");
                GM.DoChange();
                isCounting = false;
                se.OnClickSE();
            }
            s = "" +dispH+":"+dispM.ToString("D2");
        }
        else
        {
            s = "CLOSE";
        }
        //ï∂éöóÒÇ…Ç∑ÇÈ
        text.text = s;
    }
}
