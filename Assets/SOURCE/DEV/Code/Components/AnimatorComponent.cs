using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimatorComponent : MonoBehaviour
{
    private Animator animator;
    public Animator Animator => animator;

    private int MoveHash = Animator.StringToHash("IsMove");

    public void InitAnimator()
    {
        animator = GetComponent<Animator>();
    }

    public void SetRunAnim(bool status)
    {
        animator.SetBool(MoveHash, status);
    }
}
