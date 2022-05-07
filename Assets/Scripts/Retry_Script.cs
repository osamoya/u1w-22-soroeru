using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry_Script : MonoBehaviour
{
    [SerializeField] GameObject panel;
    public void OnclickRtry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
