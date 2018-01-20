using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectInteraction : MonoBehaviour {

    public float radiusToTarget = 3;
    GameObject[] targets;
    
	void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("effect");
    }

    void Update()
    {
        foreach(var effect in targets)
        {
            if (gameObject == effect)
                continue;
            if (Vector3.Distance(transform.position, effect.transform.position) < radiusToTarget)
            {
                Debug.Log("Лалка");
                var effectAction = GetComponent<IEffect>();
                if (effectAction != null)
                    effectAction.Run();

            }
        }

    }

}
