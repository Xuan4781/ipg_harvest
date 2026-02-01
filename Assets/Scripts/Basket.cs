using UnityEngine;

public class Basket : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Fruit"))
		{
			Debug.Log("Caught a " + collision.gameObject.GetComponent<Fruit>().type);
			Destroy(collision.gameObject);
		}
	}
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
