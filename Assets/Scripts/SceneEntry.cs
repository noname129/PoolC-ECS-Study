using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Entities;

public class SceneEntry : MonoBehaviour
{
    public GameObject CharacterPrefab;
    public int CharacterCount;

    // Start is called before the first frame update
    void Start()
    {
        var settings = GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld, null);
        var prefab = GameObjectConversionUtility.ConvertGameObjectHierarchy(CharacterPrefab, settings);
        var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

        for (int i = 0; i < CharacterCount; ++i)
        {
            var instance = entityManager.Instantiate(prefab);
            var position = new float3(UnityEngine.Random.Range(-10.0f, 10.0f), UnityEngine.Random.Range(-10.0f, 10.0f), 0.0f);
            var rotation = Quaternion.Euler(0.0f, 0.0f, UnityEngine.Random.Range(0.0f, 360.0f));
            entityManager.SetComponentData(instance, new Translation { Value = position });
            entityManager.SetComponentData(instance, new Rotation { Value = rotation });
            entityManager.SetComponentData(instance, new CharacterMovementData { CurrentSpeed = 0.1f });
        }
    }
}
