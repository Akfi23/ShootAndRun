using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class RigIKComponent : MonoBehaviour
{
    [Header("RIG Stuff")]
    [HorizontalLine(2,EColor.Green)]
    [SerializeField] private RigBuilder rigBuilder;
    [SerializeField] private MultiAimConstraint headConstraint;
    [SerializeField] private MultiAimConstraint spineConstraint;
    [SerializeField] private Rig rigBody;
    [SerializeField] private Rig rigArm;
    [Header("Bones")]
    [HorizontalLine(2, EColor.Blue)]
    [SerializeField] private Transform bodyTarget;
    [SerializeField] private Transform armTarget;

    public RigBuilder RigBuilder => rigBuilder;
    public MultiAimConstraint HeadConstraint => headConstraint;
    public MultiAimConstraint SpineConstraint => spineConstraint;
    public Transform BodyTarget => bodyTarget;
    public Transform ArmTarget => armTarget;


    public void SetRigsWeight(float value)
    {
        rigBody.weight = value;
        rigArm.weight = value;
    }
}
