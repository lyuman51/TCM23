using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarFase : MonoBehaviour
{
    public string nomeDaFase;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            CarregarNovaFase();
        }
        
    }
    private void CarregarNovaFase()
    {
      SceneManager.LoadScene(nomeDaFase);
    }
}
