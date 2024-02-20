using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerXX : MonoBehaviour
{
    public GameObject bbCanvas;
    public GameObject bbCanvasAttached;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Spawn obstacles
    void Update ()
    {
        if(Input.GetKey(KeyCode.E)){
            bbCanvas.SetActive(false); 
            bbCanvasAttached.SetActive(true); 
        }
        if(Input.GetKey(KeyCode.Q)){
            bbCanvas.SetActive(true); 
            bbCanvasAttached.SetActive(false); 
        }
        if(Input.GetKey(KeyCode.Z)){
            bbCanvas.SetActive(false); 
            bbCanvasAttached.SetActive(false); 
        }
    }
}
