using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblesSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] bubbleRef;

    private GameObject spawnedBubble;

    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBubble());
    }
    
    IEnumerator SpawnBubble() {
        
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3, 8));

            randomIndex = Random.Range(0, bubbleRef.Length);
            randomSide = Random.Range(0, 2);

            spawnedBubble = Instantiate(bubbleRef[randomIndex]);

            if (randomSide == 0) {

                spawnedBubble.transform.position = leftPos.position;
                spawnedBubble.GetComponent<Bubbles>().speed = Random.Range(3, 8);

            }
            else
            {
                spawnedBubble.transform.position = rightPos.position;
                spawnedBubble.GetComponent<Bubbles>().speed = -Random.Range(3, 8);
            }
        }


    }



}
