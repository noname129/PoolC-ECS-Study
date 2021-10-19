using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Entities;
using Unity.Jobs;

public class CharacterMovementSystem : SystemBase
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;

        Entities.ForEach((ref Translation translation, in Rotation rotation, in CharacterMovementData movementData) => {
            var direction = math.mul(rotation.Value, new float3(0, 1, 0));
            translation.Value.x += movementData.CurrentSpeed * deltaTime * direction.x;
            translation.Value.y += movementData.CurrentSpeed * deltaTime * direction.y;
        }).Run();
    }
}
