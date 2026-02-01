using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using TMPro;  

public class GameManager : MonoBehaviour
{
	[Header("Fruit Settings")]
	[SerializeField] private GameObject applePrefab;   
	[SerializeField] private Transform spawnCenter;    

	[Header("Spawn Area Settings")]
	[SerializeField] private float spawnWidth = 10f;  
	[SerializeField] private float spawnDepth = 10f;   
	[SerializeField] private float spawnHeight = 5f;   

	[Header("Spawn Settings")]
	[SerializeField] private int initialFruitCount = 20; // will change later
	[SerializeField] private float spawnInterval = 1f;   

	[Header("UI")]
	[SerializeField] private TextMeshProUGUI text_Score;

	[HideInInspector] public int score = 0;
	private float timer = 0f;

	void Start()
	{
		// spawn apple beginning -- going to reduce later
		for (int i = 0; i < initialFruitCount; i++)
		{
			SpawnApple();
		}
	}

	void Update()
	{

		timer += Time.deltaTime;
		if (timer > spawnInterval)
		{
			timer = 0f;
			SpawnApple();
		}

		if (text_Score != null)
			text_Score.text = "<color=#000fff>Score: </color>" + score;
	}


	void SpawnApple()
	{
		if (applePrefab == null || spawnCenter == null) return;

		GameObject apple = Instantiate(applePrefab);


		float xOffset = UnityEngine.Random.Range(-spawnWidth / 2f, spawnWidth / 2f);
		float zOffset = UnityEngine.Random.Range(-spawnDepth / 2f, spawnDepth / 2f);

		apple.transform.position = spawnCenter.position + new Vector3(xOffset, spawnHeight, zOffset);
	}

	// when apple get caught
	public void FruitCaught(Fruit fruit)
	{
		if (fruit.type == FruitType.Apple)
		{
			score += 10;
		}

		UnityEngine.Debug.Log("Caught an " + fruit.type + "! Score: " + score);
	}
}