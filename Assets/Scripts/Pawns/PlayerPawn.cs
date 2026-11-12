using UnityEngine;

public class PlayerPawn : Pawn
{
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

    public override void MoveBackward()
    {
        Vector3 forceDirection = -transform.forward * forceAmount;

        if (rb != null)
        {
            rb.AddForce(forceDirection, ForceMode.Force);
        }
    }

    public override void MoveForward()
    {
        Vector3 forceDirection = transform.forward * forceAmount;

        if (rb != null)
        {
            rb.AddForce(forceDirection, ForceMode.Force);
        }
    }

    public override void PitchClockwise()
    {
        transform.Rotate(pitchRotationAmount * Time.deltaTime, 0.0f, 0.0f);
    }

    public override void PitchCounterclockwise()
    {
        transform.Rotate(-pitchRotationAmount * Time.deltaTime, 0.0f, 0.0f);
    }

    public override void RollClockwise()
    {
        transform.Rotate(0.0f, 0.0f, -rollRotationAmount * Time.deltaTime);
    }

    public override void RollCounterclockwise()
    {
        transform.Rotate(0.0f, 0.0f, rollRotationAmount * Time.deltaTime);
    }

    public override void YawClockwise()
    {
        transform.Rotate(0.0f, yawRotationAmount * Time.deltaTime, 0.0f);
    }

    public override void YawCounterclockwise()
    {
        transform.Rotate(0.0f, -yawRotationAmount * Time.deltaTime, 0.0f);
    }
}
