using UnityEngine;

public class Colider_Move : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D outro)
    {
        if(outro.gameObject.CompareTag("madeira"))
        {
            Destroy(outro.gameObject);
        }
    }
}
