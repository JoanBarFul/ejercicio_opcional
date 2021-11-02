using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneLimits : MonoBehaviour
{

    private float limZ = 24.5f;
    private float positionY = 0.5f;
    private float limX = 49.5f;
    private float speed = 10f;
  
    // Start is called before the first frame update
    void Start()
    {

        transform.position = new Vector3(0, positionY, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= limZ)
        { transform.position = new Vector3(transform.position.x, transform.position.y, limZ); }
        if (transform.position.z <= -limZ)
        { transform.position = new Vector3(transform.position.x, transform.position.y, -limZ); }
        if (transform.position.x >= limX)
        { transform.position = new Vector3(limX, transform.position.y, transform.position.z); }
        if (transform.position.x <= -limX)
        { transform.position = new Vector3(-limX, transform.position.y, transform.position.z); }

        MoveGameObject(Vector3.right * Time.deltaTime * speed, KeyCode.RightArrow);
        MoveGameObject(Vector3.left * Time.deltaTime * speed, KeyCode.LeftArrow);
        MoveGameObject(Vector3.forward * Time.deltaTime * speed, KeyCode.UpArrow);
        MoveGameObject(Vector3.back * Time.deltaTime * speed, KeyCode.DownArrow);
    }

    public void MoveGameObject(Vector3 direction, KeyCode keycode)
    { if (Input.GetKey(keycode))
        { transform.Translate(direction);  } 
    }
}
