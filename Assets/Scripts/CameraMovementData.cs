using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

[GenerateAuthoringComponent]
public struct CameraMovementData : IComponentData
{
    public float Speed;
    public float MinZ;
    public float MaxZ;

    public float BoundaryHorizontal;
    public float BoundaryVertical;
}
