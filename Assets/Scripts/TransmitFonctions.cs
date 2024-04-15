using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TransmitFonctions : MonoBehaviour
{
    public UnityEvent actionChain;
    GameManager _manager;
    SpriteRenderer _renderer;
    private void OnEnable()
    {
        if(gameObject.tag == "Collectible")
        {
           
            _manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>();
           // actionChain.AddListener(PickRenderer);
        }
    }
    public void InvokingEventChain()
    {
        actionChain.Invoke();
    }

    void PickRenderer()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _manager.SetToInventory(_renderer.sprite);
    }
}
