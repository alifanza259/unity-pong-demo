using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer2 : MonoBehaviour
{
    public float movementSpeed;

    public void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical2");

        Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = new Vector2(0, v) * movementSpeed;

    }
}
