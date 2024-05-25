using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameBoard : MonoBehaviour
{
    public static GameBoard Instance { get; private set; }

    public const string GAME = "Game";

    [Header("References")]
    [SerializeField] private CanvasGroup gameOverCanvasGroup;
    [SerializeField] private Button tryAgainButton;
    [SerializeField] private TMP_Text gameOverText;
    [SerializeField] private Timer timer;



    [Header("Settings")]
    [SerializeField] private float fadeDuration = 1f;
    [SerializeField] private float animationDuration = 0.5f;

    private int maxScore = 14;
    private int score;

    private void Awake()
    {
        Instance = this;

        tryAgainButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(GAME);
        });
    }

    public void IncreaseScore(int amount)
    {
        score += amount;

        if (score >= maxScore)
        {
            timer.IsGameOver();
            gameOverCanvasGroup.DOFade(1f, fadeDuration).OnComplete(() =>
            {
                gameOverText.GetComponent<RectTransform>().DOScale(1f, animationDuration).SetEase(Ease.OutBack).OnComplete(() =>
                {
                    tryAgainButton.GetComponent<RectTransform>().DOScale(1f, animationDuration).SetEase(Ease.OutBack);
                    gameOverCanvasGroup.blocksRaycasts = true;
                    tryAgainButton.GetComponent<Image>().raycastTarget = true;
                });
            });
               
        }
    }
}
