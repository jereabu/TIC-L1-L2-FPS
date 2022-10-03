using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuscarElementoEnElArray : MonoBehaviour
{
    [SerializeField] GameObject[] arrayDeMesas;
    [SerializeField] string tagDeMesa;
    // Start is called before the first frame update
    void Start()
    {
        arrayDeMesas = GameObject.FindGameObjectsWithTag(tagDeMesa);

    }

    // Update is called once per frame
    void Update()
    {
        //para buscar un elemento usamos un while
        if(Input.GetKeyDown(KeyCode.T))
        {
            BuscarElemento();
        }
        
    }
    void BuscarElemento()
    {
        bool isFound = false;
        int i = 0;
        while(i < arrayDeMesas.Length && !isFound)
        {
            if (arrayDeMesas[i].GetComponent<Mesa>().dueño == "Jeronimo")
            { 
                
                Destroy(arrayDeMesas[i]);
                return;
            }
            i++;
        }
    }
}
