using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crafting : MonoBehaviour {

    public GameObject craftingPanel;
    public GameObject player;
    public Text craftingButtonText;
    public bool hammerBought;
    private CollectItem collectItemScript;
    private int wood;
    private int stone;

    private void Start()
    {
        collectItemScript = player.GetComponent<CollectItem>();
        wood = collectItemScript.wood;
        stone = collectItemScript.stone;
        craftingPanel.SetActive(false);
        hammerBought = false;
    }
    private void Update()
    {
        wood = collectItemScript.wood;
        stone = collectItemScript.stone;
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

    void buyHammer ()
    {
        Debug.Log("test0");
        Debug.Log(wood);
        Debug.Log(stone);
        if(hammerBought == false && wood >= 1 && stone >= 1)
        {
            Debug.Log("test");
        }
    }
}
