public class ChecklistGoal : Goal {
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string desc, string points, int target, int bonus) 
    :base(name, desc, points) {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent() {
        _amountCompleted++;
        if (_amountCompleted/_target == 1) {
            Console.WriteLine("Congrats! You've completed this entire goal.");
        }
    }

    public override bool isComplete() {
        if (_amountCompleted/_target == 1) {
            return true;
        } else return false;
    }

    public override string GetDetailsString() {
        return $"{this.GetName()} ({this.GetDescription()}) -- Currently Completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation() {
        return $"CG={this.GetName()}={this.GetDescription()}={this.GetPoints()}={_target}={_bonus}={_amountCompleted}";
    }
    public override int GetBonus(){
        return _bonus;
    }
    public void setAmountCompleted(string num) {
        _amountCompleted = int.Parse(num);
    }
}