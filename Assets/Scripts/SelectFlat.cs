using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectFlat : MonoBehaviour
{
    [SerializeField]
    GameObject FloorPlan, Flat;
    [SerializeField] bool IsFlatActive = true;

    private void OnMouseDown()
    {
        FloorPlan.SetActive(!IsFlatActive);
        Flat.SetActive(IsFlatActive);
    }
}
