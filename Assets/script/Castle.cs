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
	
	// Update is called once per frame
	void Update ()
	{




	}

	public void addsc ()
	{  
		var newSkeleton = GameObject.Instantiate (Skeleton);
		newSkeleton.transform.SetParent (SpawnRoot);
		newSkeleton.transform.localPosition = Vector3.zero;
	}
}
