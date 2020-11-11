using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class EmilyRoseController1: MonoBehaviour {

	IEnumerator Start() {
		yield return null;
		GetComponent<Animator>().enabled = false;
	}

	[Button]
	public void LaunchEmily() {
		StartCoroutine(LaunchEmilyCoroutine());
	}

	IEnumerator LaunchEmilyCoroutine() {
		GetComponent<Animator>().enabled = true;
		yield return new WaitForSeconds(1.2f);
		//Darkener.instance.ShockThePlayer();
		//yield return new WaitForSeconds(0.4f);
        //gameObject.SetActive(false);
        GetComponent<Animator>().enabled = false;
    }
}
