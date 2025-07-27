using UnityEngine;

public class Move_Bala : MonoBehaviour
{

    public float velocity = 2.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(velocity * Time.deltaTime, 0));
    }
}
