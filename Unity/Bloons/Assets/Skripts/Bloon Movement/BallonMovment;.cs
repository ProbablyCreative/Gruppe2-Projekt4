using UnityEngine;

public class BalloonMovement : MonoBehaviour
{
    public float speed = 10f; // Geschwindigkeit des Ballons
    public Transform target; // Zielpunkt für den Ballon

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            float distanceToTarget = Vector3.Distance(transform.position, target.position);

            if (distanceToTarget > 0.5f && distanceToTarget < 2.0f)
            {
                speed += Time.deltaTime * 0.1f;
            }
            else if (distanceToTarget <= 0.5f || distanceToTarget >= 2.0f)
            {
                speed -= Time.deltaTime * 0.1f;
            }

            rb.velocity = direction * speed;
        }
    }
}