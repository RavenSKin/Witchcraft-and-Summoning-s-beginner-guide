using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu]
public class Items : ScriptableObject
{
    public enum ItemType
    {
        PotionComposant,
        SummoningComposant
    }
    public enum ItemName
    {
        // Summoning
        Cat,
        Owl,
        Dog,
        Shirt,
        Sword,    
        Keyboard,
        Oldbook,

        // Potion
        
        Peanut,
        Banana,
        Butter,
        Cheese,
        Tomato,
        Pepper,
        Red_Apple,
        Strawberry,
        Blue_berry,
        Avocado,
        Water,
        Old_Cheese,
    }
    public enum ItemColor
    {
        Red ,
        Yellow ,
        Blue ,
    }
    public ItemColor itemColor;
    public ItemType _type;
    public ItemName _name;
    public Sprite _sprite;
    public int index;
    public bool Discovered;
    public List<GameObject> Recipe;

}
