using TMPro;
using UnityEngine;

public class GestoreLuce : MonoBehaviour
{
    
    public GameObject lampadina;
    private bool status = true;
    public TMP_Text testo_bottone;

    void Start()
    {
        toggleLight();
    }
    private void changeButtonText()
    {
        if (status)
        {
            testo_bottone.GetComponent<TMP_Text>().text = "Spegni la lampada";
        }
        else
        {
            testo_bottone.GetComponent<TMP_Text>().text = "Accendi la lampada";
        }
    }
    public void toggleLight()
    {
        lampadina.SetActive(status);

        changeButtonText();
        
        status = !status;
    }

}
