using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

using UnityEngine.SceneManagement;

public class SwitchBetweenModes : MonoBehaviour
{
    [SerializeField] public GameObject[] focusModeTransforms;
    [SerializeField] public  GameObject[] funModeTransforms;
    [SerializeField] public GameObject[] emptyModeTransforms;
    
    
    public void ChangeSpaceState(string mode)
    {
        switch (mode)
        {
            case "focus":
                DeActivateItems(emptyModeTransforms);
                DeActivateItems(funModeTransforms);
                ActivateItems(focusModeTransforms);
                break;
            case "fun":
                DeActivateItems(emptyModeTransforms);
                ActivateItems(funModeTransforms);
                DeActivateItems(focusModeTransforms);
                break;
            case "emtpy":
                ActivateItems(emptyModeTransforms);
                DeActivateItems(funModeTransforms);
                DeActivateItems(focusModeTransforms);
                break;
            default:
                break;
        }
    }


    public void DeActivateItems(GameObject[] objects)
    {
        foreach(var obj in objects)
        {
            obj.SetActive(false);
        }
    }    
    
    private void ActivateItems(GameObject[] objects)
    {
        foreach(var obj in objects)
        {
            obj.SetActive(true);
        }
    }




}


