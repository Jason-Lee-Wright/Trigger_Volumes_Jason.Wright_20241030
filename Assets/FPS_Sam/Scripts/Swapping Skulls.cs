using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sam Robichaud NSCC

public class SwappingSkulls : MonoBehaviour
{ 
    public GameObject LavaSkull;
    public GameObject LavaSkullRemake;

    private void Start()
    {
        LavaSkullRemake.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        LavaSkull.SetActive(false);
        LavaSkullRemake.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        LavaSkull.SetActive(true);
        LavaSkullRemake.SetActive(false);
    }       
}
