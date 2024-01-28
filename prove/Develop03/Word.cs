public class Word {
    private string _text;
    private bool _isHidden;

    public Word (string text) {
        _text = text;
        _isHidden = false;
    }

    public void Hide() {
        this._isHidden = true;
    }

    public void Show() {
        this._isHidden = false;
    }

    public bool isHidden() {
        return _isHidden;
    }

    public string GetDisplayText() {
        if (isHidden()) {
            char[] chars = _text.ToCharArray();
            for (int i = 0; i < chars.Length; i++){
                chars[i] = '-';
            }
            return new string(chars);
        } else return _text;
    }

    
}