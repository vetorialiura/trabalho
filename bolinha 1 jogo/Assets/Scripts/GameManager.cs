using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI HUD, msgvitoria;
    public int restantes;
    public AudioClip ClipMoeda, ClipVitoria;

    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);

        restantes = FindObjectsOfType<moeda>().Length;

        HUD.text = $"Moedas restantes: {restantes}";
    }

    public void SubtrairMoedas(int valor)
    {  
    restantes -= valor;
         HUD.text = $"Moedas restantes: {restantes}";
        source.PlayOneShot(ClipMoeda);

        if(restantes <= 0)
        {
            msgvitoria.text = "Parabéns!";
            source.Stop();
             source.PlayOneShot(ClipVitoria);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
