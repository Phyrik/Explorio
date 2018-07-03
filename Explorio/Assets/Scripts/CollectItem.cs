using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectItem : MonoBehaviour {

    public GameObject craftingPanel;
    public GameObject hammer;
    public GameObject craftingButton;
    public Text craftingButtonText;
    public Text woodCountText;
    public Text stoneCountText;
    public bool hammerBought;
    public int wood = 0;
    public int stone = 0;

    private void Start()
    {
        craftingPanel.SetActive(false);
        hammerBought = false;
    }

    private void Update()
    {
        if (hammerBought == true)
        {
            hammer.SetActive(true);
        }

        if (hammerBought == false)
        {
            hammer.SetActive(false);
        }

        SetMaterialsCountText();
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Mixed_Palm_tree_01")
        {
            Destroy(col.gameObject);
            wood += 1;
        }

        if(col.gameObject.name == "Mixed_Rock_01")
        {
            Destroy(col.gameObject);
            stone += 1;
        }
    }

    public void craftingButtonPressed()
    {
        craftingPanel.SetActive(!craftingPanel.activeSelf);
        craftingButton.GetComponent<Button>().enabled = false;
        craftingButton.GetComponent<Button>().enabled = true;

        if (craftingButtonText.text == "Craft")
        {
            craftingButtonText.text = "Close";
        }

        else if (craftingButtonText.text == "Close")
        {
            craftingButtonText.text = "Craft";
        }
    }

    public void buyHammer()
    {
        if (hammerBought == false && wood >= 1 && stone >= 1)
        {
            wood -= 1;
            stone -= 1;
            hammerBought = true;
        }
    }

    void SetMaterialsCountText()
    {
        woodCountText.text = "Wood: " + wood;
        stoneCountText.text = "Stone: " + stone;
    }
}
