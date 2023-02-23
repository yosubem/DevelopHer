using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaribaleTest : MonoBehaviour{
    /*  private int num1 = 3;
       private int num2 = 1;
       private void Start(){
           Debug.Log(num1);
           Debug.Log(num2);
       }*/

    /*private string sentence = "This is Sparta!";
    void Start() {
        Debug.Log($"{sentence}");
        sentence = "Bye Bye";
        Debug.Log($"{sentence}");
    }*/

    /*pivate int  num1 = 4;
    private int num2 = 1;

    if(num1 < num2){
        Debug.Log()
    */


    //public string studentName = "Dana";

    void Start(){
       /* switch (studentName)
        {
            case "Razan":
                Debug.Log("This is Razan");
                break;
            case "Tal":
                Debug.Log("This is Tal");
                break;
            case "Almog":
                Debug.Log("This is Almog");
                break;
        }*/
        
        
    }

    private static void SwitchExmpale(int x){
        switch (x)
        {
            case 3:
                Debug.Log("This is Razan");
                break;
            case 1:
                Debug.Log("This is Tal");
                break;
            case 4:
                Debug.Log("This is Almog");
                break;
        }
    }

}
