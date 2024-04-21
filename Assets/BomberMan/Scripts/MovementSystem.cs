using Unity.Entities;
using Unity.Transforms;
using Unity.Burst;
using Unity.Mathematics;

namespace BomberMan {
    [BurstCompile]
    public partial struct MovementSystem : ISystem {
        [BurstCompile]
        public void OnUpdate(ref SystemState state) {
            float deltaTime = SystemAPI.Time.DeltaTime;
            foreach (var (movement, transform) in SystemAPI.Query<RefRO<MoveableComponent>, RefRW<LocalTransform>>()) {
                transform.ValueRW.Position += deltaTime * movement.ValueRO.Velocity;
            }
        }
    }
}