using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Zenject.CheatSheet;

namespace Assets.Weapons
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private List<Gun> _gunList;
        [SerializeField] private PlayerInput _playerInput;

        private Gun _currentGun;
        private GunSwitcher _gunSwitcher;

        private void Awake()
        {
            _gunSwitcher = new GunSwitcher(_gunList);
            _currentGun = _gunList[0];

            _playerInput.PlayerShoot += Shoot;
            _playerInput.PlayerSwitchGun += SwitchGun;
        }

        public void SwitchGun()
        {
            _gunSwitcher.SwitchGun(ref _currentGun);
        }

        public void Shoot()
        {
            if (_currentGun != null)
                _currentGun.Shoot();
            else
                Debug.Log("Push E to set your weapon");
        }
    }
}
