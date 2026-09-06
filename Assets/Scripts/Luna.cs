using UnityEngine;

public class Luna : MonoBehaviour
{
    //atributes
    //public
    public Transform lunaTransform;
    public Transform tierraTransform;
    public Transform Tierra;
    public float speedRotatingAround;

    //private
    private float rotationAngle = 1;

    void Update()
    {
        lunaTransform.RotateAround(tierraTransform.position, Vector3.up, rotationAngle * Time.deltaTime * speedRotatingAround);
        lunaTransform.LookAt(tierraTransform);
    }
}
