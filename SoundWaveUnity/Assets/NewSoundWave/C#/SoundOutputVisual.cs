using UnityEngine;
using System.Collections;

public class SoundOutputVisual : MonoBehaviour
{

	public bool DoublePush = false;

	public ParticleSystem emitter;
	// Update is called once per frame
	void Update ()
	{
	
		if (Input.GetKey (KeyCode.Joystick1Button2) && DoublePush == false) {
			emitter = GetComponent<ParticleSystem> ();
			
			// Emit one particle at the origin, shooting straight up.
			// The size of the particle is 0.2 and it will live 2 seconds long.
			emitter.Emit (new Vector3 (0, 0, 0), new Vector3 (0, 0, 0), 1, 0.3f, new Color (0.647f, 0.870f, 0.894f));
		}
		if (Input.GetKey (KeyCode.Joystick1Button0) && DoublePush == false) {
			emitter = GetComponent<ParticleSystem> ();
			
			// Emit one particle at the origin, shooting straight up.
			// The size of the particle is 0.2 and it will live 2 seconds long.
			emitter.Emit (new Vector3 (0, 0, 0), new Vector3 (0, 0, 0), 1, 0.3f, new Color (0.709f, 0.792f, 0.627f));
		}
		if (Input.GetKey (KeyCode.Joystick1Button2) && Input.GetKey (KeyCode.Joystick1Button0)) {
			DoublePush = true;
			emitter = GetComponent<ParticleSystem> ();
			
			// Emit one particle at the origin, shooting straight up.
			// The size of the particle is 0.2 and it will live 2 seconds long.
			emitter.Emit (new Vector3 (0, 0, 0), new Vector3 (0, 0, 0), 1, 0.3f, new Color (0.400f, 0.729f, 0.717f));
		}
		if (Input.GetKeyUp (KeyCode.Joystick1Button0) || Input.GetKeyUp (KeyCode.Joystick1Button2)) {
			DoublePush = false;
		}
		if (Input.GetAxis ("360_Triggers") < -0.9) {
			emitter = GetComponent<ParticleSystem> ();
			
			// Emit one particle at the origin, shooting straight up.
			// The size of the particle is 0.2 and it will live 2 seconds long.
			emitter.Emit (new Vector3 (0, 0, 0), new Vector3 (0, 0, 0), 1, 0.3f, new Color (0.980f, 0.839f, 0.537f));
		}
		if (Input.GetAxis ("360_Triggers") > 0.9 && PlayerInputPower.Trigger == false) {
			emitter = GetComponent<ParticleSystem> ();
			
			// Emit one particle at the origin, shooting straight up.
			// The size of the particle is 0.2 and it will live 2 seconds long.
			emitter.Emit (new Vector3 (0, 0, 0), new Vector3 (0, 0, 0), 1, 0.3f, new Color (0.956f, 0.654f, 0.725f));
		}

	}
}
