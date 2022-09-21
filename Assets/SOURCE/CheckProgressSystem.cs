using Kuhpik;
using Supyrb;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckProgressSystem : GameSystem
{
    public override void OnInit()
    {
        Signals.Get<OnEnemyHit>().AddListener(CheckProgress);
    }

    private void CheckProgress(EnemyComponent enemy) // Remove parameter later
    {
        if (!game.EnemyGroups[game.GroupStage].FindAliveEnemy()) return;

        game.GroupStage++;
        Bootstrap.Instance.ChangeGameState(GameStateID.Move);
    }
}
