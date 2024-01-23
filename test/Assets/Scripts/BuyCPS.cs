using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyClick : MonoBehaviour
{
    public Clicking upgrade;
    // Start is called before the first frame update
    void Start()
    {
        Clicking upgrade = GetComponent<Clicking>(); 
    }

    public void addClick() 
    {
        upgrade.numClick =+ 1;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
