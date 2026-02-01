using UnityEngine;

public class Fruit : MonoBehaviour
{
    public FruitType type;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Basket"))
		{
		}
		else if (collision.gameObject.CompareTag("Ground"))
		{
			Destroy(gameObject);
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
