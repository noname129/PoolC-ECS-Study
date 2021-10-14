using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Entities;
using Unity.Jobs;

public class PlayerInputSystem : SystemBase
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;

        Entities.ForEach((ref Translation translation, in CameraMovementData movementData) => {
            Vector2 displacement = new Vector2();

            if (Input.GetKey(KeyCode.W))
            {
                displacement.y += movementData.Speed;
            }
            if (Input.GetKey(KeyCode.S))
            {
                displacement.y -= movementData.Speed;
            }
            if (Input.GetKey(KeyCode.A))
            {
                displacement.x -= movementData.Speed;
            }
            if (Input.GetKey(KeyCode.D))
            {
                displacement.x += movementData.Speed;
            }

            translation.Value.x = math.clamp(translation.Value.x + displacement.x * deltaTime,
                -movementData.BoundaryHorizontal, movementData.BoundaryHorizontal);
            translation.Value.y = math.clamp(translation.Value.y + displacement.y * deltaTime,
                -movementData.BoundaryHorizontal, movementData.BoundaryHorizontal);
        }).Run();
    }
}
