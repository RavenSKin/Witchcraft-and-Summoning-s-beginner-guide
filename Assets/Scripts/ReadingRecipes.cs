using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadingRecipes : MonoBehaviour
{
    public Items _item;
    GameManager _manager;
    private void Start()
    {
        _manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>();
    }
    void Update()
    {
        Read();
    }

    public void Read()
    {
        if (GetComponent<Image>().sprite != null)
        {
            
            foreach(Items _it in _manager._item)
            {
                if(_it._sprite == GetComponent<Image>().sprite)
                {
                    
                    _item = _it;
                }
            }
        }
        else { _item = null; }
    }
}
