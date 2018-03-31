using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapRaycast : MonoBehaviour
{
    RaycastHit hit;

    public Camera MinimapCamera;

    private float raycastLength = 500;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = MinimapCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, raycastLength))
            {
                Debug.Log(hit.collider.name);
                if (hit.collider.name == "MapMesh" || hit.collider.name == "Water")
                {
                    Camera.main.transform.position = new Vector3(hit.point.x, Camera.main.transform.position.y, hit.point.z);
                }
            }
        }
    }
}
