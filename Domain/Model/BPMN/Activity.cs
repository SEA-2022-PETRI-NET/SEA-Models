namespace SEA_Models.Domain.Model.BPMN;

public class Activity : Node
{
    public string Name { get; set; }

    public Activity(int id, string name) : base(id)
    {
        this.Name = name;
    }
}