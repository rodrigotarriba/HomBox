using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAutomatically : MonoBehaviour
{

    public Transform referenceTransform;


    // Update is called once per frame
    void Update()
    {
        float rotationAmount = Time.deltaTime / 5f * 360f;

        // Rotate the shape around the reference transform's y-axis
        transform.RotateAround(referenceTransform.position, referenceTransform.up, rotationAmount);
    }
}
