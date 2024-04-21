using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

namespace BomberMan {
    public struct MoveableComponent : IComponentData {
        public float3 Velocity;
    };
}