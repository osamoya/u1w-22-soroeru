using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount_Script : MonoBehaviour
{
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
            timeCount += Time.deltaTime;
            //timecount��1�𒴂����ꍇ
            if (timeCount >= 1)
            {
                dispM++;
                timeCount -= 1;//M���P�ɂ��āA1����

            }

            //M��60�ɂȂ����u�Ԃ�1����
            if (dispM >= 60)
            {
                dispH++;
                dispM = 0;
            }
            if (dispH == 24)//�莞
            {
                //�����ɉ��炩�̏���
                isCounting = false;
            }
            s = "" +dispH+":"+dispM.ToString("D2");
        }
        else
        {
            s = "CLOSE";
        }
        //������ɂ���
        text.text = s;
    }
}
