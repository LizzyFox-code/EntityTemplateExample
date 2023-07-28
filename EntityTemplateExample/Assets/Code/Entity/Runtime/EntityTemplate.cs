namespace Code.Entity.Runtime
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Features.Runtime;
    using UnityEngine;

    [Serializable]
    [CreateAssetMenu(fileName = nameof(EntityTemplate), menuName = nameof(EntityTemplate))]
    public sealed class EntityTemplate : ScriptableObject, IEnumerable<IEntityFeature>
    {
        [field: SerializeField]
        public string Name { get; private set; }
        
        [SerializeReference]
        private List<IEntityFeature> _features = new List<IEntityFeature>();

        public IEnumerator<IEntityFeature> GetEnumerator()
        {
            return _features.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}