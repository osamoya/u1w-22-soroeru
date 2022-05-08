using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bulletcount_script : MonoBehaviour
{
    [SerializeField]ShotOnOff_Script onoff;
    TextMeshProUGUI tmp;
    // Start is called before the first frame update
    void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = onoff.AMMO.ToString();
    }
}
