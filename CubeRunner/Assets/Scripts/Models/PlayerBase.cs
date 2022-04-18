using System;
using UnityEngine;
using CubeRunner.Interfaces;

namespace CubeRunner
{
    [RequireComponent(typeof(Rigidbody))]
    public abstract class PlayerBase : MonoBehaviour, IMoveable
    {
        [SerializeField] private float _speed;
        protected float Speed => _speed;
        public Action<Collider> OnLevelObjectContact { get; set; }
        
        public abstract void Move(float x, float y, float z);

        private void OnTriggerEnter(Collider other)
        {
            OnLevelObjectContact?.Invoke(other);
        }
    }
}