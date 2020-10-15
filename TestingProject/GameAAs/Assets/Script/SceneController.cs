using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public GameObject[,] arena;
    private string theColor;
    public GameObject theArenaBox;
    public float arenaBoxSize;
    public Transform thePoint;
    public float startPointx;
    //1 = merah
    // Start is called before the first frame update
    void Start()
    {
        arena = new GameObject[4, 4];
        arenaBoxSize = theArenaBox.GetComponent<BoxCollider2D>().size.x;
        startPointx = thePoint.position.x;
        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                arena[i, j] = Instantiate(theArenaBox, new Vector3(thePoint.position.x, thePoint.position.y, thePoint.position.z), thePoint.rotation);
                thePoint.position = new Vector3(thePoint.position.x + arenaBoxSize, thePoint.position.y, thePoint.position.z);
            }
            thePoint.position = new Vector3(startPointx, thePoint.position.y - arenaBoxSize, thePoint.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }



    public void colorSelected(string warna)
    {
        //Debug.Log(warna);
        theColor = warna;
    }
    public string getColor()
    {
        return theColor;
    }
}
