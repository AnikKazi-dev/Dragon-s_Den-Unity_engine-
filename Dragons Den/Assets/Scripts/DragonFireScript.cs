using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonFireScript : MonoBehaviour
{
    // Start is called before the first frame update
   // GameObject fire;
   public GameObject enemy;
    //int flag=0;
    void Start()
    {
        //fire = GetComponent<GameObject>();
    }
    void Update()
    {

      
       
       
    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Fire"))
        {

            enemy.SetActive(false);
            Invoke("ReActiveEnemy",5);

        }


    }
    void ReActiveEnemy()
    {
        enemy.SetActive(true);
       enemy.transform.position = new Vector3(-2.2f, 0.1f, transform.position.z);
       
       
      
    }
}
