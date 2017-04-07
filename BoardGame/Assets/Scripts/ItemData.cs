using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class ItemData : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public Item item;
	public int amount;

	private Transform originalParent;

	public void OnBeginDrag(PointerEventData eventData){
		if (item.ID != -1) {
			originalParent = this.transform.parent;
			this.transform.SetParent (this.transform.parent.parent);
			this.transform.position = eventData.position;
			Debug.Log ("MOVED");
		}
	}

	public void OnDrag(PointerEventData eventData){
		if (item.ID != -1) {
			this.transform.position = eventData.position;
		}
	}

	public void OnEndDrag(PointerEventData eventData){
		this.transform.SetParent (originalParent);
	}

}
