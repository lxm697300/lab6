using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LiXimeng.Lab1;

namespace LiXimeng.Lab1
{
    public class FollowOffset : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private Vector3 offset;

        private void Update()
        {
            transform.position = target.position + offset;
        }
    }
}
