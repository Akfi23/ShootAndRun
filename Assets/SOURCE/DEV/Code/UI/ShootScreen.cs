using Kuhpik;
using UnityEngine;

public class ShootScreen : UIScreen
{
    [SerializeField] private TargetIndicator healthIndicator;
    public TargetIndicator HealthIndicator => healthIndicator;
}
