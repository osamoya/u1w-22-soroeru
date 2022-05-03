using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotManager_Script : MonoBehaviour
{
    [SerializeField] private GameObject TARGET;
    static public Vector2 targetPos { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //targetPos = new Vector2(TARGET.transform.position.x, TARGET.transform.position.y);
        targetPos = TARGET.transform.position;
    }
}
