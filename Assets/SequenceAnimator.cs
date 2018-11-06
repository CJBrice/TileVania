using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceAnimator : MonoBehaviour {

    [SerializeField] float animationDelay = 0.5f;

    List<Animator> _animators;

	void Start () {
        _animators = new List<Animator>(GetComponentsInChildren<Animator>());

        StartCoroutine(DoAnimation());
	}
	
    IEnumerator DoAnimation()
    {
        while(true)
        {
            foreach (var animator in _animators)
            {
                animator.SetTrigger("DoAnimation");
                yield return new WaitForSeconds(animationDelay);
            }
            yield return new WaitForSecondsRealtime(1);
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
