﻿using UnityEngine;
using System.Collections;

public class DeskPictureFrameController : MonoBehaviour {

	public Texture portrait;

	private DeskController deskController;
	private DeskConversationController conversationController;
	private bool available = true;

	// Use this for initialization
	void Start () {
		conversationController = GetComponentInParent<DeskConversationController> ();
		GetComponentInParent<MeshRenderer> ().materials [1].mainTexture = portrait;
	}

	public void setAvailability(bool b) {
		available = b;
	}

	void OnMouseDown() {
		if (available) {
			conversationController.StartConversation (deskController);
		}
	}

	public void setDeskController(DeskController controller) {
		deskController = controller;
	}
}
