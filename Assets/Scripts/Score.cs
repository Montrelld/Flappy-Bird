using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class Score : MonoBehaviour

    int score = 0;
    public Text scoreUI;

{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Points"))  
        {
            // Increase score by 1
            score = score +1;
            scoreUI.text = score.ToString();
        } 
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
