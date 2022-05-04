using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTestManager_Script: MonoBehaviour
{
    [SerializeField] ShotSimple_Script ShotSimple_;
    [SerializeField] Button b_onoff;
    ShotOnOff_Script shotOnOff_;
    // Start is called before the first frame update
    void Start()
    {
        shotOnOff_ = b_onoff.GetComponent<ShotOnOff_Script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shotOnOff_.Shooting) ShotSimple_.shot();
        
    }
}
