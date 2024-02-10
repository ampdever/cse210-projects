public class EternalGoal : Goal {
    
    public EternalGoal(string name, string desc, string points)
    : base(name, desc, points) {
        //what else goes here? 
    }

    public override void RecordEvent() {
        
    }

    public override bool isComplete() {
        return false;
    }

    public override string GetStringRepresentation() {
        return $"EG={this.GetName()}={this.GetDescription()}={this.GetPoints()}";
    }
}