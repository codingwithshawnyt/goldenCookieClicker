// GoldenCookie.cs
using UnityEngine;

public class GoldenCookie : MonoBehaviour
{
    public float lifetime = 10f; // The amount of time before the Golden Cookie disappears
    public int reward = 50; // The number of cookies the player gets for clicking the Golden Cookie
    private Clicking clicking; // Reference to the Clicking script

    void Start()
    {
        // Find the Canvas in the scene
        GameObject canvas = GameObject.Find("Canvas");

        // Make the Golden Cookie a child of the Canvas
        transform.SetParent(canvas.transform, false);

        clicking = FindObjectOfType<Clicking>(); // Get a reference to the Clicking script
        Invoke("Despawn", lifetime); // Despawn the Golden Cookie after its lifetime
    }

    void OnMouseDown()
    {
        clicking.Cookies += reward; // Add the reward to the player's cookie balance
        gameObject.SetActive(false); // Disable the Golden Cookie
    }

    void Despawn()
    {
        gameObject.SetActive(false); // Disable the Golden Cookie
    }
}
