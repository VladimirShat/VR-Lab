//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Sends UnityEvents for basic hand interactions
//
//=============================================================================

using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	[RequireComponent( typeof( Interactable ) )]
	public class InteractableHoverEvents : MonoBehaviour
	{
		public UnityEvent onHandHoverBegin;
		public UnityEvent onHandHoverEnd;
		public UnityEvent onAttachedToHand;
		public UnityEvent onDetachedFromHand;
		public GameObject otherCube;

		//-------------------------------------------------
		private void OnHandHoverBegin()
		{
			Renderer rend = gameObject.GetComponent<Renderer>();
			onHandHoverBegin.Invoke();
			rend.enabled = true;

			/*Renderer rendOther = otherCube.GetComponent<Renderer>();
			if (rendOther.isVisible == true)
            {
				onHandHoverBegin.Invoke();
				rend.enabled = true;
			}*/
		}


		//-------------------------------------------------
		private void OnHandHoverEnd()
		{
			/*Renderer rend = gameObject.GetComponent<Renderer>();
			onHandHoverEnd.Invoke();
			rend.enabled = false;

			Renderer rendOther = otherCube.GetComponent<Renderer>();
			if (rendOther.isVisible == false)
			{
				onHandHoverBegin.Invoke();
				rend.enabled = false;
			}*/
		}


		//-------------------------------------------------
		private void OnAttachedToHand( Hand hand )
		{
			onAttachedToHand.Invoke();
		}


		//-------------------------------------------------
		private void OnDetachedFromHand( Hand hand )
		{
			onDetachedFromHand.Invoke();
		}
	}
}
