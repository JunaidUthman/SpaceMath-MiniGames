using UnityEngine;

public class PipeMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float movespeed=5;
    public float deadZone = -35;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.left * movespeed * Time.deltaTime;
    
        if(transform.position.x< deadZone)
        {
            Destroy(gameObject);
        }
    }
}
