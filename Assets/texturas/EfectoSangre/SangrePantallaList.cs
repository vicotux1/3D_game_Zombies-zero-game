using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SangrePantallaList : MonoBehaviour
{
    public GameObject[] Sangre;


    public void SangreEnPantalla(object sangre)
    {
        Sangre[Random.Range(0, Sangre.Length)].SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
       


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
