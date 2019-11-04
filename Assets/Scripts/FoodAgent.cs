using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class FoodAgent : Agent
{

    Rigidbody rbd;
    RayPerception rayPer;

    // for resetting
    internal Vector3 startPos;
    internal Vector3 startRot;

    //Constant move speed
    public float speed = 10;

    //Food Source target
    public Target target;

    //target positions to spawn
    public Transform[] TargetSpawns;
    // Start is called before the first frame update

    private void Start()
    {
        rbd = GetComponent<Rigidbody>();
        rayPer = GetComponent<RayPerception>();
        startPos = transform.position;
        startRot = transform.eulerAngles;
            
    }
    
    public override void CollectObservations()
    {
        float rayDistance = 50f;
        float[] rayAngles = {10f, 20f, 30f, 40f, 50f, 60f, 70f, 80f, 90f, 100f, 110f, 120f, 130f, 140f, 150f, 160f, 170f, 180f};
        string[] detectableObjects = {"wall", "goal"};
        AddVectorObs(rayPer.Perceive(rayDistance, rayAngles, detectableObjects, 0f, 0f));
    }

    public override void AgentAction(float[] vectorAction, string textAction)
    {
        Vector3 rotateDir = Vector3.zero;
        //float speed = 0;
        // If continuous action
        if(brain.brainParameters.vectorActionSpaceType == SpaceType.Continuous)
        {
            rotateDir = transform.up * Mathf.Clamp(vectorAction[0], -1f, 1f);
            //speed = Mathf.Clamp(vectorAction[1] , -1f, 1f ) * 20f;
        }

        //Rotate
        transform.Rotate(rotateDir, Time.deltaTime * 150f);

        //Move
        rbd.velocity = transform.forward * speed;

        //Time penalty
        AddReward(-0.0005f);
    }

    public override void AgentReset()
    {
        //Reset rotation and position
        transform.position = startPos;
        transform.eulerAngles = startRot;
        

        //reset velocity
        rbd.velocity = Vector3.zero;
        rbd.angularVelocity = Vector3.zero;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //If hit a wall
        if(collision.collider.CompareTag("wall"))
        {
            //Penalize
            AddReward(-1f);
            Done();
        }
    
        //If reached a goal
        if(collision.collider.CompareTag("goal"))
        {
            //Reward
            AddReward(10f);
            Done();
            //Spawn target to new location
            //int rand = Random.Range(0, TargetSpawns.Length);
            //target.transform.position = TargetSpawns[rand].position;
        }
    }   
}
