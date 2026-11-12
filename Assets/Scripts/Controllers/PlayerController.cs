using UnityEngine;

public class PlayerController : Controller
{
    public KeyCode moveForward;
    public KeyCode moveBackward;

    public KeyCode yawClockwise;
    public KeyCode yawCounterclockwise;

    public KeyCode rollClockwise;
    public KeyCode rollCounterclockwise;

    public KeyCode pitchClockwise;
    public KeyCode pitchCounterclockwise;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }

    public override void MakeDecisions()
    {
        if (pawn != null)
        {
            if (Input.GetKey(moveForward))
            {
                pawn.MoveForward();
            }
            if (Input.GetKey(moveBackward))
            {
                pawn.MoveBackward();
            }
            if (Input.GetKey(yawClockwise))
            {
                pawn.YawClockwise();
            }
            if (Input.GetKey(yawCounterclockwise))
            {
                pawn.YawCounterclockwise();
            }
            if (Input.GetKey(rollClockwise))
            {
                pawn.RollClockwise();
            }
            if (Input.GetKey(rollCounterclockwise))
            {
                pawn.RollCounterclockwise();
            }
            if (Input.GetKey(pitchClockwise))
            {
                pawn.PitchClockwise();
            }
            if (Input.GetKey(pitchCounterclockwise))
            {
                pawn.PitchCounterclockwise();
            }
        }
    }
}
