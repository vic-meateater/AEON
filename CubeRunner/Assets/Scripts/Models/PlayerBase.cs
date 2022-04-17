using CubeRunner.Interfaces;
using UnityEngine;


namespace CubeRunner
{
    [RequireComponent(typeof(Rigidbody))]
    public abstract class PlayerBase : MonoBehaviour, IMoveable
    {
        [SerializeField] private float _speed;
        protected float Speed => _speed;
        
        public abstract void Move(float x, float y, float z);
    }
}