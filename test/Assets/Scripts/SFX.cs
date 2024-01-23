using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AudioButtonHighlight : MonoBehaviour, IPointerEnterHandler
{
    public Button Button; // Link this in the Unity Editor
    public AudioSource audioSourceA; // Link this in the Unity Editor
    public AudioSource audioSourceB;
    public AudioClip ClipA; // Link your audio clip in the Unity Editor
    public AudioClip clipB;

    void Start()
    {
        // Add this script as a component to the Button GameObject
        Button.gameObject.AddComponent<AudioButtonHighlight>();
        Button.onClick.AddListener(PlayAudioOnClick);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Check if the audio source and audio clip are assigned
        if (audioSourceA != null && ClipA != null)
        {
            // Play the audio clip
            audioSourceA.PlayOneShot(ClipA);
        }
    }

    void PlayAudioOnClick()
    {
        // Check if the audio source and audio clip are assigned
        if (audioSourceB != null && clipB != null)
        {
            // Play the audio clip
            audioSourceB.PlayOneShot(clipB);
        }
    }

}

