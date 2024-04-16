using System;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    protected abstract IShootable Shootable { get; }
    protected abstract float BulletSpeed { get; }
    protected abstract Vector3 BulletDirection { get; }

    public abstract void Shoot();
}
