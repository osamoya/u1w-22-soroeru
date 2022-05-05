using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FadeCover_Script : MonoBehaviour
{
    Image p;
    [SerializeField] GameObject panel;
    
    // Start is called before the first frame update
    void Start()
    {
        p = panel.GetComponent<Image>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickFade()
    {
        Debug.Log("fade");
        panel.SetActive(true);
        Sequence sequence = DOTween.Sequence();
        sequence.Append(p.DOFade(1, 1f));
        sequence.Append(p.DOFade(0, 1f));
        //DOFade(0, 1f).;
        sequence.Play();
    }
}
