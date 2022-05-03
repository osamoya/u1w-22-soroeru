using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// 名前または番号指定で移動させる。
/// 引数に(Scene nextscene)はどうやらonclickの関係で怪しそう
/// </summary>
public class MoveSceneScript : MonoBehaviour
{
    public void OnPushMoveScene(string nextscene)
    {
        SceneManager.LoadScene(nextscene);
    }
    
    //HACK:おんなじ中身なのでまとめられそうだが、現状はこれで
    public void OnPushMoveScene(int nextscene)
    {
        SceneManager.LoadScene(nextscene);
    }
}
