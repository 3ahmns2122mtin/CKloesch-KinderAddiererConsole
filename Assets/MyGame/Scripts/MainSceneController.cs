using System;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneController : MonoBehaviour
{
    [SerializeField] private InputField inputFieldTermA, inputFieldTermB;
    [SerializeField] private Text txtResult;
    [SerializeField] private GameObject resetBtn;
    private int termA, termB;
    

    


    public int CheckAddition(int summandA, int summandB)
    {
        int result = 0;


        result = summandA + summandB;

        
        txtResult.text = string.Format("{0}", result);
        
        return result;
    }



    public void GetValues()
    {
        try
        { 
        termA = int.Parse(inputFieldTermA.text);
        }
        catch(System.Exception)
        {
            inputFieldTermA.GetComponent<InputField>().image.color = Color.red;
            inputFieldTermA.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Bitte gültige Zahl eingeben.";
            inputFieldTermA.text = "";  
        }

        try
        {
        termB = int.Parse(inputFieldTermB.text);
        }
        catch (System.Exception)
        {
            inputFieldTermB.GetComponent<InputField>().image.color = Color.red;
            inputFieldTermB.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Bitte gültige Zahl eingeben.";
            inputFieldTermB.text = "";
        }
        termA = int.Parse(inputFieldTermA.text);
        termB = int.Parse(inputFieldTermB.text);

        txtResult.text = CheckAddition(termA, termB).ToString();

        
        Debug.Log("Methode GetValues wird ausgeführt:" + CheckAddition(termA, termB));
    }
    
    public void ResetBtn()
    {

        inputFieldTermA.text = "";
        inputFieldTermB.text = "";
        txtResult.text = "result";
            termA = 0;
            termB = 0;
        inputFieldTermA.GetComponent<InputField>().image.color = Color.white;
        inputFieldTermB.GetComponent<InputField>().image.color = Color.white;
        inputFieldTermA.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Ganze Zahl eingeben...";
        inputFieldTermB.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Ganze Zahl eingeben...";
    }
    
    //man kann auch mit RegEX (Regular Expression) oder mit Parse Input arbeiten
    

}
