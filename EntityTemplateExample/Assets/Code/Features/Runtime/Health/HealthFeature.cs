namespace Code.Features.Runtime.Health
{
    using System;
    using UnityEngine;

    [Serializable]
    public sealed class HealthFeature : IEntityFeature
    {
        [SerializeField]
        private float _maxHealth = 100.0f;
        // something
        public void Compose(GameObject target)
        {
            var healthComponent = target.AddComponent<HealthComponent>();
            // initialization of health component
        }
    }
}