using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSetActive : MonoBehaviour
{
    public GameObject targetObject;

    void OnTriggerEnter(Collider other)
    {
        if (targetObject != null)
        {
            targetObject.SetActive(!targetObject.activeSelf);
        }
    }
}
