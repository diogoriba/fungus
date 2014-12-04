﻿using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Fungus
{
	[EventHandlerInfo("Sprites",
	                  "Drag Completed",
	                  "The sequence will execute when the player drags an object and successfully drops it on a target object.")]
	public class DragCompleted : EventHandler
	{	
		public Draggable2D draggableObject;
		public Collider2D targetObject;

		// There's no way to poll if an object is touching another object, so
		// we have to listen to the callbacks and track the touching state ourselves.
		bool overTarget = false;

		public virtual bool IsOverTarget()
		{
			return overTarget;
		}

		public virtual void OnDragEntered(Draggable2D draggableObject, Collider2D targetObject)
		{
			if (this.targetObject != null &&
			    targetObject == this.targetObject)
			{
				overTarget = true;
			}
		}

		public virtual void OnDragExited(Draggable2D draggableObject, Collider2D targetObject)
		{
			if (this.targetObject != null &&
			    targetObject == this.targetObject)
			{
				overTarget = false;
			}
		}

		public virtual void OnDragCompleted(Draggable2D draggableObject)
		{
			if (draggableObject == this.draggableObject &&
			    overTarget)
			{
				ExecuteSequence();
			}
		}
	}
}