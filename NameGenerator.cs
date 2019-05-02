using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameGenerator : MonoBehaviour {

    public string[] beginningNameComponents;
    public string[] endNameComponents;
    public string[] names;
    string theName;
    //public int numberOfNames;
    int componentIndex;
    int numberOfComponents = 3;


    public string[] curseWords;
	public ObscenityChecker curseWordChecker;
	public DuplicateChecker dupeChecker;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
	}


    public void GenerateNames() {

        for (int i = 0; i < names.Length; i++)
        {
            names[i] = GenerateOneName(i);
        }
    }

	public string GenerateOneName(int insertionIndex) {
        theName = ""; //reset it so that all names start empty
        numberOfComponents = Random.Range(2, 5);

        // generate a name of random length
        for (int i = 0; i < numberOfComponents; i++)
        {
            //numberOfComponents = Random.Range(0, beginningNameComponents.Length); ERROR

            // we want to pull from the beginningComponents array except for the ending
            if (i == numberOfComponents - 1) // then we are at the end of the name
            {
                componentIndex = Random.Range(0, endNameComponents.Length - 1);
                theName += endNameComponents[componentIndex];
            }
            else // we are somewhere in the middle of the name generation, so use the beginningNameComponents
            {
                componentIndex = Random.Range(0, beginningNameComponents.Length - 1);
                theName += beginningNameComponents[componentIndex];
            }

		} 
		// run the duplicate checker script's check function to make sure this name isn't already in there
		if(curseWordChecker.hasCurseWords(theName) || dupeChecker.isDuplicate(names, theName, insertionIndex)){
			theName = GenerateOneName (insertionIndex); // run this function again

		}
        return theName;
    }
}
