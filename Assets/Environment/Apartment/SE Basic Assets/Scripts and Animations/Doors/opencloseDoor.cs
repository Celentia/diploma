using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class opencloseDoor : MonoBehaviour
	{

		public Animator openandclose;
		public Transform Player;
		private bool open;
		private bool playerInRange;
   		// private float minDistance = 3;

		void Start()
		{
			open = false;
			this.Player = GameObject.FindWithTag("Player").transform;
        	playerInRange = false;
		}

		
		void Update()
		// void OnTriggerEnter(Collider collider)
		{
			
			if (playerInRange)
        {

			// Debug.Log(playerInRange);
			// float dist = Vector3.Distance(Player.position, transform.position);
			// if  (dist < minDistance)
			// {
				
				if (open == false)
				{
					if (Input.GetKeyDown("e"))
					{
					StartCoroutine(opening());
					}
				}
				else {
					
            if (DialogueManager.GetInstance().dialogueIsPlaying) 
            {
                return;
            }
				if (open == true) {
					if (Input.GetKeyDown("e"))
					{
					StartCoroutine(closing());
					}
				}

				}
				
			// }
		}
    }

	private void OnTriggerEnter(Collider collider) 
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider collider) 
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }


		// void OnMouseOver()
		// void OnTriggerEnter(Collider collider)
		// {
		// 	if (Input.GetKeyDown("e")) {
		// 		Debug.Log("test");
		// 	}
		// 	{
		// 		if (Player)
		// 		{
		// 			float dist = Vector3.Distance(Player.position, transform.position);
		// 			if (dist < 30)
		// 			{
		// 				if (open == false)
		// 				{
		// 					if (Input.GetKeyDown("e"))
		// 					{
		// 						StartCoroutine(opening());
		// 					}
		// 				}
		// 				else
		// 				{
		// 					if (open == true)
		// 					{
		// 						if (Input.GetKeyDown("e"))
		// 						{
		// 							StartCoroutine(closing());
		// 						}
		// 					}

		// 				}

		// 			}
		// 		}

		// 	}

		// }

		IEnumerator opening()
		{
			openandclose.Play("Opening");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			openandclose.Play("Closing");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}