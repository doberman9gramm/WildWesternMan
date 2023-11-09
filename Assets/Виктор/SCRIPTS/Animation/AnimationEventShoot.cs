using UnityEngine;

public class AnimationEventShoot : MonoBehaviour
{
    [SerializeField] private GameObject _currentGun;

    public void Shoot() 
    {
        if (_currentGun.TryGetComponent(out IGun gun))//“€жела€ операци€ это костыль
            gun.TryShoot(); 
    } 
}