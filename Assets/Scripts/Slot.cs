using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler
{
    [SerializeField] private Draggable draggable;
    [SerializeField] private bool isOccupied;
    [SerializeField] private Color trueColor;

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null && eventData.pointerDrag.GetComponent<Draggable>() != null)
        {
            if(eventData.pointerDrag.GetComponent<Draggable>().GetSlot() == this)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
                eventData.pointerDrag.GetComponent<CanvasGroup>().blocksRaycasts = false;
                this.GetComponent<Image>().raycastTarget = false;
                eventData.pointerDrag.GetComponent<Image>().color = trueColor;
                isOccupied = true;
                GameBoard.Instance.IncreaseScore(1);
            }
        }
    }

    public bool IsOccupied()
    {
        return isOccupied;
    }
}
