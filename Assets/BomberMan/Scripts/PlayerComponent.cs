using Unity.Entities;
using Unity.Mathematics;

namespace BomberMan {
    public struct PlayerComponent : IComponentData {
        public float3 Velocity;
    }
}