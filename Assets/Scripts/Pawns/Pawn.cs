using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    protected Rigidbody rb;

    public float forceAmount;

    public float yawRotationAmount;

    public float rollRotationAmount;

    public float pitchRotationAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        
    }

    public abstract void MoveForward();

    public abstract void MoveBackward();

    public abstract void YawClockwise();

    public abstract void YawCounterclockwise();

    public abstract void RollClockwise();

    public abstract void RollCounterclockwise();

    public abstract void PitchClockwise();

    public abstract void PitchCounterclockwise();
}
