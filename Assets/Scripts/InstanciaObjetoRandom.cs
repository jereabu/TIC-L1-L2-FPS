using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciaObjetoRandom : MonoBehaviour
{
    [SerializeField] GameObject[] objetosAInstanciar;
    // Start is called before the first frame update
    void Start()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            InstanciaObjeto(objetosAInstanciar[InstanciaObjetoRandom.Range(0, objetosAInstanciar.Length)]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void InstanciaObjeto(GameObject objeto)
    {
        instantiate(objeto,transform.position,transform.rotation);
    }
}
