public class Fraction {

    private int _top;
    private int _bottom;

    public Fraction() {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int topNumber) {
        _top = topNumber;
        _bottom = 1;
    }

    public Fraction (int topNumber, int bottomNumber) {
        _top = topNumber;
        _bottom = bottomNumber;
    }

    public int GetTop() {
        return _top;
    }

    public int GetBottom() {
        return _bottom;
    }

    public void SetTop(int top) {
        _top = top;
    }

    public void SetBottom(int bottom) {
        _bottom = bottom;
    }

    public string GetFractionString() {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue() {
        double dec = (double)_top/(double)_bottom;
        return dec;
    }
}