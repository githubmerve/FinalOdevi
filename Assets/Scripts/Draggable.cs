using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class Draggable : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [Header("References")]
    [SerializeField] private Canvas _canvas;
    [SerializeField] private Slot slot;

    [Header("Settings")]
    [SerializeField] private float animationDuration = 0.5f;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector2 startPosition;

    private void Awake() 
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    private void Start() 
    {
        startPosition = rectTransform.anchoredPosition;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        rectTransform.SetAsLastSibling();
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / _canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if(!slot.IsOccupied())
        {
            rectTransform.DOAnchorPos(startPosition, animationDuration).SetEase(Ease.OutBack).OnComplete(() =>
            {
                canvasGroup.blocksRaycasts = true;
            });
        }
    }

    public Slot GetSlot()
    {
        return slot;
    }
}
