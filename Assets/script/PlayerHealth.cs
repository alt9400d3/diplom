using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
	public float max_Health = 100f;
	public float cur_Health = 0f;
	public GameObject healthBar;
	public GameObject Bar;

	void Start ()
	{
		cur_Health = max_Health;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Bar.transform.LookAt (Camera.main.transform.position);
	}

	public void SetHealthBar (float myHealth)
	{
		healthBar.transform.localScale = new Vector3 (myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}

	public void  TakeHealth (int amount)
	{
		if (cur_Health > 0)
		{
			cur_Health -= amount;
			float calc_Health = cur_Health / max_Health;
			SetHealthBar (calc_Health);	
		}
		else
		{
			Debug.Log ("Башня сдохла! Наши победили!!!!!");
		}


	}
	//	publick
}
