using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    [SerializeField] float totalTime = 90f;
    [SerializeField] int maxScore = 14;
    [SerializeField] CanvasGroup youLostCanvasGroup;
    [SerializeField] TMP_Text gameOverText;
    [SerializeField] Button tryAgainSecondButton;
    [SerializeField] float fadeDuration = 1f;
    [SerializeField] float animationDuration = 0.5f;

    public const string GAME = "Game";
    private int score = 0;
    [SerializeField] private bool isGameOver = false;

    private void Awake()
    {
        tryAgainSecondButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(GAME);
            Debug.Log("Try Again Button Clicked");
        });
    }

    void Update()
    {
        if (!isGameOver)
        {
            if (totalTime > 1)
            {
                totalTime -= Time.deltaTime;

                int minutes = Mathf.FloorToInt(totalTime / 60);
                int seconds = Mathf.FloorToInt(totalTime % 60);
                timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            }
            else
            {
                totalTime = 0;
                ShowYouLostUI();
                Debug.Log("Time's up - ShowYouLostUI called");
            }
        }
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        Debug.Log("Score increased: " + score);

        if (score >= maxScore)
        {
            ShowGameOverUI();
            Debug.Log("Max score reached - ShowGameOverUI called");
        }
    }

    void ShowGameOverUI()
    {
        // Implement the Game Over UI logic
        Debug.Log("Game Over UI shown");
        isGameOver = true; // Stop the timer
    }

    void ShowYouLostUI()
    {
        Debug.Log("You Lost UI shown - Fading in");
        isGameOver = true; // Stop the timer
        youLostCanvasGroup.DOFade(1f, fadeDuration).OnComplete(() =>
        {
            Debug.Log("Fade in complete - Scaling gameOverText and tryAgainSecondButton");
            gameOverText.GetComponent<RectTransform>().DOScale(1f, animationDuration).SetEase(Ease.OutBack).OnComplete(() =>
            {
                tryAgainSecondButton.GetComponent<RectTransform>().DOScale(1f, animationDuration).SetEase(Ease.OutBack);
                youLostCanvasGroup.blocksRaycasts = true;
                tryAgainSecondButton.GetComponent<Image>().raycastTarget = true;
            });
        });
        
    }
    public void IsGameOver()
    {
        isGameOver = true;
    }
}
