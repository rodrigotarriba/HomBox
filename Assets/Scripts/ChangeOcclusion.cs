using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOcclusion : MonoBehaviour
{
    [SerializeField] MeshRenderer[] childrenRenderers;
    [SerializeField] Material materialToApplyChildren;
    
    // Start is called before the first frame update
    void Start()
    {
        childrenRenderers = GetComponentsInChildren<MeshRenderer>();

        foreach(var child in childrenRenderers)
        {
            child.material = materialToApplyChildren;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
