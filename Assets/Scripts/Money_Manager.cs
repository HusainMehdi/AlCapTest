using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Money_Manager : MonoBehaviour
{
    //intitialise variables/types
    public static int curMoney = 1000;

    bool decayOn = true;
    int secondCounter = 0;


    // Call these methods to change the money variable
    public void reduceBy(int val)
    {
        curMoney -= val;
    }

    public void increaseBy(int val)
    {
        curMoney += val;
    }



    // Start is called before the first frame update
    void Start()
    {
        //set starting money
        curMoney = 10000;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //debug/decay
        if (decayOn)
        {
            secondCounter += 1;
            if (secondCounter >= 60)
            {
                curMoney -= 1;
                secondCounter = 0;
            }
        }
        //print(curMoney);

        //if money runs out reset level
        if (curMoney <= 0)
        {
            SceneManager.LoadScene(0);
            //SceneManager.LoadScene("Scene_One", LoadSceneMode.Single);
        }
    }
}//
