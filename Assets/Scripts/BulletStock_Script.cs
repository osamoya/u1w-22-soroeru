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
    DataManager_Script dataManager_;
    [SerializeField] int Stock;
    [SerializeField] int MAX;
    [SerializeField] int Loadnum;
    public bool isMax { get; private set; }
    public bool canReload { get; private set; }
    [SerializeField] List<GameObject> imgs=new List<GameObject>();
    
    public void OnClickBuy(int n)
    {
        //�ύX�F�����͊m��Ŕ�����Ƃ��ɌĂ΂��
        Stock++;
        //�����ɁA���z�̘b
        dataManager_.BuyAMMO(n);
    }
    private void Start()
    {
        dataManager_ = GameObject.Find("TestManager").GetComponent<DataManager_Script>();

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
        if (Stock > 0) { canReload = true; }
    }
    public void reload()
    {
        Stock--;
        if (Stock <= 0) { canReload = false; }
    }
}
