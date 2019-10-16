using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public ItemSet itemSet;

    internal Dictionary<string, int> items;

    // Start is called before the first frame update
    void Start()
    {
        items = new Dictionary<string, int>();

        foreach (var item in itemSet.Items)
        {
            items.Add(item, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Item item = col.gameObject.GetComponent<Item>();
        if (item != null)
        {
            AddItem(item.Name);
        }
    }

    public void AddItem(string name)
    {
        Debug.Log("Added an item: " + name);
        items[name]++;
    }

    public void RemoveItem(string name)
    {
        Debug.Log("Removed an item: " + name);
        items[name]--;

        if (items[name] < 0)
            items[name] = 0;
    }
}