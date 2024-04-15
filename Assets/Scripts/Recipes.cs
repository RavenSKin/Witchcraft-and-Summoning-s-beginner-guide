using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu]
public class Recipes : ScriptableObject
{
    public bool Potion;
    public bool Summon;
   public enum Recipe
    {
        // Cat 
        Don_Catpaccio ,            //  + OldBook + Sword (il est italien , degat)
        Keyboard_Cat,              //  + Shirt   + Keyboard (le meme , il diverti aleatoirement)
        Metallicat,                //  + Sword + Keyboard (le groupe de metal , boost les degats des invoc offensives)
        Hoodie_nyan ,              //  + OldBook + Shirt  (magician/Rogue ,50% de chance d'eviter une attaque , 50% de chance de s'autodetruire sur un ennemi)
        Cat_in_Hawaii ,            //  + OldBook + Keyboard (Chat avec un micro , annule l'attaque d'un ennemi et disparait)
        Angry_Dangerous_Cat,       //  + Shirt  + Sword (Degats)

        // Owl
        Warriowl,                  //  + shirt   + Sword    ( degat )      
        Singing_Parot ,            //  + OldBook + Keyboard (degat , faible chance de confusion chaque tour )
        Owlly_Alexander ,          //  + shirt   + Keyboard ( Soigne , confusion sur tout les ennemi pendant 1 tour ) 
        BlackSab_bat ,             //  + Sword   + Keyboard ( faible chance de degat critique , degat )
        Not_Avian ,                //  + OldBook + Sword    ( degat general ) 
        Forest_Keeper ,            //  + OldBook + Shirt    ( soin , generation d'objet si inventaire pas plein )

        // Dog
        Cool_Stick_Dog ,           //  + Shirt   + Sword    ( degat important mais degats de recul )
        Not_Parappa ,              //  + Shirt   + Keyboard ( diverti au tour 1 , degat )
        Bethoven ,                 //  + Sword   + Keyboard ( degat critique pendant 2 tour puis disparait )
        Security_Dog ,             // + OldBook + Shirt ( augmente la resistanceaux degats ) 
        Legendary_Dog ,            // + OldBook + Sword (degat au D20 , si le resultat est 1 : degats de recul modéré)
        Spoon_Dog ,                // + OldBook + Keyboard (degats globaux faible , chance d'etourdir un adversaire faible )
        // Potion
                   // Tomato          
        Hot_Fireball_potion,         // Big Damage (3 red ingredients )
        Hot_beverage,                // Small Heal (2 red ingredients and 1 blue )
        Explosive_potion,            // Small Global Damage (2 red ingredients and 1 Yellow )
        Peanut_Butter_potion,        // Confusion (3 Yellow ingredients)
        Vodcat_Mixture ,             // Focused Confusion ( 2 Yellow ingredients and 1 red ingredient )
        Parapotion,                  // Paralysis ( 2 Yellow ingredients and 1 blue ingredient )
        Focused_Poison_potion,       // Poison ( 3 blue ingredients )
        GoodShape_Potion,            // Armor ( 2 blue ingredients and 1 Yellow )
        Smooth_drink,                // Big heal ( 2 blue ingredients and 1 Red )
        StrangeButTasty_potion,      // Polymorph (3 different colors of ingredients )
                                    
                                   
                                    

    }
    public Recipe _Name;
    public enum IngredientColor { Red , Yellow , Blue , Any}
    public GameObject InstanceToSummon;
    

    public List<Items> RequiredComposantSummoning;
    public List<IngredientColor> RequiredIngredientColorPotion;


}
