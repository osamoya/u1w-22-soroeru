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
    public bool isMax { get; private set; }
    [SerializeField] List<GameObject> imgs=new List<GameObject>();
    
    public void OnClickBuy()
    {
        //�ύX�F�����͊m��Ŕ�����Ƃ��ɌĂ΂��
        Stock++;
        //�����ɁA���z�̘b

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
