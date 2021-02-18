using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarBillboard : MonoBehaviour
{
    public GameObject playerCamera;
    public Transform camera;

    // Start is called before the first frame update
    void Start()
    {
        playerCamera = GameObject.Find("PlayerCamera");
        camera = playerCamera.GetComponent<Camera>().transform;
    }

    void LateUpdate()
    {
        transform.LookAt(transform.position + camera.forward);
    }
}
