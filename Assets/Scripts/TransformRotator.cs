using UnityEngine;

public class TransformRotator : MonoBehaviour
{
    public Transform target;
    public float speed = 45f;
    
    // Update is called once per frame
    void Update()
    {
        float angleDelta = speed * Time.deltaTime;
        Vector3 rotationDelta = new Vector3(0f, 0f, angleDelta);
        
        target.Rotate(rotationDelta);
    }
}
