using Unity.Entities;
using Unity.Transforms;
using Unity.Burst;
using Unity.Mathematics;

namespace BomberMan {
    [BurstCompile]
    public partial struct FollowingSystem : ISystem {
        public void OnCreate(ref SystemState state) { }

        public void OnDestroy(ref SystemState state) { }

        [BurstCompile]
        public void OnUpdate(ref SystemState state) {
            RefRO<LocalTransform> nearest = new();

            foreach (var (player, transform) in SystemAPI.Query<RefRO<PlayerComponent>, RefRO<LocalTransform>>()) {
                nearest = transform;
            }

            foreach (var (enemy, transform) in SystemAPI.Query<RefRW<EnemyComponent>, RefRO<LocalTransform>>()) {
                enemy.ValueRW.Velocity = nearest.ValueRO.Position - transform.ValueRO.Position;
            }

            float deltaTime = SystemAPI.Time.DeltaTime;
            foreach (var (enemy, transform) in SystemAPI.Query<RefRO<EnemyComponent>, RefRW<LocalTransform>>()) {
                transform.ValueRW.Position += deltaTime * enemy.ValueRO.Velocity;
            }
        }
    }
}