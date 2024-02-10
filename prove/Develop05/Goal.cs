public class Goal {
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string name, string desc, string points) {
        _shortName = name;
        _description = desc;
        _points = points;
    }

    public virtual void RecordEvent() {

    }

    public virtual bool isComplete() {
        Console.WriteLine("inside goal isComplete");
        return false;
    }

    public virtual string GetDetailsString() {
        return $"{this.GetName()} ({this.GetDescription()})";
    }

    public virtual string GetStringRepresentation() {
        return "";
    }

    public string GetName() {
        return _shortName;
    }
    public string GetDescription() {
        return _description;
    }
    public string GetPoints() {
        return _points;
    }
    public virtual int GetBonus(){
        return 0;
    }
}