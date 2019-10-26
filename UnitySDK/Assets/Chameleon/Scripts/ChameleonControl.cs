using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChameleonControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera camera;
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 pos = Input.mousePosition;
        // Debug.Log(pos);
        pos.z = camera.transform.position.y;
        pos = camera.ScreenToWorldPoint(pos);
        Debug.Log(pos);
        transform.position = new Vector3(pos.x, transform.position.y, pos.z);
    }
}
