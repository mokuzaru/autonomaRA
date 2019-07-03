using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambio : MonoBehaviour
{
    public GameObject imagen;
    public GameObject prefab;
      public GameObject imagen2;

    public void Imagen(){
      //Instantiate(prefab, prefab.transform.SetParent(imagen.transform),Quaternion.identity);
      prefab.SetActive(true);
      //Destroy(imagen);
      imagen.SetActive(true);
      imagen2.SetActive(false);
    }
}
