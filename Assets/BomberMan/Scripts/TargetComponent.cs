using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

namespace BomberMan {
    public struct TargetComponent : IComponentData {
        public Entity Target;
    };
}