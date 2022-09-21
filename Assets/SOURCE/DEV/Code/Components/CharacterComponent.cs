using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(AnimatorComponent))]
public class CharacterComponent : MonoBehaviour
{
    [SerializeField] protected int maxHealth;
    [SerializeField] protected int currentHealth;

    protected NavMeshAgent agent;
    protected AnimatorComponent animator;
    protected Collider col;

    public NavMeshAgent Agent => agent;
    public AnimatorComponent Animator => animator;
    public int CurrentHealth => currentHealth;
    public int MaxHealth => maxHealth;
    public Collider Collider => col;

    public virtual void Init()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<AnimatorComponent>();
        animator.InitAnimator();
        col = GetComponent<Collider>();
    }
}
