using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    public GameObject Enemy;
    public float AreaX, AreaZ;

	// Use this for initialization
	void Start () {

        StartCoroutine(SpawnEnemy());

	}
	
	// Update is called once per frame
	void Update () {
		



	}

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            Instantiate(Enemy, new Vector3(Random.Range(-AreaX, AreaX), 50, Random.Range(0, AreaZ)), transform.rotation);
            Debug.Log("Instantiated at : ");
            yield return new WaitForSeconds(30f);
        }
    }


}
