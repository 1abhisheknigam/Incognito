using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInteraction : MonoBehaviour,Interactable {
    public GameObject Player;
    public DoneCameraMovementCamp main;
    public Transform[] wheels;

    private bool playerIn;

    float maxSteer = 25f;
    public void Interact(GameObject player)
    {
        Debug.logger.Log("Interacted");
        gameObject.isStatic = false;
        playerIn = true;
        main.setTarget(this.transform);
        //GetComponent<BoxCollider>().enabled = false;
        GetComponent<SphereCollider>().enabled = false;
        player.SetActive(false);
  
    }

    // Use this for initialization
    void Start () {
        playerIn = false;        
	}
	
	// Update is called once per frame
	void Update () {
        if (playerIn)
        {
            Player.transform.position = transform.position;
            //float hor = Input.GetAxisRaw("Horizontal");
            //float vert = Input.GetAxisRaw("Vertical");
            //transform.position = new Vector3(transform.position.x + hor, transform.position.y, transform.position.z + vert);

            //Vector3.MoveTowards(transform.position, new Vector3(transform.position.x + hor, transform.position.y, transform.position.z + vert),1);
            float power = Input.GetAxis("Vertical") * 150f * Time.deltaTime * 250.0f;
            float steer = Input.GetAxis("Horizontal") * maxSteer;

            GetCollider(2).steerAngle = steer;
            GetCollider(3).steerAngle = steer;

            GetCollider(0).brakeTorque = 0;
            GetCollider(1).brakeTorque = 0;
            GetCollider(2).brakeTorque = 0;
            GetCollider(3).brakeTorque = 0;
            GetCollider(1).motorTorque = power;
            GetCollider(2).motorTorque = power;

            if(Input.GetAxis("Jump")!=0){
               Player.transform.position = new Vector3(transform.position.x, 1, transform.position.z);
               Player.SetActive(true);
               main.resetTarget();
               DestroyImmediate(gameObject);
            }
        }
	}

    public WheelCollider GetCollider(int i)
    {
        return wheels[i].gameObject.GetComponent<WheelCollider>();
    }
}
