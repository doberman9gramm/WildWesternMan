using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Item/Weapon/Gun")]
public class Gun : Weapon
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private int _ammo;
    [SerializeField] private bool _isInfinityAmmo;
    [SerializeField] private int _reloadCountAmmo;

    [field: SerializeField] public AudioClip _shootSound { get; private set; }
    private AudioSource _audioSource;

    public void TryShoot(Vector3 muzzle, Quaternion quaternion)
    {
        if (_isInfinityAmmo || Checkbullets())
        {
            DoShoot(muzzle, quaternion);
        }
        else
        {
            Reload();
        }
    }

    private void DoShoot(Vector3 muzzle, Quaternion quaternion)
    {
        Instantiate(_bulletPrefab, muzzle, quaternion);

        if (_audioSource == null)
        {
            _audioSource = new GameObject("Sound", typeof(AudioSource)).GetComponent<AudioSource>();
            _audioSource.spatialBlend = 1f;//3D sound
        }

        _audioSource.PlayOneShot(_shootSound);
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