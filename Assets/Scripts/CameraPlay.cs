using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using LiXimeng.Lab1;

namespace LiXimeng.Lab1
{

    public class CameraPlay : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField] private GameObject playerToMove;

        public float sen;
        private InputAction moveAction;

        float xRotation;
        float yRotation;
        float speed = 5f;

        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        public void Initialize(InputAction moveAction)
        {
            this.moveAction = moveAction;
            moveAction.Enable();

        }

        // Update is called once per frame
        private void FixedUpdate()
        {
            Vector2 mouseInput = moveAction.ReadValue<Vector2>();
            float mouseX = mouseInput.x * sen;
            float mouseY = mouseInput.y * sen;

            yRotation += mouseX;
            xRotation -= mouseY;

            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            Quaternion rotation = Quaternion.Euler(xRotation, yRotation, 0f);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, speed * 100);
            playerToMove.transform.rotation = Quaternion.RotateTowards(playerToMove.transform.rotation, Quaternion.Euler(0, yRotation, 0), speed);




        }
    }
}
