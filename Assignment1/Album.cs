using System;

public class Album
{
    private string albumName;
    private string artistName;
    private int numOfTracks;

    public Album()
    {
    }

    public void ReadAlbumData()
    {
        Console.Write("Enter name of album: ");
        albumName = Console.ReadLine();

        Console.Write("Enter name of artist: ");
        artistName = Console.ReadLine();

        Console.Write("Enter number of tracks in the album " + albumName + ": ");
        numOfTracks = int.Parse(Console.ReadLine());
    }

    public void DisplayAlbumData()
    {
        Console.WriteLine("----------------------");
        Console.WriteLine("Name: " + albumName);
        Console.WriteLine("Artist: " + artistName);
        Console.WriteLine("Number of tracks: " + numOfTracks);
        Console.WriteLine(albumName + " is an album made by the artist " + artistName + ". It has " + numOfTracks + " tracks.");
        Console.WriteLine("----------------------");
    }

    public void StartAlbum()
    {
        ReadAlbumData();
        DisplayAlbumData();
        Console.ReadLine();
    }
}