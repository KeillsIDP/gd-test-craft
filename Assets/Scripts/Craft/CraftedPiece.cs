using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Craft", menuName = "Craft/Piece", order = 1)]
public class CraftedPiece : InventoryItem
{
    [SerializeField]
    public EquipStatsNumbers[] stats;
    [SerializeField]
    public int quality;
}
