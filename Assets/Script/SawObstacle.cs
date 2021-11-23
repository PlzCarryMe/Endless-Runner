using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawObstacle : MonoBehaviour
{
    CharacterMove move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        move = col.gameObject.GetComponent<CharacterMove>();
        col.gameObject.SetActive(false);
        move.GameOver();
                
    }
}
