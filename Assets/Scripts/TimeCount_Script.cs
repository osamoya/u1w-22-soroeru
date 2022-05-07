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
    int dispM=0;
    int dispH=12;
    string s;
    Text text;
    TextMeshProUGUI tmp;
    // Start is called before the first frame update
    void Start()
    {
        isCounting = true;
        tmp = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting)
        {
            timeCount += Time.deltaTime*10;
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
            if (dispH >= 13)//�莞
            {
                //�����ɉ��炩�̏���
                Debug.Log("Time");
                GM.DoChange();
                isCounting = false;
                se.OnClickSE();
            }
            s = "���ݎ���" +dispH+":"+dispM.ToString("D2");
        }
        else
        {
            s = "CLOSE";
        }
        //������ɂ���
        tmp.text = s;
    }
}
