using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager_Script : MonoBehaviour
{
    [SerializeField] GameObject buy_p;
    [SerializeField] GameObject ply_p;
    enum state { 
        Buying,
        Shooting,
        Changing
    }
    state NowState;
    // Start is called before the first frame update
    void Start()
    {
        NowState = state.Buying;
    }

    // Update is called once per frame
    void Update()
    {
        switch (NowState)
        {
            case state.Buying:  buying();   break;
            case state.Shooting:Shooting(); break;
            case state.Changing:Changing(); break;
        }

    }
    void buying()
    {

    }
    void Shooting()
    {

    }
    void Changing()
    {

    }

    public void ChangePanel()
    {
        if (NowState==state.Buying)
        {
            buy_p.SetActive(false);
            ply_p.SetActive(true);
        }
        else
        {
            buy_p.SetActive(true);
            ply_p.SetActive(false);
        }
    }
}
