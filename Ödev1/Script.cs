using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int hız = 5;
    Vector3 pozisyon = new Vector3(2, 0, 0);
    
    void Start()
    {
        //transform.position += pozisyon;
        //transform.position += pozisyon * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += pozisyon;
        //transform.position += pozisyon * Time.deltaTime;
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        transform.position += new Vector3(yatay * Time.deltaTime * hız, dikey * Time.deltaTime * hız, 0);
    }
}

