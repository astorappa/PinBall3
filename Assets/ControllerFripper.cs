using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerFripper : MonoBehaviour
{
    private HingeJoint myHiJoint;
    private float defaultAngle = 20;
    private float fickAngle = -20;
    // Start is called before the first frame update
    void Start()
    {
        this.myHiJoint = GetComponent<HingeJoint>();
        SetAngle(this.defaultAngle);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && tag == "LeftFripperTag")
        {
            SetAngle(this.fickAngle);
        }
        if ((Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A)) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && tag == "RightFripperTag")
        {
            SetAngle(this.fickAngle);
        }
        if ((Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D)) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && 
            (tag == "LeftFripperTag" || tag == "RightFripperTag"))
        {
            SetAngle(this.fickAngle);
        }
        if ((Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S)) &&
            (tag == "LeftFripperTag" || tag == "RightFripperTag"))
        {
            SetAngle(this.defaultAngle);
        }
    }
    public void SetAngle(float angle)
    {
        JointSpring jointspr = this.myHiJoint.spring;
        jointspr.targetPosition = angle;
        this.myHiJoint.spring = jointspr;
    }
}
