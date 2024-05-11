using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour, IShootable
{
    public GameObject BulletPrefab => gameObject;

    public GameObject Spawn(Vector3 spawnPos)
    {
        return Instantiate(BulletPrefab, spawnPos, Quaternion.identity); 
    }
    public Rigidbody GetRigidbody()
    {
        return GetComponent<Rigidbody>();
    }

}
