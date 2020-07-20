using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // Using this for string passwordToEdit = String.Empty;
using UnityEngine.UI; // Text and Input

public class Password : MonoBehaviour
{
    //public Text guideline = " ";
    public string pin = "1234";
    //[SerializedField]
    //InputField inputField = GameObject.Find("InputField");
    
    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {   
        
    }
    public void GetPin(){

        Text inputText = GameObject.Find("InputField/Text").GetComponent<Text>();
 
        //string pin = GameObject.Find("InputField/Text").GetComponent<Text>();

        if ( inputText.text == pin){
            Debug.Log("True!" + inputText.text);
            Destroy(GameObject.Find("InputField"));

            Text guideline = GameObject.Find("PIN").GetComponent<Text>();
            guideline.text = "Connect your headphone to this device.";

          
            Text buttonText = GameObject.Find("Button/Text").GetComponent<Text>();
            buttonText.text = "Start";
            InputField form = GameObject.Find("InputField").GetComponent<InputField>();
            form.text = "";
            
            //if(someCondition)
            //form.SetActive(false);
            
        }
        /*foreach (Transform child in gameObject.transform)
                {
                    //Remove the inputfield
                    Destroy(child.gameObject);
                }
            */
        
        /*GUI.Label(new Rect(450, 245, 100, 30), "Password"); To have password  
        passwordToEdit = GUI.PasswordField(new Rect(450, 270, 200, 20), passwordToEdit, "*"[0], 4);*/
    }
    

}
