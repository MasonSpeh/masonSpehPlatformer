using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        Sword,
        Healthpot,

    }
    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Sword: return ItemAssets.Instance.SwordSprite;
            case ItemType.Healthpot: return ItemAssets.Instance.HealthpotSprite;
        }
    }

}
