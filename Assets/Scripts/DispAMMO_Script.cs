using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispAMMO_Script : MonoBehaviour
{
    DataManager_Script dataManager_;
    [SerializeField] int bullet_num;
    int price;
    bool canBuy;
    // Start is called before the first frame update
    void Start()
    {
        dataManager_ = GameObject.Find("TestManager").GetComponent<DataManager_Script>();
        switch (bullet_num)//�l�i�̐ݒ�
        {
            case 1:price = dataManager_.b1;break;
            case 2:price = dataManager_.b2;break;
            default:return;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (DataManager_Script.coin<price)
        {
            canBuy = false;
        }
        else
        {
            canBuy = true;
        }
    }

    public void OnClickBuy()
    {
        Debug.Log("�����ꂽ�B�������Ƃ��Ă���");
        if (!canBuy)
        {
            //����p�̏���
            //�F��ς�����\��������
            return;
        }
        //��������
        dataManager_.BuyAMMO(bullet_num);
    }
}
