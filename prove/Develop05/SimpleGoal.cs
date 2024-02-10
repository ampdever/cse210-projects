public class SimpleGoal : Goal {
    private bool _isComplete;

    public SimpleGoal(string name, string desc, string points)
    : base (name, desc, points) {
        _isComplete = false;
    }

    public override void RecordEvent() {
        _isComplete = true;
    }

    public override bool isComplete() {
        return _isComplete;
    }

    public override string GetStringRepresentation() {
        return $"SG={this.GetName()}={this.GetDescription()}={this.GetPoints()}={isComplete()}";
    }
    public void setComplete(string value) {
        _isComplete = bool.Parse(value);
    }
}