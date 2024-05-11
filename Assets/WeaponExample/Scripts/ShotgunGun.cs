using UnityEngine;

public class ShotgunGun : LimitedAmmoGun
{
    [SerializeField] private int _bulletsPerShot;
    
    public override void Shoot()
    {
        for (int i = 0; i < _bulletsPerShot; i++)
        {
            TryShoot();
        }
    }
}
