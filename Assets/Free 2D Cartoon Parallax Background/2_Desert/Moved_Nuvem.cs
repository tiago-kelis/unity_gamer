using UnityEngine;

public class Moved_Nuvem : MonoBehaviour

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
        Vector2 offset = new Vector2(velocity * Time.deltaTime, 0);

        quad.material.mainTextureOffset += offset;
    }
}
