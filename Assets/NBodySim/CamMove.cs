using UnityEngine;

public class CamMove : MonoBehaviour
{
    public float MoveSpeed;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + (transform.forward) * MoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position - (transform.forward) * MoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + (transform.right) * MoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - (transform.right) * MoveSpeed * Time.deltaTime;
        }
    }
}
