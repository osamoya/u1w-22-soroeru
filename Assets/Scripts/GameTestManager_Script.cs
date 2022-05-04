using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTestManager_Script: MonoBehaviour
{
    [SerializeField] ShotSimple_Script ShotSimple_;
    [SerializeField] Button b_onoff;
    ShotOnOff_Script shotOnOff_;
    [SerializeField] int RPS;//1ïbÇ≈åÇÇƒÇÈêî
    long count;
    // Start is called before the first frame update
    void Start()
    {
        shotOnOff_ = b_onoff.GetComponent<ShotOnOff_Script>();
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (shotOnOff_.Shooting)
        {
            if (count % (300/RPS) == 0)
            {
                ShotSimple_.shot();
            }
        }
        else { count = 0; }
        count++;
    }


}
