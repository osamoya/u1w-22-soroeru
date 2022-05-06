using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSE_Script : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    [SerializeField] AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickSE()
    {
        Debug.Log("–Â‚ç‚µ‚Ü‚·");
        source.PlayOneShot(clip);
    }
}
