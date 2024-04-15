using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ToggleAnimation : MonoBehaviour
{
    bool _isEnable;
    public Vector3 final_position;
    public Vector3 startposition;
    private void Start()
    {
        
    }
    public void ButtonState(RectTransform _object)
    {        
        if (_isEnable)
        {
            DisableInventory(_object);
            _isEnable = false;
        }
        else
        {
            EnableInventory(_object);
            _isEnable = true;
        }
 
    }

    void EnableInventory(RectTransform _parent)
    {
        _parent.DOLocalMove(new Vector3(final_position.x , final_position.y,0), 0.3f);
    }

    void DisableInventory(RectTransform _parent)
    {
        _parent.DOLocalMove(new Vector3(startposition.x, startposition.y, startposition.z), 0.3f);
    }
}
