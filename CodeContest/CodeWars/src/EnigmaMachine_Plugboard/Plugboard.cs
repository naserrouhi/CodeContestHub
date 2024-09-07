namespace EnigmaMachine_Plugboard;

public class Plugboard
{
    private readonly List<string> _wirePairs;

    public Plugboard(string wires = "")
    {
        var wiresLength = wires.Length;
        if (wiresLength % 2 != 0)
            throw new ArgumentException("Wires are not valid.");

        if (wires.Length > 20)
            throw new ArgumentException("Maximum allowed wires is 10.");

        _wirePairs = new();
        for (var i = 0; i < wires.Length; i += 2)
        {
            var firstElement = wires[i].ToString();
            var secondElement = wires[i + 1].ToString();

            var isWireElementDuplicated = _wirePairs.Any(w => (w.Contains(firstElement) && !w.Contains(secondElement)) ||
                                                              (!w.Contains(firstElement) && w.Contains(secondElement)));
            if (isWireElementDuplicated)
                throw new ArgumentException("There is a conflict between wires.");

            var isWireDuplicated = _wirePairs.Any(w => w.Contains(firstElement) && w.Contains(secondElement));
            if (isWireDuplicated)
                throw new ArgumentException("Wires are duplicated.");

            _wirePairs.Add(firstElement + secondElement);
        }
    }

    public char Process(char character)
    {
        var wirePair = _wirePairs.FirstOrDefault(w => w.Contains(character));

        if (wirePair is null)
            return character;

        var indexOfCharacter = wirePair.IndexOf(character);

        return indexOfCharacter == 0 ? wirePair[1] : wirePair[0];
    }
}