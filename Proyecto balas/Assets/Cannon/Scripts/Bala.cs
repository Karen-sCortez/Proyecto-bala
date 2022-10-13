
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position += new Vector3(0, 0, 1) * speed * Time.deltaTime;
    }
}
