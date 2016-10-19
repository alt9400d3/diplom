using UnityEngine;
using System.Collections;

[RequireComponent (typeof(NavMeshAgent))]
public class navigationScript : MonoBehaviour
{
	#region PRIVATE

	private Animator _anim;
	private NavMeshAgent _selfAgent;
	private GameObject target;

	#endregion

	void Start ()
	{
		_anim = GetComponent<Animator> ();
		_anim.SetBool ("Walk", true);
		_anim.SetBool ("Attack", false);
		target = GameObject.FindGameObjectWithTag ("Finish");
		GetComponent<Attacker> ().SetTarget (target);
		_selfAgent = gameObject.GetComponent<NavMeshAgent> ();
	}


	void Update ()
	{
		_selfAgent.SetDestination (target.transform.position);

		if (Vector3.Distance (transform.position, target.transform.position) > 1)
		{
			_anim.SetBool ("Walk", true);
		}
		else
		{
			this.transform.LookAt (target.transform.position);
			_selfAgent.Stop ();
			_anim.SetBool ("Walk", false);
			_anim.SetBool ("Attack", true);
		}
	}
}
