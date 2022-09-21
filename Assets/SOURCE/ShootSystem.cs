using Kuhpik;
using Kuhpik.Pooling;
using System.Collections.Generic;
using UnityEngine;

public class ShootSystem : GameSystem
{
    private Transform gun;
    private Transform shootPoint;

    public override void OnInit()
    {
        gun = game.Player.Gun;
        shootPoint = game.Player.ShootPoint;
    }

    public override void OnStateEnter()
    {
        game.Player.RigIKComponent.SetRigsWeight(1);
    }

    public override void OnUpdate()
    {
        MoveBullets();
    }

    public override void OnLateUpdate()
    {
        RaycastHit hit;
        Ray placeRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(placeRay.origin, placeRay.direction * 100, Color.green);

        Quaternion rot = Quaternion.LookRotation(game.Player.RigIKComponent.ArmTarget.position - gun.transform.position);
        gun.rotation = rot;

        if (Physics.Raycast(placeRay, out hit, 100))
        {
            game.Player.RigIKComponent.ArmTarget.transform.position = hit.point;
        }

        if (Input.GetMouseButtonDown(0))
        {
            GetBullet();
        }
    }

    private void MoveBullets()
    {
        if (game.Bullets.Count > 0)
        {
            foreach (var bul in game.Bullets)
            {
                if (bul.activeSelf)
                    bul.transform.position += bul.transform.forward * Time.deltaTime * 20;
            }
        }
    }

    private GameObject GetBullet()
    {
        GameObject projectile = PoolingSystem.GetObject(config.BulletPrefab.gameObject);
        projectile.transform.position = shootPoint.transform.position;
        projectile.transform.forward = gun.forward;
        return projectile;
    }
}
