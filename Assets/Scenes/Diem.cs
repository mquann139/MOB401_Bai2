using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Diem : MonoBehaviour
{
    public GameObject square;
    public Text scoreText;
    private int score=0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreaseScore()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }

    public void TuongDiChuyen()
    {
        Vector3 tranform = new Vector3(square.transform.position.x, square.transform.position.y + 1f,
            square.transform.position.z);

        if (tranform.y >= 5f)
        {
            tranform.y -= 5;
        }

        square.transform.position = tranform;
    }
    private void OnGUI()
    {
        GUI.Box(new Rect(10,10,150,90),"Loader Menu");
        if (GUI.Button(new Rect(20,40,80,20),"Fire"))
        {
            IncreaseScore();
        }
        if (GUI.Button(new Rect(20,80,120,20),"tường di chuyển"))
        {
            TuongDiChuyen();
        }
    }
}
