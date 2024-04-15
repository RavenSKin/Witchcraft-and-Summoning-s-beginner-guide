using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

        
public class InventorySlots : MonoBehaviour
{
    // Quand je collecte un objet => transmet depuis le script de l'objet le type d'objet 
    public int currentIndex;
    int IndexMax = 15;
    public enum Operation {Add , Substract };
    public Operation _operation;
    
    public void SetSlotIndex(Operation actionType)
    {
        switch (actionType)
        {
            case Operation.Add:
                if (currentIndex < IndexMax) currentIndex++;
                else Debug.Log("Inventory Full can't add more items !");
                break;
            case Operation.Substract:
                
                break;
        }
    }

    
}
