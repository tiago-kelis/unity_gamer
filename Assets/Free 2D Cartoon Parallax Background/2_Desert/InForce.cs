using UnityEngine;

public class InForce : MonoBehaviour
{

    public Rigidbody2D bola;
    public float force = 600f;
    public bool libera = false;
    public int duplo = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (this.gameObject.CompareTag("bola"))
        {
            if (duplo > 0)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    bola.AddForce(new Vector2(0, force * Time.deltaTime), ForceMode2D.Impulse);
                    duplo--;
                }
            }

        }       
        
    }

    void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("chao"))
        {
            duplo = 2;
            //libera = true;
        }
    }

    //void OnCollisionExit2D(Collision2D outro)
    //{
    //    if (outro.gameObject.CompareTag("chao"))
    //    {
    //        libera = false;
    //    }
    //}
}
