using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTestManager_Script: MonoBehaviour
{
    [SerializeField] ShotSimple_Script ShotSimple_;
    [SerializeField] Button b_onoff1;
    [SerializeField] Button b_onoff2;
    ShotOnOff_Script shotOnOff_1;
    ShotOnOff_Script shotOnOff_2;
    [SerializeField] int RPS;//1ïbÇ≈åÇÇƒÇÈêî
    long count;
    // Start is called before the first frame update
    void Start()
    {
        shotOnOff_1 = b_onoff1.GetComponent<ShotOnOff_Script>();
        shotOnOff_2 = b_onoff2.GetComponent<ShotOnOff_Script>();
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (shotOnOff_1.Shooting)
        {
            if (count % (300/RPS) == 0)
            {
                ShotSimple_.shot(1);
            }
        }
        if (shotOnOff_2.Shooting)
        {
            if (count % (300 / RPS) == 0)
            {
                ShotSimple_.shot(2);
            }
        }
        count++;
    }


}
