using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemSet", menuName = "ScriptableObjects/Data/ItemSet")]
public class ItemSet : ScriptableObject
{
    public List<string> Items;
}
