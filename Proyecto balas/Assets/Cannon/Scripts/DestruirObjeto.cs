
using UnityEngine;

public class DestruirObjeto : MonoBehaviour
{
    public float destroyTime;

    void Start()
    {
        Destroy(gameObject,destroyTime);


    }

}
