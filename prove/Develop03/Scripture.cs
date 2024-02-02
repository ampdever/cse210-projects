public class Scripture {
    Reference _reference;
    List<Word> _words;
    Random rand = new();

    public Scripture (Reference reference, string text) {
        _reference = reference;
        _words = new List<Word>();
        
        string[] splitText = text.Split(" ");
        foreach (string word in splitText) {
            Word wordObject = new(word);
            _words.Add(wordObject);
        }

    }

    public void HideRandomWord(int numberToHide) {
        int count = 0;
        int trigger = 0;
        while (count < numberToHide || trigger == 10 || IsCompletelyHidden()) {
            for (int i = 0; i < _words.Count(); i++)
            {
                int random = rand.Next(0, 5);
                if (_words[i].isHidden()) {
                    trigger++;
                } else if (random == 1) {
                    _words[i].Hide();
                    count++;
                    i = _words.Count();
                } else trigger++;
            }
        }
    }

    public string GetDisplayText() {
        string scripture = _reference.getDisplayTextSingle();
        scripture = scripture + " ";
        foreach (Word word in _words){
             scripture = scripture + " " + word.GetDisplayText();
        };
        return scripture;
    }

    public bool IsCompletelyHidden() {
        foreach (Word word in _words){
             if (!word.isHidden()) {
                return false;
             } 
        };
        Console.WriteLine("isCompletelyHidden");
        return true;
    }
}