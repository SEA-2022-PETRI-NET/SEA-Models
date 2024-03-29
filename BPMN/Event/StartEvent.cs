namespace SEA_Models.BPMN;

public class StartEvent : Event
{
    public StartEvent(int id) : base(id)
    { }

    public override void AddSourceFlow(SequenceFlow flow)
    {
        throw new InvalidOperationException("Start event cannot have a source flow");
    }
}
