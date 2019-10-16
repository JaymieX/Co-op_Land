using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSetActive : MonoBehaviour
{
    public List<string> RequiredItems;

    public List<GameObject> GameObjectsToModify;

    public List<bool> Modes;

    void OnTriggerEnter2D(Collider2D col)
    {
        Inventory inv = col.gameObject.GetComponent<Inventory>();
        if (inv != null)
        {
            bool res = true;
            foreach (var item in RequiredItems)
            {
                res &= inv.items[item] >= 1;
            }

            // True
            if (res)
            {
                // Remove items
                foreach (var item in RequiredItems)
                {
                    inv.RemoveItem(item);
                }

                // Flip
                for (int i = 0; i < GameObjectsToModify.Count; i++)
                {
                    GameObjectsToModify[i].SetActive(Modes[i]);
                }
            }
        }
    }
}
