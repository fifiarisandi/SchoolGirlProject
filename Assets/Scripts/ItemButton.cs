using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Text;

public class ItemButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
   public int buttonID;             //For each slots as they have unique ID

   //[SerializeField] private Item thisItem;          // To make it invisible in the inspector
   public Item thisItem;

   public ToolTip tooltip;

   private Vector2 position;

   //Function to get the item on this button

   private Item GetThisItem()
   {
       for(int i = 0; i < GameManager.instance.items.Count; i++)
       {
           if(buttonID == i)
           {
               thisItem = GameManager.instance.items[i];
           }
       }

       return thisItem;
   }

   public void CloseButton()
   {
       GameManager.instance.RemoveItem(GetThisItem());

       thisItem = GetThisItem();
       if(thisItem != null)
       {
           //Display item tool tip
           //To show the tool tip
           tooltip.ShowToolTip();
           //tooltip.UpdateToolTip(thisItem.itemDes);
           tooltip.UpdateToolTip(GetDetailText(thisItem));

           //Below Code causes the tool tip to be not shown for some reason....
           //RectTransformUtility.ScreenPointToLocalPointInRectangle(GameObject.Find("Canvas").transform as RectTransform, Input.mousePosition, null, out position);
           
           tooltip.SetPosition(position);

       }
       else 
       {
           //Hide tool tip
           tooltip.HideToolTip();
           tooltip.UpdateToolTip("");

       }
   }

   public void OnPointerEnter(PointerEventData eventData)
   {
       GetThisItem();
       if(thisItem != null)
       {
           Debug.Log("ENTER" + thisItem.itemName + "SLOT");

           //To show the tool tip
           tooltip.ShowToolTip();
           //tooltip.UpdateToolTip(thisItem.itemDes);
           tooltip.UpdateToolTip(GetDetailText(thisItem));

           //Below Code causes the tool tip to be not shown for some reason....
           //RectTransformUtility.ScreenPointToLocalPointInRectangle(GameObject.Find("Canvas").transform as RectTransform, Input.mousePosition, null, out position);
           
           tooltip.SetPosition(position);
       }
            
    
   }

   public void  OnPointerExit(PointerEventData eventData)
   {
      // if(thisItem != null)
      // {
       //    Debug.Log("EXIT" + thisItem.itemName + "SLOT");

           //To hide the tool tip
           tooltip.HideToolTip();
           tooltip.UpdateToolTip("");

        
      // }
   }

    //For getting the complete information 
    private string GetDetailText(Item _item)
    {
        if(_item == null)
        {
            return "";
        }

        else
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Item {0}\n\n", _item.itemName);
            stringBuilder.AppendFormat("Description : {0}\n\n", _item.itemDes);
            return stringBuilder.ToString();
        }
    }

}
