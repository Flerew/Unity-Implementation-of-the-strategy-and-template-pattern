using UnityEngine;

public interface IShootable
{
    GameObject BulletPrefab { get; }
    Color BulletColor { get; }

    void SetColor();
}
