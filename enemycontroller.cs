using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemycontroller : MonoBehaviour
{
	NavMeshAgent move;
	public GameObject player;
	Transform player_transform;
    static int score = 0;
    public GameObject text_object;
    Text score_text;
    float x;
    float z;

    // Start is called before the first frame update
    void Start()
    {
    	move = GetComponent<NavMeshAgent>();
        player_transform = player.GetComponent<Transform>();
        score_text = text_object.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        move.SetDestination(player_transform.position);
    }
    
    void OnCollisionEnter(Collision collision_object)
    {
       if(collision_object.gameObject.tag == "Bullet")
        {
            score = score + 1;
            score_text.text = "Score: " + score;
            x = Random.Range(-85.5f, 77.2f);
            z = Random.Range(-62.4f, 61.1f);
            Instantiate(gameObject, new Vector3(x,0.75f,z), player_transform.rotation);
            Destroy(gameObject);
            if(score == 6)
            {
                SceneManager.LoadScene("scene3");
                PlayerPrefs.SetInt("MyScore", score);
            }
        }
    }
}
