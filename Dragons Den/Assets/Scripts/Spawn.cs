using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public float maxTime = 1;
    private float timer = 0;
    public GameObject obsticle;
    public GameObject spawnEnemy;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        
       GameObject newobsticle = Instantiate(obsticle);
        newobsticle.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
       // GameObject newspawnEnemy = Instantiate(spawnEnemy);
       //  newspawnEnemy.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
       // spawnEnemy.transform.position = new Vector3(2.2f, 0, transform.position.z);
       

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameOver == false)
        {
            if (timer > maxTime)
            {
                GameObject newobsticle = Instantiate(obsticle);
                newobsticle.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                GameObject newspawnEnemy = Instantiate(spawnEnemy);
                newspawnEnemy.transform.position = new Vector3(2.2f, 0.1f, transform.position.z);
                Destroy(newobsticle, 20);
                Destroy(newspawnEnemy, 20);
                timer = 0;
            }

            timer += Time.deltaTime;

        }
       
    }
   
}
