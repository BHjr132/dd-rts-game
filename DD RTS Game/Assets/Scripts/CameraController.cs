using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public float panSpeed = 400f;
    public float panBorderThickness = 10f;
    public Vector2 panLimit;

    public float scrollSpeed = 500f;
    public float minY = 20f;
    public float maxY = 100f;

    public float rotSpeed = 30f;

    public float panVerticalSpeed = 30f;
    public float minVerticalPan = 0f;
    public float maxVerticalPan = 90f;
	
	void Update () {

        Vector3 pos = transform.position;
        Vector3 rot = transform.eulerAngles;

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            pos.z += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            pos.z -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("q"))
        {
            transform.Rotate(Vector3.down * rotSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("e"))
        {
            transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.PageUp))
        {
            transform.Rotate(Vector3.left * panVerticalSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.PageDown))
        {
            transform.Rotate(Vector3.right * panVerticalSpeed * Time.deltaTime, Space.World);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollSpeed * 1000f * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        pos.z = Mathf.Clamp(pos.z, -panLimit.y, panLimit.y);

        transform.position = pos;
	}
}
