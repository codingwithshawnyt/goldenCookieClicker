// Clicking.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicking : MonoBehaviour
{
    public Button cookie; 
    public Button goldCookie; 
    public int Cookies = 0; 
    public Text CookieText;
    public int numClick = 1;

    public int goldClick = 50;
    public int cps = 0;
    public GameObject goldenCookiePrefab; // Reference to the Golden Cookie Prefab

    // Start is called before the first frame update
    void Start()
    {
        Button cookieBut = cookie.GetComponent<Button>();
        cookieBut.onClick.AddListener(TaskOnClick);

        InvokeRepeating("incCPS", 0f, 1f);
        StartCoroutine(SpawnGoldenCookie()); // Start the SpawnGoldenCookie coroutine
    }
    void TaskOnClick(){
        Cookies = Cookies + numClick; 
    }

    void goldOnClick(GameObject goldenCookie){
        Cookies = Cookies + goldClick;
        goldenCookie.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CookieText.text = Cookies.ToString();
    }
    
    IEnumerator CPS(){
     Cookies = Cookies + cps;
     yield return new WaitForSeconds(1);
    }

    public void incCPS()
    {
        StartCoroutine(CPS());
    }

    IEnumerator SpawnGoldenCookie()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3, 6)); // Wait for a random interval between 3 and 6 seconds

            Vector3 position = new Vector3(Random.Range(-800, 800),Random.Range(-375, 375), 0); // Set a specific position for the Golden Cookie

            GameObject goldenCookieContainer = new GameObject("GoldenCookieContainer");
            GameObject goldenCookie = Instantiate(goldenCookiePrefab, position, Quaternion.identity); // Spawn the Golden Cookie at the chosen position
            goldenCookie.transform.SetParent(goldenCookieContainer.transform);
            goldenCookie.SetActive(true); // Set the golden cookie to active

            Button goldCookieBenefit = goldenCookie.GetComponent<Button>();
            goldCookieBenefit.onClick.AddListener(() => goldOnClick(goldenCookie));

            yield return new WaitForSeconds(goldenCookie.GetComponent<GoldenCookie>().lifetime); // Wait for the lifetime of the Golden Cookie before spawning a new one
        }
    }
}
