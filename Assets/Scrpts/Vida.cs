using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    private float tempo = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempo -= Time.deltaTime;
        if(tempo <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
