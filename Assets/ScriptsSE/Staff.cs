using UnityEngine;

public class Staff : MonoBehaviour
{
    public float speed = 10;
    public GameObject bullet; 
    public Transform barrel;
    
    public void Fire()
    {
        GameObject spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
        spawnedBullet.GetComponent<Rigidbody>().linearVelocity = speed * barrel.forward;
        Destroy(spawnedBullet, 5);
    }
}
