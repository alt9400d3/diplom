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
		/*
        if (_remainingTime <= 0)
        {
            var newSkeleton = Instantiate(Skeleton);
            newSkeleton.transform.SetParent(SpawnRoot);
 //           newSkeleton.transform.localPosition = Vector3.zero;
			Skeleton.transform.position =SpawnRoot.transform.position;
			_remainingTime = SpawnTime;
        }else
        {
            _remainingTime -= Time.deltaTime;
        }
*/
	}

	public void addsc ()
	{  
		var newSkeleton = GameObject.Instantiate (Skeleton);
		newSkeleton.transform.SetParent (SpawnRoot);
		newSkeleton.transform.localPosition = Vector3.zero;
	}
}
