using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Craft", menuName = "Craft/Material", order = 1)]
public class CraftMaterial : InventoryItem
{
    [SerializeField]
    public EquipStatsNumbers[] stats;
    [Range(1,3)]
    public int grade;
}
