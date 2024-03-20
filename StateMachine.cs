public class StateMachine
{

    private State currentState;

    public string currentStateName { get; private set; }

    public void update()
    {
        currentState?.Update();
    };

    public void LateUpdate()
    {
        currentState?.LateUpdate();
    }

    public void FixedUpdate()
    {
        currentState?.FixedUpdate();
    }

    private void ChangeState(State newState)
    {
        currentState?.Exit();
        currentState=newState;
        currentStateName=newState?.Name;
        newState?.Enter();

    }
}