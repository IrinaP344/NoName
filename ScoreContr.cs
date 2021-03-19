using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreContr : MonoBehaviour
{
	float score;
    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("MyScore");
        print(score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
