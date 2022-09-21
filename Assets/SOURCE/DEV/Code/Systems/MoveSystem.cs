using Kuhpik;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : GameSystem
{
    public override void OnStateEnter()
    {
        RunToWayPoint();
        game.Player.RigIKComponent.SetRigsWeight(0);
    }

    [Button]
    private void RunToWayPoint()
    {
        game.Player.Animator.SetRunAnim(true);

        if (game.GroupStage < game.WayPoints.Count)
        {
            game.Player.Agent.SetDestination(game.WayPoints[game.GroupStage].transform.position);
        }
        else
        {
            Bootstrap.Instance.ChangeGameState(GameStateID.Result);
        }
    }
}
