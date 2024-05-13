using System.Collections.Generic;
using UnityEngine;

public class GunSwitcher
{ 
    private List<Gun> _gunList;

    public GunSwitcher(List<Gun> gunList)
    {
        _gunList = gunList;
    }

    public void SwitchGun(ref Gun gun)
    {
        if (gun != null)
        {
            DisableGuns();
            int index = _gunList.IndexOf(gun);

            if (index < 0 || index + 1 >= _gunList.Count)
                gun = _gunList[0];
            else
                gun = _gunList[index + 1];

            EnableGun(gun);
        }
        else
        {
            gun = _gunList[0];
        }
    }

    private void DisableGuns()
    {
        foreach (Gun gun in _gunList)
        {
            gun.gameObject.SetActive(false);
        }
    }

    private void EnableGun(Gun gun)
    {
        gun.gameObject.SetActive(true);
    }
}
