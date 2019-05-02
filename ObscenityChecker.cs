using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObscenityChecker : MonoBehaviour {
	public NameGenerator theGenerator;
	string[] curseWords;
	// get the names from the name generator
	// get the curse words from the name generator
	// Use this for initialization
	void Start () {
		curseWords = theGenerator.curseWords;
	}
	
	public bool hasCurseWords(string name){
		for (int i = 0; i < curseWords.Length; i++) {
			if (name == curseWords[i]) {
				Debug.Log("Obscenity Found: " + name);
				return true;
			}
		}
		return false;
	}
}
