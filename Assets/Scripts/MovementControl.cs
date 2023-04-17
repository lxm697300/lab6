using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


namespace LiXimeng.Lab1
{
    
        public class MovementControl : MonoBehaviour
        {
            [SerializeField] private GameObject playerToMove;
            [SerializeField] private float speed = 5f;
            private InputAction moveAction;
             public float horizontalInput;

            public void Initialize(InputAction moveAction)
            {
            this.moveAction = moveAction;
            moveAction.Enable();

            }
            private void FixedUpdate()
            {
            Debug.Log(moveAction);
            Vector2 inputMap = moveAction.ReadValue<Vector2>();
             Vector3 movement = Vector3.forward * inputMap.y + Vector3.right * inputMap.x;
            playerToMove.transform.position += movement * speed * Time.deltaTime;

              }
        }
    }
