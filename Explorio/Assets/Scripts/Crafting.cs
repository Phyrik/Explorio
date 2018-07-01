using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafting : MonoBehaviour {

    public GameObject craftingPanel;

    public void craftingButtonPressed ()
    {
        craftingPanel.SetActive(true);
    }
}
