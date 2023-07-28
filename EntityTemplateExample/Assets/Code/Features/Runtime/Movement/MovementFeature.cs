namespace Code.Features.Runtime.Movement
{
    using System;
    using UnityEngine;

    [Serializable]
    public sealed class MovementFeature : IEntityFeature
    {
        [SerializeField]
        private float _speed = 1.0f;
        [SerializeField]
        private float _maxSpeed = 2.0f;
        [SerializeField]
        private float _minSpeed = 0.1f;

        // something
        public void Compose(GameObject target)
        {
            var movementComponent = target.AddComponent<MovementComponent>();
            // initialization of movement component
        }
    }
}