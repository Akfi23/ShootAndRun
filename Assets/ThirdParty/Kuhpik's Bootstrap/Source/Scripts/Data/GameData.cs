using System;
using UnityEngine;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;

namespace Kuhpik
{
    /// <summary>
    /// Used to store game data. Change it the way you want.
    /// </summary>
    [Serializable]
    public class GameData
    {
        public CinemachineVirtualCamera GameCamera;
        public PlayerComponent Player;
        public int GroupStage;

        public LevelComponent Level;
        public List<EnemyGroupComponent> EnemyGroups = new List<EnemyGroupComponent>();
        public List<WayPointComponent> WayPoints = new List<WayPointComponent>();
        public List<GameObject> Bullets = new List<GameObject>();
    }
}