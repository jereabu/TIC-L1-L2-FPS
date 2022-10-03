using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipularObjetos : MonoBehaviour
{
    [SerializeField]GameObject[] sillas;

    // Start is called before the first frame update
    void Start()
    {
        sillas = GameObject.FindGameObjectsWithTag("Silla");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            //DesactivarElementosDelArray();
            AgregarRBYBCAElementosDelArray();
        }
    }
    void DesactivarElementosDelArray()
    {

        for(int i = 0;i<sillas.Length; i++)
        {
            Debug.Log("Hay " + i + " sillas");
            sillas[i].SetActive(false);
        }
    }
    void AgregarRBYBCAElementosDelArray()
    {
        int i;
        for (i = 0; i < sillas.Length; i++)
        {
            sillas[i].AddComponent<Rigidbody>();
            sillas[i].AddComponent<BoxCollider>();
        }

        Debug.Log("Se le agrego RigidBody a " + i + " sillas");
    }
}
