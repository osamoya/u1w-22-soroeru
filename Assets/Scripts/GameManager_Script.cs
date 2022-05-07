using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager_Script : MonoBehaviour
{
    [SerializeField] GameObject buy_p;
    [SerializeField] GameObject ply_p;
    [SerializeField] GameObject Cover;
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
        Debug.Log("change");
        if (NowState==state.Buying)
        {
            Debug.Log("b2p");
            buy_p.SetActive(false);
            ply_p.SetActive(true);
            NowState = state.Shooting;
        }
        else
        {
            Debug.Log("p2b");
            buy_p.SetActive(true);
            ply_p.SetActive(false);
            NowState = state.Buying;
        }
        Invoke(nameof(CoverPanelClose), 1f);
    }
    public void DoChange()
    {
        Debug.Log(".5fŒã‚É•Ï‚¦‚Ü‚·");
        GetComponent<FadeCover_Script>().OnClickFade();
        Invoke(nameof(ChangePanel), 1f);
    }
    void CoverPanelClose()
    {
        Cover.SetActive(false);
    }
}
