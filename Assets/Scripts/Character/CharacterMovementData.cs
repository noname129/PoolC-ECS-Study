using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

[GenerateAuthoringComponent]
public struct CharacterMovementData : IComponentData
{
    public float ShotCooldown;
    public float CurrentSpeed;
    public int RotateDir;
}