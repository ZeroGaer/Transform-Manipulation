using UnityEngine;

public class Tierra : MonoBehaviour
{
    //Atributes
    //public
    public Transform tierraTransform;
    public Transform solTransform;
    public float speedRotation;
    public float speedRotatingAround;
    public Vector3 point1;
    public Vector3 point2;

    //private
    private float _rotationAngle = 1;

    void Update()
    {
        tierraTransform.Rotate(Vector3.up * Time.deltaTime * speedRotation);
        tierraTransform.RotateAround(solTransform.position, Vector3.up, _rotationAngle * Time.deltaTime * speedRotatingAround);
        Debug.DrawLine(tierraTransform.position + point1, tierraTransform.position + point2, Color.blue);
    }
}
