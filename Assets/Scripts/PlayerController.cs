using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody player;
    public float forceMultiplier = 10f;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 moveDirection = Vector3.zero;

        float horizontalInput = Input.GetAxis("Horizontal");
        moveDirection += new Vector3(horizontalInput, 0f, 0f);

        float verticalInput = Input.GetAxis("Vertical");
        moveDirection += new Vector3(0f, 0f, verticalInput);
        
        // Vector3 moveDelta = moveDirection * speed * Time.deltaTime;

        Vector3 movingForce = moveDirection * forceMultiplier;
        
        player.AddForce(movingForce);
    }
}
