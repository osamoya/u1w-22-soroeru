using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DispCoin_Script : MonoBehaviour
{
    [SerializeField] DataManager_Script dataManager_;
    Text disp_text;
    TextMeshProUGUI tmp;
    // Start is called before the first frame update
    void Start()
    {
        //disp_text = this.GetComponent<Text>();
        tmp = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        int c= DataManager_Script.coin;
        tmp.text = "Å~Å@"+DataManager_Script.coin;
    }
}
