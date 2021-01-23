using UnityEngine;
using UnityEngine.Events;

public class ColliderTriggerExit : MonoBehaviour
{
    public string filter;

    public UnityEvent onExit;

    private void OnTriggerExit(Collider c)
    {
        if (c.name.Contains(filter))
            onExit?.Invoke();
    }
}
