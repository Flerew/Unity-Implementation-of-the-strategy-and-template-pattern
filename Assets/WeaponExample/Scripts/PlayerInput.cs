using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Gun gun;

    private GunSwitcher gunSwitcher;

    private void Awake()
    {
        gunSwitcher = GetComponent<GunSwitcher>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (gun != null)
                gun.Shoot();
            else
                Debug.Log("Push E to set your weapon");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            gunSwitcher.SwitchGun(ref gun);
        }
    }
}
