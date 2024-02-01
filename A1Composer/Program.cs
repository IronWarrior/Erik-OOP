class Program
{
    class Composition
    {
        public List<Note> Notes;
    }

    struct Note
    {
        public Name Name;
        public Duration Duration;

        public Note(Name name, Duration duration)
        {
            Name = name;
            Duration = duration;
        }
    }

    enum Duration
    {
        Quarter, Half, Whole
    }

    enum Name
    {
        A, B, C, D, E, F, G
    }

    static void Main()
    {
        Composition composition = new Composition();
        composition.Notes.Add(new Note(Name.A, Duration.Quarter));

        // This is a composition.
        List<string> notes = new List<string>();
        List<string> durations = new List<string>();

        notes.Add("A");
        notes.Add("B");
        notes.Add("C");
        notes.Add("D");
        notes.Add("E");
        notes.Add("F");
        notes.Add("G");

        durations.Add("1");
        durations.Add("1");
        durations.Add("1/2");
        durations.Add("1/2");
        durations.Add("1/4");
        durations.Add("1/4");
        durations.Add("1/4");

        // Print the notes to the user.
        for (int i = 0; i < notes.Count; i++)
        {
            Console.WriteLine($"{notes[i]} {durations[i]}");
        }

        // Delete the last note.
        durations.RemoveAt(durations.Count - 1);
        notes.RemoveAt(notes.Count - 1);

        Console.WriteLine();
        Console.WriteLine();

        // Print the notes to the user.
        for (int i = 0; i < notes.Count; i++)
        {
            Console.WriteLine($"{notes[i]} {durations[i]}");
        }

        Dictionary<string, int> noteNamesToFrequencies = new Dictionary<string, int>()
        {
            { "A", 440 }, { "B" , 999}, { "C", 999 }
        };

        Dictionary<string, int> durationsToMilliseconds = new Dictionary<string, int>()
        {
            { "1", 1000 }, { "1/2", 500 } 
        };

        for (int i = 0; i < notes.Count; i++)
        {
            int frequency = noteNamesToFrequencies[notes[i]];
            int duration = durationsToMilliseconds[durations[i]];

            Console.Beep(frequency, duration);
        }
    }
}
