using UnityEngine;

public class Sol : MonoBehaviour
{
    //public atributes
    public Transform solTransform;
    public float speedRotation;

    void Update()
    {
        solTransform.Rotate(Vector3.up * Time.deltaTime * speedRotation);
    }
}
