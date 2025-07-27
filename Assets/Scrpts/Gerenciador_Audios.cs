using UnityEngine;

public class Gerenciador_Audios : MonoBehaviour
{
    public AudioSource sons;
    public static Gerenciador_Audios instancia = null;

    void Awake()
    {
        if(instancia == null)
        {
            instancia = this;
        }else if(instancia != this)
        {
            Destroy(gameObject);
        }
        
    }

    public void PlayAudio(AudioClip clipAudio)
    {
        sons.clip = clipAudio;
        sons.Play();
    }
}
