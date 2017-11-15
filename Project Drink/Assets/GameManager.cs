using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

    public InputField iField;
    

    public string name1;
    public string name2;
    public string name3;
    public string name4;
    public string name5;
    public string name6;





    // Use this for initialization
    public void MyFunction () {


        name1 = iField.text;


        Debug.Log(name1);



    }

    // Update is called once per frame

}
