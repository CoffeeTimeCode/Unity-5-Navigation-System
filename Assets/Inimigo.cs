using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour {

	private NavMeshAgent _agente;
	public Transform _player;

	// Use this for initialization
	void Start () {
		_agente = this.gameObject.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(this.transform.position,_player.position)>3)
		{
			_agente.destination = _player.position;
		}
	}
}
