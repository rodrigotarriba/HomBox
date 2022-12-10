using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Transform[] allChildrenTransforms;
    public Material mat1;
    public Vector3 newPositions;
    public Quaternion newQuaternions;

    // Start is called before the first frame update
    void Start()
    {
        {
            foreach (var children in allChildrenTransforms)
            {
                Vector3 tempPos = children.position;
                Quaternion tempRot = children.rotation;
                children.SetParent(transform);
                children.position = tempPos;
                children.rotation = tempRot;
            }
        }
        transform.position = newPositions;
        Debug.Log("yes");
        transform.rotation = newQuaternions;
    }

    // Update is called once per frame
    void Update()
    {
        ApplyTransformations();
            
    }

    void ApplyTransformations(){

        if (Input.GetAxis("Fire1") != 0 && (Input.GetAxis("Fire2") != 0))
        {
            foreach(var children in allChildrenTransforms)
            {
                Vector3 tempPos = children.position;
                Quaternion tempRot = children.rotation;
                children.SetParent(null);
                children.position = tempPos;
                children.rotation = tempRot;
            }


        }




            if (Input.GetAxis("Horizontal") > 0)
        {
            transform.position = new Vector3(transform.position.x - .001f, transform.position.y, transform.position.z);
        }
        else if(Input.GetAxis("Horizontal") < 0)
        {
            transform.position = new Vector3(transform.position.x + .001f, transform.position.y, transform.position.z);
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - .001f);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + .001f);
        }


        if (Input.GetAxis("Fire3") > 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - .001f, transform.position.z);
        }
        else if (Input.GetAxis("Jump") > 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + .001f, transform.position.z);
        }

            if (Input.GetAxis("Fire1") > 0)
        {
            transform.Rotate(new Vector3(0f, -.1f, 0f));
        }

        if (Input.GetAxis("Fire2") > 0)
        {
            transform.Rotate(new Vector3(0f, +.1f, 0f));
        }




    }
}
