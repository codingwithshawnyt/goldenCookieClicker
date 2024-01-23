using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Upgrademenue : MonoBehaviour
{
    private Dictionary<string, int> PriceValues = new Dictionary<string, int>();
    public Button Upg1; //the first clickable button
    public Button Upg2;
    public Button Upg3;
    public Button Upg4;
    public Clicking currCook; //object with num of cookie
    public int price; // price of cookie
    //public BuyClick buyClick; 

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++){
            string index = i.ToString();
            PriceValues.Add(index, i+1);
        }
        
        Button upg1 = Upg1.GetComponent<Button>(); //this is the upgrade button
        Button upg2 = Upg2.GetComponent<Button>();
        Button upg3 = Upg3.GetComponent<Button>();
        Button upg4 = Upg4.GetComponent<Button>();
       // Clicking upgrade = Upg.GetComponent<Clicking>(); //this accesses the clicking file to see num of cookies have
        upg1.onClick.AddListener(buyUpg);//starts the buy action
        upg2.onClick.AddListener(buyUpg);
        upg3.onClick.AddListener(buyUpg);
        upg4.onClick.AddListener(buyUpg);
        //BuyClick buyClick = GetComponent<BuyClick>();// this should initiate the buying
      
       
    }

    public void buyUpg()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        if (currCook.Cookies >= price)
        {
            currCook.Cookies = currCook.Cookies-price;
            //currCook.cps = currCook.cps + 1;
            currCook.numClick = currCook.numClick + PriceValues[name];

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}




