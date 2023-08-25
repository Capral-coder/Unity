using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PathCreation;

public class Plane : MonoBehaviour {

  public PathCreator pathCreator;
	public float speed = 0.0f;
	public float distanceTravelled;
	public int acceleration = 0;
	public float acc = 0.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
    if (speed < -50.0f) {
      speed = -50.0f;
    } else if (speed > 50.0f) {
      speed = 50.0f;
    } else if (speed >= 0.0f && speed <= 1.5f && acceleration == 0) {
      speed = 0.0f;
    } else if (speed <= 0.0f && speed >= -1.5f && acceleration == 0) {
      speed = 0.0f;
    } else if (speed <= 50.0f) {
      speed += (Time.time/50)*acc*Time.deltaTime;
    }

		distanceTravelled += speed * Time.deltaTime;
		transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
		transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
    transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z + 90.0f);
    transform.position = new Vector3(transform.position.x, transform.position.y + 1.75f, transform.position.z);

    switch (acceleration) {
      case -1:
        acc = -1F;
        break;
      case -2:
        acc = -2F;
        break;
      case -3:
        acc = -3F;
        break;
      case -4:
        acc = -4F;
        break;
      case -5:
        acc = -5F;
        break;
      case 0:
        acc = 0.0f;
        break;
      case 5:
        acc = 5f;
        break;
      case 4:
        acc = 4f;
        break;
      case 3:
        acc = 3f;
        break;
      case 2:
        acc = 2F;
        break;
      case 1:
        acc = 1F;
      break;
    }


		if (acceleration < -5) {
			acceleration = -5;
		}
		if (acceleration > 5) {
			acceleration = 5;
		}
	}
}
