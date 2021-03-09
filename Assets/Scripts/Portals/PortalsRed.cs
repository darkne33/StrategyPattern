using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalsRed : MonoBehaviour, IPropertieble
{
    public Color ColorObject()
    {
        return Color.red;
    }

    private void OnTriggerEnter(Collider other)
    {
        MoveObj moveObj = other.GetComponent<MoveObj>();
        if (moveObj != null)
        {
            MeshRenderer materialObj = moveObj.GetComponent<MeshRenderer>();
            materialObj.material.color = ColorObject();
        }
    }


    private void OnTriggerExit(Collider other)
    {
        MoveObj moveObj = other.GetComponent<MoveObj>();
        if (moveObj != null)
        {
            MeshRenderer materialObj = moveObj.GetComponent<MeshRenderer>();
            materialObj.material.color = Color.green;
        }
    }
}
