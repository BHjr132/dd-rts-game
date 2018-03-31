using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePoint : MonoBehaviour {

    RaycastHit hit;

    private float raycastLength = 500;

    void Update()
    {
        GameObject Target = GameObject.Find("Target");

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, raycastLength))
        {
            Debug.Log(hit.collider.name);
            if(hit.collider.name == "MapMesh" || hit.collider.name == "Water")
            {
                Target.transform.position = hit.point;
            }
        }

        Debug.DrawRay(ray.origin, ray.direction * raycastLength, Color.yellow);
    }

}
