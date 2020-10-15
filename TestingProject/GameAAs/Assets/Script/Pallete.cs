using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class Pallete : MonoBehaviour
{
    SceneController theSceneController;
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
        theSceneController.colorSelected(this.tag);
    }
}
