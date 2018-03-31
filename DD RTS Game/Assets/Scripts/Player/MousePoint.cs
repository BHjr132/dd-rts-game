using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePoint : MonoBehaviour {

    RaycastHit hit;

    public GameObject Target;

    private float raycastLength = 500;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, raycastLength))
        {
            if(hit.collider.name == "MapMesh" || hit.collider.name == "Water")
            {

            }
        }

        Debug.DrawRay(ray.origin, ray.direction * raycastLength, Color.yellow);
    }

}
