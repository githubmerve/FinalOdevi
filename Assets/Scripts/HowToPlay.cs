using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HowToPlay : MonoBehaviour
{
    public static HowToPlay Instance { get; private set; }

    public const string menu = "Menu";

    [SerializeField] private CanvasGroup howToPlayCanvasGroup;
    [SerializeField] private Button turnBackButton;
    [SerializeField] private TMP_Text turnBackText;
    [SerializeField] private Button InformationButton;

    [SerializeField] private float fadeDuration = 1f;
    [SerializeField] private float animationDuration = 0.5f;

    private RectTransform howToPlayRectTransform;

    private void Awake()
    {
        Instance = this;

        turnBackButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(menu);
        });
        
        InformationButton.onClick.AddListener(OnInformationButtonClick); // Bilgi butonuna t�klama olay� ekleniyor

        howToPlayRectTransform = howToPlayCanvasGroup.GetComponent<RectTransform>();
    }

    private void OnInformationButtonClick()
    {
        // Ba�lang�� pozisyonunu ekran�n �st�nden ba�lat�yoruz
        howToPlayRectTransform.anchoredPosition = new Vector2(0, Screen.height);

        // Panelin g�r�n�rl���n� s�f�rl�yoruz
        howToPlayCanvasGroup.alpha = 0;

        // Paneli yukar�dan a�a��ya animasyonla indiriyoruz ve ayn� anda fade animasyonu uyguluyoruz
        Sequence sequence = DOTween.Sequence();
        sequence.Append(howToPlayRectTransform.DOAnchorPos(Vector2.zero, animationDuration).SetEase(Ease.OutBounce));
        sequence.Join(howToPlayCanvasGroup.DOFade(1f, fadeDuration));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
