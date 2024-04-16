using UnityEngine;

public class RevolverGun : Gun
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private Transform _startShootPosition;

    protected override IShootable Shootable => _bulletPrefab.GetComponent<IShootable>();

    protected override float BulletSpeed => _bulletSpeed;

    protected override Vector3 BulletDirection => _startShootPosition.forward;

    public override void Shoot()
    {
        GameObject bulletObject = Instantiate(Shootable.BulletPrefab, _startShootPosition.position, Quaternion.identity);
        if (bulletObject.TryGetComponent(out Rigidbody rb))
        {
            rb.AddForce(BulletDirection * BulletSpeed, ForceMode.Impulse);
        }
    }
}
