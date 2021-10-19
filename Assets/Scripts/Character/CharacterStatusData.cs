using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

[GenerateAuthoringComponent]
public struct CharacterStatusData : IComponentData
{
    public int CurrentHp;
    public int MaxHp;
    public float MaxSpeed;
    public float RotateSpeed;
    public float ShotInterval;
}