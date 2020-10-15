using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaBox : MonoBehaviour
{
    public SceneController theSceneController;
    private string color;
    // Start is called before the first frame update
    void Start()
    {
        theSceneController = FindObjectOfType<SceneController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //Debug.Log("Arena Box");
        color = theSceneController.getColor();
        changeColor(color);
    }

    void changeColor(string theColor)
    {
        if(theColor == "Merah")
        {
            this.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        }

        else
        {
            Debug.Log("Color Not Selected");
        }
        
    }
}
