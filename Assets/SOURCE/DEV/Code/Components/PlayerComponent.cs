using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerComponent : CharacterComponent
{
    [SerializeField] private Transform gun;
    [SerializeField] private Transform shootPoint;
    private RigIKComponent rigComponent;
    public RigIKComponent RigIKComponent => rigComponent;
    public Transform Gun => gun;
    public Transform ShootPoint => shootPoint;

    public override void Init()
    {
        base.Init();

        rigComponent = GetComponent<RigIKComponent>();
    }
}
