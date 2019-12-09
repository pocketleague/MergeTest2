using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

	public bool move;

    void Start()
    {
        move = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(move){
        	transform.Translate(transform.right * 2 * Time.deltaTime);
        }
    }
}
