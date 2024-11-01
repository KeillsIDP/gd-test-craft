using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsInventory : MonoBehaviour
{
    [SerializeField]
    private InventoryItem[] items;
    [SerializeField]
    private Transform gridHandler;
    [SerializeField]
    private InventoryCell cellPrefab;
    
    private void OnEnable() {
        foreach(var item in items){
            GameObject cell = Instantiate(cellPrefab.gameObject,gridHandler);
            cell.GetComponent<InventoryCell>().SetItem(item);
        }
    }
}
