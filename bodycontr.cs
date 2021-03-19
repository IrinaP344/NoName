using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bodycontr : MonoBehaviour
{
	float x;
	float y;

	Rigidbody rb;
	public headcontr another_script;
    static int time = 30;
    public GameObject text_object;
    Text time_text;
    static int hp = 100;
    public GameObject text1_object;
    Text hp_text;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("MyTimer", 1f, 1f);
        time_text = text_object.GetComponent<Text>();
        hp_text = text1_object.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Vertical");
        y = Input.GetAxis("Horizontal");

        rb.velocity = transform.forward * x * 5f;
        transform.rotation = Quaternion.Euler(0, another_script.sens, 0);
    }

   void MyTimer()
    {
        time = time - 1;
        time_text.text = "Time: " + time;
        if(time == 0)
            {
                SceneManager.LoadScene("scene2");
            }
    }
    void OnCollisionEnter(Collision collision_object)
    {
        if(collision_object.gameObject.tag == "enemy")
        {
            hp = hp-20;
            hp_text.text = "Hp: " + hp;
            if(hp == 0)
            {
                SceneManager.LoadScene("scene2");
            }
        }

    }
}
