using UnityEngine;

public class ShotgunGun : Gun
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private Transform _startShootPosition;
    [SerializeField] private int _bulletCount;
    [SerializeField] private int _bulletsPerShot;

    protected override IShootable Shootable => _bulletPrefab.GetComponent<IShootable>();

    protected override float BulletSpeed => _bulletSpeed;

    protected override Vector3 BulletDirection => _startShootPosition.forward;

    public override void Shoot()
    {
        for (int i = 0; i < _bulletsPerShot; i++)
        {
            if (_bulletCount > 0)
            {
                GameObject bulletObject = Instantiate(Shootable.BulletPrefab, _startShootPosition.position, Quaternion.identity);
                if (bulletObject.TryGetComponent(out Rigidbody rb))
                {
                    rb.AddForce(BulletDirection * BulletSpeed, ForceMode.Impulse);
                    _bulletCount -= 1;
                }
            }
        }
    }
}