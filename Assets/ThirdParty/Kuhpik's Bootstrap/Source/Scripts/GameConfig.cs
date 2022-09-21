using UnityEngine;
using NaughtyAttributes;

namespace Kuhpik
{
    [CreateAssetMenu(menuName = "Config/GameConfig")]
    public sealed class GameConfig : ScriptableObject
    {
        [SerializeField] private float bulletMoveSpeed;
        [SerializeField] private GameObject bulletPrefab;

        public float BulletSpeed => bulletMoveSpeed;
        public GameObject BulletPrefab => bulletPrefab;
    }
}