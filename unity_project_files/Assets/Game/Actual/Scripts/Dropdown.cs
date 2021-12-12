using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dropdown : MonoBehaviour {

    public void HandleInputData(int val)
    {
        GameObject[] warriorObjects = FindInActiveObjectsByTag("Warrior");
        GameObject[] rangerObjects = FindInActiveObjectsByTag("Ranger");
        GameObject[] mageObjects = FindInActiveObjectsByTag("Mage");
        if (val == 0)
        {
            foreach (GameObject item in warriorObjects){
                item.SetActive(true);
            }
            foreach (GameObject item in rangerObjects){
                item.SetActive(false);
            }
            foreach (GameObject item in mageObjects){
                item.SetActive(false);
            }
            Debug.Log("Made the warrior visible");
            
        }

        if (val == 1)
        {
            foreach (GameObject item in warriorObjects)
            {
                item.SetActive(false);
            }
            foreach (GameObject item in rangerObjects)
            {
                item.SetActive(true);
            }
            foreach (GameObject item in mageObjects)
            {
                item.SetActive(false);
            }
            Debug.Log("Made the ranger visible");
        }

        if (val == 2)
        {
            foreach (GameObject item in warriorObjects)
            {
                item.SetActive(false);
            }
            foreach (GameObject item in rangerObjects)
            {
                item.SetActive(false);
            }
            foreach (GameObject item in mageObjects)
            {
                item.SetActive(true);
            }
            Debug.Log("Made the mage visible");
        }
    }

    GameObject[] FindInActiveObjectsByTag(string tag)
    {
        List<GameObject> validTransforms = new List<GameObject>();
        Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i].hideFlags == HideFlags.None)
            {
                if (objs[i].gameObject.CompareTag(tag))
                {
                    validTransforms.Add(objs[i].gameObject);
                }
            }
        }
        return validTransforms.ToArray();
    }
}
