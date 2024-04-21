using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

namespace BomberMan {
    public class EnemyAuthoring : MonoBehaviour {
        public Transform Player;
    }

    public class EnemyBaker : Baker<EnemyAuthoring> {
        public override void Bake(EnemyAuthoring authoring) {
            var entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent(entity, new EnemyComponent { });
            AddComponent(entity, new MoveableComponent { });
            AddComponent(entity, new TargetComponent {
                Target = GetEntity(authoring.Player, TransformUsageFlags.Dynamic)
            });
        }
    };
}