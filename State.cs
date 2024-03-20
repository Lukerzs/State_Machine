public abstract class State
{
    public readonly string Name { get; private set; }

    public State(string Name){
        this.Name=Name;
    }
    //set the virtual functions 
    public virtual void Enter(){}
    public virtual void Exit(){}
    public virtual void Update() { }

    public virtual void LateUpdate(){}

    public virtual void FixedUpdate(){}
}