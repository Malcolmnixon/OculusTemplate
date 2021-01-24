using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CenterOfMass : MonoBehaviour
{
    public Vector3 centerOfMass;

    private void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = centerOfMass;
    }
}