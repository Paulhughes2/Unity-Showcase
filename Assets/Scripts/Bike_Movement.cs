using UnityEngine;

public class Bike_Movement : MonoBehaviour
{
    public float BikeForward = 8f;
    public float BikeTurn = 6f;
    public GameObject Bike;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //float translation = Input.GetAxis("Vertical") * BikeForward;
        //float rotation = Input.GetAxis("Horizontal") * BikeTurn;
        //translation *= Time.deltaTime;
        //rotation *= Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, BikeForward * Time.deltaTime);
        }        
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, - BikeForward * Time.deltaTime);
        }        
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(- BikeTurn * Time.deltaTime, 0, 0);
         Bike.transform.rotation = Quaternion.Euler(0, -BikeTurn * Time.deltaTime, 0);
        }        
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(BikeTurn * Time.deltaTime, 0, 0);
         Bike.transform.rotation = Quaternion.Euler(0, BikeTurn * Time.deltaTime, 0);
        }







    }
}
