using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectItem : MonoBehaviour {

    public int wood = 0;
    public Text woodCountText;

    private void Update()
    {
        SetWoodCountText();
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Mixed_Palm_tree_01")
        {
            Destroy(col.gameObject);
            wood += 1;
        }
    }

    void SetWoodCountText()
    {
        woodCountText.text = "Wood: " + wood;
    }
}
