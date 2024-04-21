using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

namespace BomberMan {
    public struct EnemyComponent : IComponentData {
        public float3 Velocity;
    };
}