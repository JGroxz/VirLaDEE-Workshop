using UnityEngine;
using Zinnia.Action;

public class PlayerController : MonoBehaviour
{
    public Vector2Action moveInput;

    public Rigidbody player;
    public float forceMultiplier = 10f;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 moveDirection = Vector3.zero;

        moveDirection += new Vector3(moveInput.Value.x, 0f, 0f);
        moveDirection += new Vector3(0f, 0f, moveInput.Value.y);

        Vector3 movingForce = moveDirection * forceMultiplier;
        
        player.AddForce(movingForce);
    }
}
