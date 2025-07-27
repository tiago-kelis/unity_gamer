using UnityEngine;

public class Move_Porco : MonoBehaviour
{

    public float velocity = 2.5f;
    public int moedas = 0;
    public GameObject efeitoCoin;
    public Rigidbody2D porco;
    public float force = 500f;
    public AudioClip puloson;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            porco.AddForce(new Vector2(0, force * Time.deltaTime), ForceMode2D.Impulse);
            Gerenciador_Audios.instancia.PlayAudio(puloson);
        }

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
           Instantiate(efeitoCoin, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z), Quaternion.identity);
            moedas++;
            Destroy(moeda.gameObject);
        }
    }
}
