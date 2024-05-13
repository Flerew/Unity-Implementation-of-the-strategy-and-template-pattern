using System;
using UnityEngine;

namespace Assets.Weapons {
    public class PlayerInput : MonoBehaviour
    {
        public event Action PlayerShoot;
        public event Action PlayerSwitchGun;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                PlayerShoot?.Invoke();
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerSwitchGun?.Invoke();
            }
        }
    }
}