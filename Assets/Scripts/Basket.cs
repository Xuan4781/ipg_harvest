using UnityEngine;

public class Basket : MonoBehaviour
{
	public GameManager gameManager;
	private void OnCollisionEnter(Collision collision)
	{
		Fruit fruit = collision.gameObject.GetComponent<Fruit>();
		if (fruit != null)
		{
			gameManager.FruitCaught(fruit); 
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
