using UnityEngine;

public abstract class LimitedAmmoGun : Gun
{
    [SerializeField] private int _ammoCount;

    public bool IsEnoughAmmo => _ammoCount > 0;

    public override void Shoot()
    {
        TryShoot();
    }

    protected bool TryShoot()
    {
        if (IsEnoughAmmo)
        {
            base.Shoot();
            _ammoCount--;
            return true;
        }
        else
        {
            return false;
        }
    }
}
