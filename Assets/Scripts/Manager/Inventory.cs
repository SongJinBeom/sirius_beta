using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Hashtable items = new Hashtable();
    string itemName = "";
    private GameObject itemMent;
 
    public void OnTriggerEnter2D(Collider2D collision)
    {
        itemName = collision.name;
        itemMent = GameObject.Find("ItemTalker");
        if (collision.tag == "item")
        {
            items.Add(itemName, "1");
            itemMent.GetComponent<itemExplanation>().showItemText(1, itemName);
            Destroy(GameObject.Find(itemName));
        }
        else
        {
            Debug.Log(collision.name);
        }

        //itemName = collision.name;

        //if(collision.tag == "item")
        //{
        //    addItem(collision);
            //tempItem.icon = collision.gameObject.GetComponent<Image>();
            //tempItem.itemName = collision.name;
            //tempItem.itemCode = collision.name;
            //tempItem.itemNum++;
        //}
    }

    public void showInventory()
    {
        foreach (string item in items.Keys)
        {
            Debug.Log(item);
        }
    }
      

    //public GameObject selectedItem;

    //public void addItem(object item)
    //{
    //    tempItem = (item)item;

    //    items.Add(tempItem, "1");
    //    itemName = tempItem.name;
    //    itemMent.GetComponent<itemExplanation>().showItemText(1, itemName);
    //    Destroy(GameObject.Find(itemName));
    //}

    //public void removeItem(object item)
    //{
    //    tempItem = (item)item;
    //    tempItem.itemName = "";
    //    tempItem.itemCode = "";
    //    tempItem.icon.sprite = null;
    //    tempItem.itemNum = 0;

    //    items.Remove(tempItem);
    //}
     
}