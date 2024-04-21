using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

namespace BomberMan {
    public class EnemyAuthoring : MonoBehaviour {
    }

    public class EnemyBaker : Baker<EnemyAuthoring> {
        public override void Bake(EnemyAuthoring authoring) {
            var entity = GetEntity(TransformUsageFlags.None);
            AddComponent(entity, new EnemyComponent {
                Velocity = new float3()
            });
        }
    };
}