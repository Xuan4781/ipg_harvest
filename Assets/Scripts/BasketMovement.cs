using UnityEngine;

public class BasketMovement : MonoBehaviour
{

	[Header("Movement Settings")]
	public float speed = 5f; 

	[Header("Optional Bounds")]
	public float xMin = -5f;
	public float xMax = 5f;
	public float zMin = -5f;
	public float zMax = 5f;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		// Get input
		float moveX = Input.GetAxis("Horizontal"); 
		float moveZ = Input.GetAxis("Vertical");  

		
		Vector3 movement = new Vector3(moveX, 0f, moveZ) * speed * Time.deltaTime;
		transform.Translate(movement, Space.World);
		
		Vector3 pos = transform.position;
		pos.x = Mathf.Clamp(pos.x, xMin, xMax);
		pos.z = Mathf.Clamp(pos.z, zMin, zMax);
		transform.position = pos;
	
}
}
