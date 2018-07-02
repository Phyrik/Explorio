using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crafting : MonoBehaviour {

    public GameObject craftingPanel;
    public Text craftingButtonText;

    private void Start()
    {
        craftingPanel.SetActive(false);
    }

    void craftingButtonPressed ()
    {
        craftingPanel.SetActive(!craftingPanel.activeSelf);
        GetComponent<Button>().enabled = false;
        GetComponent<Button>().enabled = true;

        Debug.Log(craftingButtonText.text);

        if(craftingButtonText.text == "Craft")
        {
            Debug.Log("1");
            craftingButtonText.text = "Close";
        }

        else if (craftingButtonText.text == "Close")
        {
            Debug.Log("2");
            craftingButtonText.text = "Craft";
        }
    }
}
