using UnityEngine;
using System.Collections;

public class Castle : MonoBehaviour
{
	private float _remainingTime;
	public Transform SpawnRoot;
	public GameObject Skeleton;

	void Start ()
	{
		
	}

	void Update ()
	{






	}

	public void AddSkileton ()
	{  
		var newSkeleton = GameObject.Instantiate (Skeleton);
		newSkeleton.transform.SetParent (SpawnRoot);
		newSkeleton.transform.localPosition = Vector3.zero;
		newSkeleton.transform.LookAt (GameObject.FindGameObjectWithTag ("Finish").transform.position);
	}
}
