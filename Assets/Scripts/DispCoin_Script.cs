using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DispCoin_Script : MonoBehaviour
{
    [SerializeField] DataManager_Script dataManager_;
    Text disp_text;
    // Start is called before the first frame update
    void Start()
    {
        disp_text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        int c= DataManager_Script.coin;
        disp_text.text = "COIN : "+DataManager_Script.coin;
    }
}
