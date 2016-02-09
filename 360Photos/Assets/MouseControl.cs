using UnityEngine;
using System.Collections;

public class MouseControl : MonoBehaviour
{
    float horizontalRotation;
    float verticalRotation;

    // Use this for initialization
	void Start () {
	    print("hello world");
	}
	
	// Update is called once per frame
	void Update ()
	{
	    horizontalRotation += Input.GetAxis("Mouse X");
	    verticalRotation -= Input.GetAxis("Mouse Y");

	    transform.rotation = Quaternion.Euler(verticalRotation, horizontalRotation, 0);
	}
}
