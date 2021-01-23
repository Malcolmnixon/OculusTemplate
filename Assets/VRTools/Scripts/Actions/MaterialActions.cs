using UnityEngine;

public class MaterialActions : MonoBehaviour
{
    [Tooltip("Target object to set material on")]
    public GameObject target;

    private Material _originalMaterial;

    private void Start()
    {
        if (target == null) target = gameObject;

        _originalMaterial = target.GetComponent<Renderer>().material;
    }

    public void SetMaterial(Material mat)
    {
        target.GetComponent<Renderer>().material = mat ?? _originalMaterial;
    }

    public void RestoreMaterial()
    {
        target.GetComponent<Renderer>().material = _originalMaterial;
    }
}
