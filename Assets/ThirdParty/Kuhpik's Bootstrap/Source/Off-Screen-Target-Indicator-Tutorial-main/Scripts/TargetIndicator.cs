using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetIndicator : MonoBehaviour
{
    [SerializeField] private Image currentHealth;
    [SerializeField] private Image fakeHealth;
    private GameObject target;
    private Camera mainCamera;
    private RectTransform canvasRect;
    private RectTransform rectTransform;

    public Image CurrentHealth => currentHealth;
    public Image FakeHealth => fakeHealth;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void InitialiseTargetIndicator(Camera mainCamera, Canvas canvas, GameObject target = null)
    {
        this.target = target;
        this.mainCamera = mainCamera;
        canvasRect = canvas.GetComponent<RectTransform>();
    }

    public void SetNewTarget(GameObject target)
    {
        this.target = target;
        UpdateTargetIndicator();
    }

    public void UpdateTargetIndicator()
    {
        SetIndicatorPosition();
    }

    protected void SetIndicatorPosition()
    {

        Vector3 indicatorPosition = mainCamera.WorldToScreenPoint(target.transform.position+Vector3.up * 3);

        if (indicatorPosition.z >= 0f & indicatorPosition.x <= canvasRect.rect.width * canvasRect.localScale.x
         & indicatorPosition.y <= canvasRect.rect.height * canvasRect.localScale.x & indicatorPosition.x >= 0f & indicatorPosition.y >= 0f)
        {

            indicatorPosition.z = 0f;
        }
        else if (indicatorPosition.z >= 0f)
        {
            indicatorPosition = OutOfRangeindicatorPositionB(indicatorPosition);
        }
        else
        {
            indicatorPosition *= -1f;

            indicatorPosition = OutOfRangeindicatorPositionB(indicatorPosition);
        }

        rectTransform.position = indicatorPosition;
    }

    private Vector3 OutOfRangeindicatorPositionB(Vector3 indicatorPosition)
    {
        indicatorPosition.z = 0f;

        Vector3 canvasCenter = new Vector3(canvasRect.rect.width / 2f, canvasRect.rect.height / 2f, 0f) * canvasRect.localScale.x;
        indicatorPosition += canvasCenter;
        return indicatorPosition;
    }   
}
