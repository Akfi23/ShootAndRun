using DG.Tweening;
using Kuhpik;
using Supyrb;
using System.Collections;
using UnityEngine;

public class EnemyHPViewerSystem : GameSystemWithScreen<ShootScreen>
{
    private IEnumerator showBarRoutine;
    public override void OnInit()
    {
        Signals.Get<OnEnemyHit>().AddListener(ShowEnemyHPBar);
        screen.HealthIndicator.InitialiseTargetIndicator(Camera.main,UIManager.Canvas);
        screen.HealthIndicator.gameObject.SetActive(false);
    }

    private void ShowEnemyHPBar(EnemyComponent enemy)
    {
        if (showBarRoutine != null)
            StopCoroutine(showBarRoutine);

        showBarRoutine = ShowBarRoutine(enemy);
        StartCoroutine(showBarRoutine);
    }

    private IEnumerator ShowBarRoutine(EnemyComponent enemy)
    {
        if (!screen.HealthIndicator.gameObject.activeSelf)
            screen.HealthIndicator.gameObject.SetActive(true);

        screen.HealthIndicator.SetNewTarget(enemy.gameObject);
        screen.HealthIndicator.CurrentHealth.fillAmount = 1f / enemy.MaxHealth * enemy.CurrentHealth;
        screen.HealthIndicator.FakeHealth.fillAmount = 1f / enemy.MaxHealth * (enemy.CurrentHealth + 1);
        screen.HealthIndicator.FakeHealth.DOFillAmount(screen.HealthIndicator.CurrentHealth.fillAmount, 0.3f).SetEase(Ease.Linear);

        yield return new WaitForSeconds(1f);
        screen.HealthIndicator.gameObject.SetActive(false);
    }
}
