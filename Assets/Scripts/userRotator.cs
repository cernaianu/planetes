using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userRotator : MonoBehaviour
{

    [SerializeField]
    private float speed;
    bool isDragging = false;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnMouseDrag()
    {
        isDragging = true;
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }
    }

    private void FixedUpdate()
    {
        if(isDragging)
        {
            float x = Input.GetAxis("Mouse X") * speed * Time.fixedDeltaTime * 100;
            float y = Input.GetAxis("Mouse Y") * speed * Time.fixedDeltaTime * 100;

            rb.AddTorque(Vector3.down * x);
            rb.AddTorque(Vector3.right * y);

        }
    }
}
