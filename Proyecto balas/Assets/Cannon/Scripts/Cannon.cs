using UnityEngine;

public class Cannon : MonoBehaviour
{
    //public float speed;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
		{
            transform.Translate (new Vector3(0, 0, 1f));

            
            Shoot();

         

        }
    }
	
	private void Shoot()
	{
		Debug.Log("Disparaste dos balas!");
	}
}
