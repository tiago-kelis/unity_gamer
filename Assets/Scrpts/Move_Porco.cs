using UnityEngine;

public class Move_Porco : MonoBehaviour
{

    public float velocity = 2.5f;
    public int moedas = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(velocity * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-velocity * Time.deltaTime, 0));
        }

        print(moedas);
        
    }

     void OnTriggerEnter2D(Collider2D moeda)
    {
        if (moeda.gameObject.CompareTag("moedas"))
        {
            moedas++;
            Destroy(moeda.gameObject);
        }
    }
}
