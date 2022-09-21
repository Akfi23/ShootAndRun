using DG.Tweening;
using Kuhpik;
using Kuhpik.Pooling;
using Supyrb;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepareToShootSystem : GameSystem
{
    public override void OnInit()
    {
        Signals.Get<OnTriggerCollide>().AddListener(GoToShootState);
        PrepareBullets();
    }

    private void PrepareBullets()
    {
        int poolCapacity = PoolInstaller.Instance.GetPool("BulletPool").Capacity;

        for (int i = 0; i < poolCapacity; i++)
        {
            GameObject projectile = PoolingSystem.GetObject(config.BulletPrefab.gameObject);
            game.Bullets.Add(projectile);
        }

        foreach (var bullet in game.Bullets)
        {
            bullet.SetActive(false);
        }
    }

    private void GoToShootState()
    {
        game.Player.Agent.ResetPath();
        game.Player.Animator.SetRunAnim(false);
        game.Player.transform.DOKill();
        game.Player.transform.DORotate(game.WayPoints[game.GroupStage].transform.rotation.eulerAngles, 0.3f);
        Bootstrap.Instance.ChangeGameState(GameStateID.Shoot);
    }
}
