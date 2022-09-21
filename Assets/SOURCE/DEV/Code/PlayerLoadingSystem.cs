using Kuhpik;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoadingSystem : GameSystem
{
    public override void OnInit()
    {
        game.Player = FindObjectOfType<PlayerComponent>();
        game.Player.Init();
    }
}
