using UnityEngine;

public class GameManager : MonoBehaviour
{
	int N = 10;
	GameObject[] agents = new GameObject[10];

	void Start()
	{
		for (int i = 0; i < N; i++)
		{
			GameObject agent = Resources.Load<GameObject>("Agent");
			GameObject instance = Instantiate(agent);

			if (i == 0)
			{
				instance.GetComponent<Agent>().target = GameObject.Find("Target").transform;
			}
			else
			{
				instance.GetComponent<Agent>().target = agents[i - 1].transform;
			}

			instance.transform.position = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0);
			instance.name = "Agent" + i.ToString();
			agents[i] = instance;
		}
	}
}
