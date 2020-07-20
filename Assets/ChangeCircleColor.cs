using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//importing UI class
using UnityEngine.UI;
using System;

public class ChangeCircleColor : MonoBehaviour
{   
    //Image component declaration  
    private Image m_Image;
    //Sprite object declaration
    public Sprite [] m_Sprite;
    //The boolean to change spirte object
    private bool change;

    public int x = 0;

    

    // Start is called before the first frame update
    void Start()
    {   //Initialization for boolean variable
        change = false;
        //Store Image component into the m_image after finding the image
        m_Image = GameObject.Find("Circle").GetComponent<Image>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeCircle()
    {   
        Text inputText = GameObject.Find("CircleInput/Text").GetComponent<Text>();
         
         Int32.TryParse(inputText.text, out x);
         
        // Find Value 
        if (x > 80 & x < 100 )
        {   
            Console.WriteLine(change ? "Checked" : "Not checked");  // output: Checked

            // if sprite object is ture
            if (change)
            {
                // change the sprite object
                //store the first sprite object array in the mImage
                m_Image.sprite = m_Sprite[0];
                change = false;
                Console.WriteLine(change ? "Checked" : "Not checked");  // output: Checked
            }
            // if sprite object is false
            else
            {
                // change sprie object
                // store the sedond sprite object array in the mImage
                m_Image.sprite = m_Sprite[1];
                change = true;
                Console.WriteLine(change ? "Checked" : "Not checked");  // output: Checked
            }
        }
    }
}
