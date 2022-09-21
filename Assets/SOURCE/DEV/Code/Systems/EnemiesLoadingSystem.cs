using Kuhpik;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemiesLoadingSystem : GameSystem
{
    public override void OnInit()
    {
        game.EnemyGroups = game.Level.GetComponentsInChildren<EnemyGroupComponent>().ToList();

        foreach (var group in game.EnemyGroups)
        {
            group.InitGroup();
        }
    }
}
