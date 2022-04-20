using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//For creating assets
[CreateAssetMenu(menuName = "Item", fileName = "New Item")]
public class Item : ScriptableObject
{
    //For holding the item name
    public string itemName;

    //For item discreption
    public string itemDes;

    //For holding the sprite of the item
    public Sprite itemSprite;


}
