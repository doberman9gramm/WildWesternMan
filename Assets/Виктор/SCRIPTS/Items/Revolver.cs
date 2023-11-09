using UnityEngine;

public class Revolver : MonoBehaviour , IGun
{
    [SerializeField] private Gun _gun;
    [SerializeField] private Vector3 _muzzle;

    public void TryShoot() => _gun.TryShoot(_muzzle + transform.position, transform.rotation);

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(_muzzle + transform.position, .1f);
    }
}