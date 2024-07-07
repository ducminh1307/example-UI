using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeCtroller : MonoBehaviour
{
    [SerializeField] private int maxPage;
    private int currentPage;
    Vector3 targetPos;
    [SerializeField] private Vector3 pageStep;
    [SerializeField] private RectTransform detailPage;

    [SerializeField] private float tweenTime;
    [SerializeField] private LeanTweenType tweenType;

    private void Awake()
    {
        currentPage = 1;
        targetPos = detailPage.localPosition;
    }

    public void Next()
    {
        if (currentPage < maxPage)
        {
            currentPage++;
            targetPos -= pageStep;
            MovePage();
        }
    }

    public void Previous()
    {
        if (currentPage > 1)
        {
            currentPage--;
            targetPos += pageStep;
            MovePage();
        }
    }

    private void MovePage()
    {
        detailPage.LeanMoveLocal(targetPos, tweenTime).setEase(tweenType);
    }
}