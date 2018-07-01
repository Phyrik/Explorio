using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectItem : MonoBehaviour {

    public int wood = 0;
    public int stone = 0;
    public Text woodCountText;
    public Text stoneCountText;

    private void Update()
    {
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

    void SetMaterialsCountText()
    {
        woodCountText.text = "Wood: " + wood;
        stoneCountText.text = "Stone: " + stone;
    }
}
