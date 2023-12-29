using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Adjust this value to set the movement speed.
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;

            Ray ray = Camera.main.ScreenPointToRay(mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Vector3 targetPosition = hit.point;

                Vector3 direction = (targetPosition - transform.position).normalized;

                rb.velocity = new Vector3(direction.x * speed, 0f, direction.z * speed);
            }
        }
    }
}
