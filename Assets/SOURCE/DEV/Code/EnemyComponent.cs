using NaughtyAttributes;
using Supyrb;
using System;
using UnityEngine;


public class EnemyComponent : CharacterComponent
{
    [SerializeField] private Rigidbody[] bones;
    private OnEnemyHit hitSignal;

    [Button]
    public override void Init()
    {
        base.Init();

        hitSignal = Signals.Get<OnEnemyHit>();
        bones = GetComponentsInChildren<Rigidbody>();
        SetRagdoll(false);
    }

    public void SetRagdoll(bool status)
    {
        foreach (var bone in bones)
        {
            bone.isKinematic = !status;
        }
    }

    public void TakeDamage()
    {
        if (currentHealth < 0) return;

        currentHealth--;
        hitSignal.Dispatch(this);

        if (currentHealth <= 0)
            Die();
    }

    [Button]
    private void Die()
    {
        animator.Animator.enabled = false;
        col.enabled = false;
        SetRagdoll(true);
    }
}
