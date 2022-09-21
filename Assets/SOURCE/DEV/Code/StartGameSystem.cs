using Kuhpik;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameSystem : GameSystemWithScreen<TapToStartScreen>
{
    public override void OnInit()
    {
        screen.StartGame.onClick.AddListener(() =>StartGame());
    }

    private void StartGame()
    {
        Bootstrap.Instance.ChangeGameState(GameStateID.Move);
    }
}
