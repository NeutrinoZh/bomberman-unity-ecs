using Unity.Entities;
using Unity.Burst;
using Unity.Transforms;
using Unity.Mathematics;

namespace BomberMan {
    [BurstCompile]
    public partial struct FollowingSystem : ISystem {
        [BurstCompile]
        public void OnUpdate(ref SystemState state) {
            foreach (var (target, transform, moveable) in SystemAPI.Query<TargetAspect, RefRO<LocalTransform>, RefRW<MoveableComponent>>()) {
                var targetPosition = SystemAPI.GetComponent<LocalToWorld>(target.Target).Position;
                moveable.ValueRW.Velocity = math.normalizesafe(targetPosition - transform.ValueRO.Position);
            }
        }
    }
}