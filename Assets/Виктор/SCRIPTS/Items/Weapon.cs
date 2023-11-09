using UnityEngine;
using HealthSpace;

public abstract class Weapon : Item
{
    [SerializeField] private float _damage;
    [SerializeField] private float _cooldown;
    private float _lastShoot;

    protected void Attack(Health target)
    {
        if (IsCoolDown())
            return;

        target.GetDamage(_damage);
    }

    private bool IsCoolDown()
    {
        if (Time.time - _lastShoot < _cooldown)
            return true;
        _lastShoot = Time.time;

        return false;
    }
}