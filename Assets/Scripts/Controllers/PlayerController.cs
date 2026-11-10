using UnityEngine;

public class PlayerController : Controller
{
    public KeyCode moveForward;
    public KeyCode moveBackward;

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
        throw new System.NotImplementedException();
    }
}
