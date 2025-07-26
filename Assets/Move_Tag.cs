using Unity.VisualScripting;
using UnityEngine;

public class Move_Tag : MonoBehaviour
{

    public Rigidbody2D bola;
    public float force = 500f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (this.gameObject.CompareTag("bola"))
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                bola.AddForce(new Vector2(0, force * Time.deltaTime), ForceMode2D.Impulse);
            }
        }
        
    }
}
