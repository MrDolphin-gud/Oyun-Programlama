using UnityEngine;

public class Laser : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private GameObject laserPrefab;
    
    [SerializeField]
    private float nextLaser = 0f;
    
    [SerializeField]
    private float fireRate=0.25f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextLaser)
        {
            Instantiate(laserPrefab, transform.position, Quaternion.identity);
            nextLaser = Time.time + fireRate;
        }
    }
}
