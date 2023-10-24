using UnityEngine;
using HealthSpace;

public abstract class Weapon : Item
{
    [SerializeField] private float _damage;
    [SerializeField] private float _cooldown;
    [SerializeField] private float _bullets;
    private float _lastShoot;

    protected void Attack(Health target)
    {
        if (IsCoolDown())
            return;
        if (Checkbullets())
            return;

        target.GetDamage(_damage);
    }

    private bool Checkbullets()
    {
        if (_bullets <= 0)
        {
            Debug.Log("No bullets!");
            return false;
        }
        _bullets--;
        return true;
    }

    private bool IsCoolDown()
    {
        if (Time.time - _lastShoot < _cooldown)
            return true;
        _lastShoot = Time.time;

        return false;
    }
}