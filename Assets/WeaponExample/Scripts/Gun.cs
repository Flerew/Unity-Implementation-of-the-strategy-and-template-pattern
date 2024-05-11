using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private Transform _startShootPosition;

    protected Bullet Bullet => _bullet;
    protected float BulletSpeed => _bulletSpeed;
    protected Vector3 BulletDirection => _startShootPosition.forward;

    public virtual void Shoot()
    {
        GameObject bullet = Bullet.Spawn(_startShootPosition.position);
        if (bullet.TryGetComponent(out Bullet component))
        {
            component.GetRigidbody().AddForce(BulletDirection * BulletSpeed, ForceMode.Impulse);
        }
    }
}
