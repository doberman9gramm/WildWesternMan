using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Item/Weapon/Gun")]
public class Gun : Weapon
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private int _ammo;
    [SerializeField] private bool _isInfinityAmmo;
    [SerializeField] private int _reloadCountAmmo;

    public void TryShoot(Vector3 muzzle, Quaternion quaternion)
    {
        if (_isInfinityAmmo || Checkbullets())
        {
            Shoot(muzzle, quaternion);
        }
        else
        {
            Reload();
        }
    }

    private void Shoot(Vector3 muzzle, Quaternion quaternion)
    {
        //Debug.Log("Shoot");
        Instantiate(_bulletPrefab, muzzle, quaternion);
    }

    private void Reload()
    {
        Debug.Log("Reload");
        _ammo = _reloadCountAmmo;
    }

    private bool Checkbullets()
    {
        if (_ammo <= 0)
        {
            Debug.Log("No bullets!");
            return false;
        }
        _ammo--;
        return true;
    }
}