using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �e�̊Ǘ�������X�N���v�g
/// �������e�͂����ɍs���A��������e�{�^���ɓ����
/// �����Ȃ��A�Ȃǂ̏����͂�����ōs��
/// </summary>
public class BulletStock_Script : MonoBehaviour
{
    [SerializeField] int Stock;
    [SerializeField] int MAX;
    [SerializeField] List<GameObject> imgs=new List<GameObject>();
    
    public void OnClickBuy()
    {
        if (Stock < MAX)
        {
            //�����Ŕ����w��
            return;
        }
        //���E�l�Ŕ����Ȃ�
        //�����ɏ���
    }
    private void Update()
    {
        //������Stock�ɂ��`��
        //Stock�̐������傫�����̂̕`������Ȃ��悤�ɂ���
        
        for (int i=0;i<MAX;i++)
        {
            if (i < Stock) imgs[i].SetActive(true);
            else imgs[i].SetActive(false);
        }
    }
}
