using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace BomberMan {
    public class PlayerAuthoring : MonoBehaviour {

    }

    public class PlayerBaker : Baker<PlayerAuthoring> {
        public override void Bake(PlayerAuthoring authoring) {
            var entity = GetEntity(TransformUsageFlags.None);
            AddComponent(entity, new PlayerComponent {
                Velocity = new float3(0, 0, 0)
            });
        }
    }
}