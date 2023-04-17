using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LiXimeng;
using LiXimeng.Input;

namespace LiXimeng.Lab1
{
        public class inputManager : MonoBehaviour
        {
            [SerializeField] private MovementControl movementController;
            [SerializeField] private PlayerRespawner playerRespawner;
        private Lab inputScheme;
        private ResetHandler resetHandler;

        public void Awake()
            {
                inputScheme = new Lab();
            Debug.Log(inputScheme);
                 Debug.Log(inputScheme.Player.Move);
                movementController.Initialize(inputScheme.Player.Move);
               resetHandler = new ResetHandler(inputScheme.Player.Reset, playerRespawner);
        }
            public void OnEnable()
            {
                var _ = new QuitHandler(inputScheme.Player.Quit);
        }

    


    }
    }
