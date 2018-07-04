using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour {

    public Material material;
    public Color playerColour;

	public void changeColour ()
    {
        material.color = playerColour;
    }
}
