using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI HUD, msgvitoria;
    public int restantes;

    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<moeda>().Length;

        HUD.text = $"Moedas restantes: {restantes}";
    }

    public void SubtrairMoedas(int valor)

    {  
    restantes -= valor;

        if(restantes <= 0)
        {
            msgvitoria.text = "Parabéns!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
