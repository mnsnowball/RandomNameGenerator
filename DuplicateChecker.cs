using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateChecker : MonoBehaviour {

	public bool isDuplicate(string[] names, string aName, int nameIndex){
		for (int i = 0; i < nameIndex; i++) {
			if (aName == names [i]) {
				Debug.Log("Duplicate Found!");
				return true;

			}
		}
		return false;
	}

}
