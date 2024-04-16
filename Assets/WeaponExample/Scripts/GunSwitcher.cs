using System.Collections.Generic;
using UnityEngine;

public class GunSwitcher : MonoBehaviour
{
    [SerializeField] private List<Gun> gunList;

    public void SwitchGun(ref Gun gun)
    {
        int index = gunList.IndexOf(gun);

        if (index < 0 || index + 1 >= gunList.Count) 
            gun = gunList[0];
        else
            gun = gunList[index + 1];
    }
}
