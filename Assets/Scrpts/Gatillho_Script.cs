using UnityEngine;

public class Gatillho_Script : MonoBehaviour
{

    public bool liberaHot;
    public GameObject ferradura;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        liberaHot = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(liberaHot == true)
        {
            ferradura.gameObject.transform.Rotate(new Vector3(0, 0, 5f * Time.deltaTime));
        }
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("porco"))
        {
            liberaHot = true;
        }
    }

    void OnTriggerExit2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("porco"))
        {
            liberaHot = false;
        }
    }
}
