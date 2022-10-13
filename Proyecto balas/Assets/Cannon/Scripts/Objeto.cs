using UnityEngine;

public class Objeto : MonoBehaviour
{
   
  
    public GameObject objetoAInstanciar;
    public Vector3 posicionAInstanciar;
    
    void Start()
    {
        Instantiate(objetoAInstanciar,posicionAInstanciar,transform.rotation);
    }

   
    
}
