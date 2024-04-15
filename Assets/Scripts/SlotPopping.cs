using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotPopping : MonoBehaviour
{
    Vector4 startColor;
    private void Start()
    {
        startColor = GetComponent<Image>().color;
    }
    private void OnEnable()
    {
        if (GetComponent<Image>().sprite == null)
        {
            GetComponent<Image>().color = Vector4.zero;
        }

    }
    private void Update()
    {
        if (GetComponent<Image>().sprite != null)
        {
           
            GetComponent<Image>().color = new Vector4(255,255,255,255);

        }
        else
        {
            GetComponent<Image>().color = Vector4.zero;
        }
    }
}
