using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money_Display_Manager : MonoBehaviour
{
    //initialise variables/types
    string displayMoney;
    [SerializeField] Text moneyTracker;
    int curValue;

    // Start is called before the first frame update
    void Start()
    {
        //get the text component to change
       // moneyTracker = GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //set the text component to display current money
        curValue = Money_Manager.curMoney;
        displayMoney = "Money = " + curValue;
        moneyTracker.text = displayMoney;
    }
}
//