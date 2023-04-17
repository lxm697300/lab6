using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace LiXimeng.Lab1
{
    public class ResetHandler
    {
        private PlayerRespawner _playerRespawner;
        public ResetHandler(InputAction respawn, PlayerRespawner playerRespawner)
        {
            _playerRespawner = playerRespawner;
            respawn.performed += PlayerResoawn_Performed;
            respawn.Enable();
        }





        // Update is called once per frame
        private void PlayerResoawn_Performed(InputAction.CallbackContext obj)
        {
            _playerRespawner.Respawn();
        }
    }
}
