using Kuhpik;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapToStartScreen : UIScreen
{
    [SerializeField] private Button startGameButton;
    public Button StartGame => startGameButton;
}
