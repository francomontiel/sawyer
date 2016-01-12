﻿using UnityEngine;
using System.Collections;

public class Message {

	private AudioClip audio;
	private string text;

	/*public Message(string text) {
		this.text = text;
		audio = Resources.Load<AudioClip>("Audio/player_hurt");
	}*/

	public Message(string text, string audio) {
		this.text = string.Format(text, PlayerInfo.getName());
		this.audio = Resources.Load<AudioClip>(audio);
	}

	public string getText() {
		return text;
	}

	public AudioClip getAudio() {
		return audio;
	}
}