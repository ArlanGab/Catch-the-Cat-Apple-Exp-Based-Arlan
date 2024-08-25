using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutTrigger : MonoBehaviour
{
    [SerializeField] GameObject GameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HealthManager.health--;
        Destroy(collision.gameObject);
        if (HealthManager.health <= 0) {
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }

    }
}
