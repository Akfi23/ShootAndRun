using Kuhpik;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultSystem : GameSystemWithScreen<ResultScreen>
{
    public override void OnInit()
    {
        game.Player.Animator.SetRunAnim(false);
        screen.Restart.onClick.AddListener(() => RestartGame());
    }

    private void RestartGame()
    {
        Bootstrap.Instance.GameRestart(0);
    }
}
