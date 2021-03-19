using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headcontr : MonoBehaviour
{
	Transform head_tr;

	float MouseX;
	float MouseY;
	public float sens = 3f;
    // Start is called before the first frame update
    void Start()
    {
        head_tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        MouseX = MouseX + Input.GetAxis("Mouse X") * sens;
        MouseY = MouseY - Input.GetAxis("Mouse Y") * sens;

        MouseY = Mathf.Clamp(MouseY, -90, 90);

        head_tr.rotation = Quaternion.Euler(MouseY, MouseX, 0);
    }
}
