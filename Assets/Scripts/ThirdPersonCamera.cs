using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    private const float Y_angle_min = -20f;
    private const float Y_angle_max = 20f;

    public Transform camTransform;
    public GameObject PL;

    private Camera cam;

    private float distance = 10f;
    private float currentX = 0f;
    private float currentY = 0f;
    private float sensitivityX = 4f;
    private float sensitivityY = 1f;

    // Use this for initialization
    void Start ()
    {
        camTransform = transform;
        cam = Camera.main;

        PL = GameObject.Find("Player(Clone)");
    }

    // Update is called once per frame
    private void Update()
    {
        PL = GameObject.Find("Player(Clone)");

        currentX += Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");

        currentY = Mathf.Clamp(currentY, Y_angle_min, Y_angle_max);
    }

    void LateUpdate ()
    {
		Vector3 dir = new Vector3 (0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = PL.transform.position + rotation * dir;
        camTransform.LookAt(PL.transform.position);
	}
}
