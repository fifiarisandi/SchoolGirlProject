using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool isPaused;

    //For the item list or what type of item we have
    public List<Item> items = new List<Item>();
    
    //For the item number or the number of items stored
    public List<int> itemNumbers = new List<int>();

    public GameObject[] slots;

    public ItemButton thisButton;       //Keeps track of the item on mouse hover
    public ItemButton[] itemButtons;   //For storing the buttons

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        else
        {
            if(instance != this)
            {
                Destroy(gameObject);
            }
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        DisplayItems();
    }

   /* private void Update()
    {
       
    }*/

    private void DisplayItems()
    {
        #region
        /*for(int i = 0; i < items.Count; i++)
        {
            //For the image for the slots being updated
            slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
            slots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].itemSprite;

            //For the slots count to be updated
            slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, 1);
            slots[i].transform.GetChild(1).GetComponent<Text>().text = itemNumbers[i].ToString();

            //To display the close button
            slots[i].transform.GetChild(2).gameObject.SetActive(true);

        }*/

        #endregion
    
        for(int i =0; i < slots.Length; i++)
        {
            if(i < items.Count)
            {
                //For the image for the slots being updated
                slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].itemSprite;

                //For the slots count to be updated
                slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(1).GetComponent<Text>().text = itemNumbers[i].ToString();

                //To display the close button
                slots[i].transform.GetChild(2).gameObject.SetActive(true);
            }

            else    //To remove some items
            {
                //For the image for the slots being updated
                slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 0);
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = null;

                //For the slots count to be updated
                slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, 0);
                slots[i].transform.GetChild(1).GetComponent<Text>().text = null;

                //To display the close button
                slots[i].transform.GetChild(2).gameObject.SetActive(false);
            }
        }
    }

    public void AddItem(Item _item)
    {
        //For getting a new item in the inventory
        if(!items.Contains(_item))
        {
            items.Add(_item);
            itemNumbers.Add(1); //Adds by 1 number count
        }
        //If the item already in the inventory
        else
        {
            Debug.Log("Already have the Item");
            for(int i = 0; i < items.Count; i++)
            {
                if(_item == items[i])
                {
                    itemNumbers[i]++;
                }
            }
        }
        
        DisplayItems();
    }

    public void RemoveItem(Item _item)
    {
        //For the items that already in the inventory
        if(items.Contains(_item))
        {
            for(int i = 0; i < items.Count; i++)
            {
                if(_item == items[i])
                {
                    itemNumbers[i]--;
                    //For completly removing the item
                    if(itemNumbers[i] == 0)
                    {
                        items.Remove(_item);
                        itemNumbers.Remove(itemNumbers[i]);
                    }
                }
            }
        }
        //For new items in the inventory
        ResetButtonItems();
        DisplayItems();
    }

    public void ResetButtonItems()
    {
        for(int i = 0; i < itemButtons.Length; i++)
        {
            if(i < items.Count)
            {
                itemButtons[i].thisItem = items[i];
            }
            else
            {
                itemButtons[i].thisItem = null;
            }
        }
    }
}
