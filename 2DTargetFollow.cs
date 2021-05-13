using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 2DTargetFollow : MonoBehaviour
{
    public GameObject Target;
    public float force;
    public Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        Vector3 diff = Target.transform.position - transform.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
    }
    
    private void Update()
    {
        rb.velocity = transform.up * force;
    }
}
