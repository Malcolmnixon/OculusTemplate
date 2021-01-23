using UnityEngine;

public class ActionMaterial : MonoBehaviour
{
    [Tooltip("Target object to set material on")]
    public GameObject target;

    [Tooltip("New material to set when activated")]
    public Material newMaterial;

    private Material _originalMaterial;

    private void Start()
    {
        if (target == null) target = gameObject;

        _originalMaterial = target.GetComponent<Renderer>().material;
    }

    public void SetMaterial()
    {
        target.GetComponent<Renderer>().material = newMaterial;
    }

    public void RestoreMaterial()
    {
        target.GetComponent<Renderer>().material = _originalMaterial;
    }
}
