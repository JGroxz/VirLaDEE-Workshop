using UnityEngine;

public class TransformRotator_1 : MonoBehaviour
{
    public Transform target;
    public float speed1 = 45f;
    public float speed2 = 30f;
    
    // Update is called once per frame
    void Update()
    {
        float angleDelta1 = speed1 * Time.deltaTime;
        float angleDelta2 = speed2 * Time.deltaTime;
        Vector3 rotationDelta = new Vector3(angleDelta1, angleDelta2, 0f);
        
        target.Rotate(rotationDelta);
    }
}
