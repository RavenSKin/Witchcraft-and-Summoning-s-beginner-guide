using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Interact : MonoBehaviour
{
    [Header("Player Interface")]
    public Transform InteractButton;
    public Transform EndPos;
    Vector3 StartPos;

    private void Start()
    {
        StartPos = InteractButton.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ShowButton();


    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        HideButton();

    }
    void ShowButton()
    {
        InteractButton.DOScale(new Vector3(1, 1, 1), 0.8f);
        InteractButton.DOMove(new Vector3(EndPos.position.x, EndPos.position.y, EndPos.position.z), 0.4f);
    }
    void HideButton()
    {
        InteractButton.DOScale(Vector3.zero, 0.3f);
        InteractButton.DOMove(StartPos, 0.8f);
    }
}
