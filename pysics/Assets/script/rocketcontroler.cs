using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketcontroler : MonoBehaviour
{
    [SerializeField] float thrusterforce = 10;
    [SerializeField] float rotationforce = 10;

    Rigidbody rb;

    bool thrust = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }
    private void Update()
    {
        float tilt = Input.GetAxis("Horizontal");
        thrust = Input.GetKey(KeyCode.Space);

        if (!Mathf.Approximately(tilt, 0))
        {
            rb.freezeRotation = true;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + (new Vector3(0, 0, (rotationforce * tilt * Time.deltaTime))));
        }
        rb.freezeRotation = false;
    }
    private void FixedUpdate()
    {
        if (thrust) { rb.AddRelativeForce(Vector3.up * thrusterforce * Time.deltaTime); }
    }

}
