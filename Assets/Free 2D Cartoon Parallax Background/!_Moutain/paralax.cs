using UnityEngine;

public class paralax : MonoBehaviour
{
    public Renderer quad;
    public float velocity = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 offSet = new Vector2(velocity * Time.deltaTime, 0);
        quad.material.mainTextureOffset += offSet;
        
    }
}
