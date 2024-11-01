using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryCell : MonoBehaviour
{
    private static InventoryPickedItemHandler itemHandler;
    private InventoryItem item;

    private void OnEnable() {
        if(!itemHandler)
            itemHandler = FindObjectOfType<InventoryPickedItemHandler>();
    }

    public void OnClick(){
        itemHandler.item = item;
    }

    public void SetItem(InventoryItem item){
        this.item = item;
        GetComponent<Image>().sprite = item.image;
    }
}
