using System.Threading.Channels;

class MusicalInstrument
{
    string? countCord;
    string? additionalInstrument;
}

class Violin : MusicalInstrument
{
    public void SoundOfViolin () => Console.WriteLine("Some sound of violin...");
    public void NameOfInstument() => Console.WriteLine("Name: violin");
    public void DescOfViolin() => Console.WriteLine("Violin is bowed musical instrument with 4 strings tuned in fifths: Cb Gb Dm Am." +
        " In terms of sound height, it occupies an intermediate position between a higher alto and a low double bass.");
    public void HistoryofcreationViolin() => Console.WriteLine("The appearance of the cello dates back to the late 15th and early 16th centuries as a result of the long development of folk bowed instruments." +
        " Initially, it was used as a bass instrument in various ensembles, to accompany singing or performance on an instrument of a higher register (violin, flute, etc.).");
}

class Trombone : MusicalInstrument
{
    public void SoundOfTrombone() => Console.WriteLine("Some sound of trombone...");
    public void NameOfInstument() => Console.WriteLine("Name: trombone");
    public void DescOfTrombone() => Console.WriteLine("Trombone a brass musical instrument, the distinctive feature of which is the presence of a movable backstage, instead of the usually used valves, to obtain a chromatic scale.");
    public void HistoryOfCreationTrombone() => Console.WriteLine("The appearance of the trombone dates back to the 15th century." +
        " It is generally accepted that the immediate predecessors of this instrument were rocker trumpets, when playing which the musician had the opportunity to move the instrument tube, thus obtaining a chromatic scale." +
        " Such trumpets were used to double the voices of a church choir, given the similarity of the timbre of the trumpet to the human voice." +
        " It was only necessary to achieve similarity of intonation, for which they made a backstage that gives chromaticism and vibrato");
}

class Ukulele : MusicalInstrument
{
    public void SoundOfUkulele() => Console.WriteLine("Some sound of ukulele...");
    public void NameOfInstument() => Console.WriteLine("Name: ukulele");
    public void DescOfUkulele() => Console.WriteLine("Ukulele is Hawaiian four-string guitar used for chord accompaniment of songs and playing solos.");
    public void HistoryOfCreationUkulele() => Console.WriteLine("The history of the ukulele originates in Europe, where fretted string instruments had been developing for a long time by the 18th century." +
        " The origin of the ukulele is connected with the need of the then traveling musicians to have convenient miniature guitars and lutes. " +
        "In response to this need, the cavaquinho, the ancestor of the ukulele, appeared in Portugal.");
}
class Cello : MusicalInstrument
{
    public void SoundOfCello() => Console.WriteLine("Some sound of cello...");
    public void NameOfInstument() => Console.WriteLine("Name: cello");
    public void DescOfCello() => Console.WriteLine("Cello is bowed musical instrument with 4 strings tuned in fifths: Cb Gb Dm Am." +
        " In terms of sound height, it occupies an intermediate position between a higher alto and a low double bass.");
    public void HistoryOfCreationCello() => Console.WriteLine("The appearance of the cello dates back to the late 15th and early 16th centuries as a result of the long development of folk bowed instruments." +
        " Initially, it was used as a bass instrument in various ensembles, to accompany singing or performance on an instrument of a higher register (violin, flute, etc.).");
}
enum Instrument:byte 
{
    Violion = 1,
    Trombone,
    Ukulele,
    Cello
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi. Choose instrument: \n1.Violin \n2.Trombone \n3.Ukulele \n4.Cello");
        byte chooseInstrument = Convert.ToByte(Console.ReadLine()); 
        while (chooseInstrument > 4)
        {
            Console.WriteLine("Incorrect input. Choose instrument (1-4)");
            chooseInstrument = Convert.ToByte(Console.ReadLine());
        }
        switch (chooseInstrument)
        {
            case (byte)Instrument.Violion:
                {
                    Violin violin = new Violin();
                    violin.NameOfInstument();
                    violin.SoundOfViolin();
                    violin.DescOfViolin();
                    violin.HistoryofcreationViolin();
                    break;
                }
            case (byte)Instrument.Trombone:
                {
                    Trombone trombone = new Trombone(); 
                    trombone.NameOfInstument();
                    trombone.SoundOfTrombone();
                    trombone.DescOfTrombone();
                    trombone.HistoryOfCreationTrombone();
                    break;
                }
            case (byte)Instrument.Ukulele:
                {
                    Ukulele ukulele = new Ukulele();
                    ukulele.NameOfInstument();
                    ukulele.SoundOfUkulele();
                    ukulele.DescOfUkulele();
                    ukulele.HistoryOfCreationUkulele();
                    break;
                }
            case (byte)Instrument.Cello:
                {
                    Cello cello = new Cello();
                    cello.NameOfInstument();
                    cello.SoundOfCello();
                    cello.DescOfCello();
                    cello.HistoryOfCreationCello();
                    break;
                }
        }
    }
}