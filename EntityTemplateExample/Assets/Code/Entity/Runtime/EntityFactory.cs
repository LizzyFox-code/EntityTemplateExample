namespace Code.Entity.Runtime
{
    using UnityEngine;
    using Utilities.Runtime;

    public sealed class EntityFactory : IFactory<EntityTemplate, GameObject>
    {
        public GameObject Create(EntityTemplate data)
        {
            var target = new GameObject(data.Name);
            foreach (var feature in data)
            {
                feature.Compose(target);
            }

            return target;
        }
    }
}