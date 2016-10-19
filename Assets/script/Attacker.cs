using UnityEngine;
using System.Collections;


public class Attacker : MonoBehaviour
{
	private PlayerHealth _currentTarget;

	public int Damage;

	public void SetTarget (GameObject target)
	{
		this._currentTarget = target.GetComponentInParent<PlayerHealth> ();
	}


	public void AttackTarget ()
	{
		this._currentTarget.TakeHealth (Damage);
		Debug.Log ("attack");
	}
}
