using Kuhpik;
using Kuhpik.Pooling;
using Supyrb;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LoadingSystem : GameSystem
{
    public override void OnInit()
    {
        Application.targetFrameRate = 90;
        Signals.Clear();

        game.Level = FindObjectOfType<LevelComponent>();
        FindWayPoints();
    }

    private void FindWayPoints()
    {
        game.WayPoints = game.Level.GetComponentsInChildren<WayPointComponent>().ToList();
    }
}
