using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

	public Dialoge dialogue;

	public void TriggerDialogue()
	{
		FindObjectOfType<DialogeManager>().StartDialogue(Dialoge);
	}

}
