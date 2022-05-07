using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TargetMove_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.DOMoveX(0f,2)
            .SetEase(Ease.InCubic)//Ease.InOutBounce)
            .SetLoops(10000,LoopType.Yoyo);
    }

    
}
