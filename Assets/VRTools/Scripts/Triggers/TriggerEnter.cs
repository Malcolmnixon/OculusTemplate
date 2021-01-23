using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEnter : MonoBehaviour
{
    public UnityEvent onEnter;

    public string filter;

    private void OnTriggerEnter(Collider c)
    {
        if (c.name.Contains(filter))
            onEnter?.Invoke();
    }
}
