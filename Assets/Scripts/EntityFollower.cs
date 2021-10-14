using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Transforms;
using Unity.Entities;
using Unity.Mathematics;

public class EntityFollower : MonoBehaviour
{
    public Entity Followed;
    public float3 Offset;

    private EntityManager manager;

    private void Awake()
    {
        manager = World.DefaultGameObjectInjectionWorld.EntityManager;
    }

    private void LateUpdate()
    {
        if (Followed == null)
        {
            return;
        }

        var entityPos = manager.GetComponentData<Translation>(Followed);
        transform.position = entityPos.Value + Offset;
    }
}
