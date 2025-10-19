using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private float speed=1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Laser();
    }

    void Laser()
    {
        transform.Translate(Vector3.up * (speed * Time.deltaTime));
        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        } 
    }
}
