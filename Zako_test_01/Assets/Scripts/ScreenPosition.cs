using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class ScreenPosition : MonoBehaviour
{
	[SerializeField]
	private Vector3 _position = new Vector3(0, 0, 10);
	public Vector3 position{
		get{
			return _position;
		}
		set{
			isChange = true;
			_position = value;
			transform.position = Camera.main.ScreenToWorldPoint(_position);
		}
	}
	
	private bool isChange = false;
	
	void Update()
	{
		if( transform.hasChanged && isChange == false ){
			_position = Camera.main.WorldToScreenPoint(transform.position);
		}else{
			isChange = false;
		}
	}
	
	void OnValidate()
	{
		position = _position;
	}

	void OnDrawGizmosSelected ()
	{
		float fov = Camera.main.fieldOfView;
		float size = Camera.main.orthographicSize;
		float max = Camera.main.farClipPlane;
		float min = Camera.main.nearClipPlane;
		float aspect = Camera.main.aspect;
		Gizmos.color = Color.white;
		Gizmos.matrix = Matrix4x4.TRS(Camera.main.transform.position, Camera.main.transform.rotation, new Vector3(aspect, 1.0f, 1.0f));

		if(Camera.main.orthographic)
		{
			Gizmos.DrawWireCube(new Vector3(0.0f, 0.0f, ((max - min) / 2.0f) + min), new Vector3(size * 2.0f, size * 2.0f, max - min));
		}
		else
		{
			Gizmos.DrawFrustum(Vector3.zero, fov, max, min, 1.0f);
		} 
	}
} 