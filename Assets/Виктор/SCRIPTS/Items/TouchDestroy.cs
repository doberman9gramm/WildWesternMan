using UnityEngine;
using HealthSpace;

[RequireComponent(typeof(SphereTrigger))]
public class TouchDestroy : MonoBehaviour
{
    private SphereTrigger _sphereTrigger;

    private void Awake()
    {
        _sphereTrigger = GetComponent<SphereTrigger>();
    }

    private void Update()
    {
        Health target = _sphereTrigger.TryGetComponentInTrigger<Health>();

        if (target != null)
            Destroy(gameObject);
    }
}