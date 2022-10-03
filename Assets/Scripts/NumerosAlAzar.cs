using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumerosAlAzar : MonoBehaviour
{
    [SerializeField] int randomNum;
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            GemerarNumero();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GemerarNumero()
    {
        randomNum = Random.Range(5, 21);
        Debug.Log("El numero aleatorio es " + randomNum);
    }
}
