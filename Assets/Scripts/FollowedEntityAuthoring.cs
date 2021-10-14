using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class FollowedEntityAuthoring : MonoBehaviour, IConvertGameObjectToEntity
{
    public GameObject Follower;

    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        EntityFollower entityFollower = Follower.GetComponent<EntityFollower>();
        if (entityFollower == null)
        {
            Follower.AddComponent<EntityFollower>();
        }
        entityFollower.Followed = entity;
    }
}
