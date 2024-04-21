using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;

namespace BomberMan {
    public readonly partial struct TargetAspect : IAspect {
        readonly RefRO<TargetComponent> m_target;
        public Entity Target => m_target.ValueRO.Target;
    }
}
