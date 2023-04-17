using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LiXimeng.Lab1
{
    public class PlayerRespawner : MonoBehaviour
    {
        [SerializeField] private GameObject character;
        private Vector3 location;
        private Quaternion rotation;

        public void Awake()
        {
            location = character.transform.position;
            rotation = character.transform.rotation;
        }

        // Update is called once per frame
        public void Respawn()
        {
            character.transform.position = location;
            character.transform.rotation = rotation;
        }
    }
}
