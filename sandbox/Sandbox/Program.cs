using System;

class Program
{
    static void Main(string[] args)
    {    
        Costume nurse = new Costume();

        nurse.headwear = "Facemask";
        nurse.gloves = "Nitrile";
        nurse.shoes = "Orthopedic Sneakers";
        nurse.upperGarment = "Scrups";
        nurse.lowerGarment = "Scrubs";
        nurse.accessory = "Stethoscope";


        Costume detective = new Costume();

        detective.headwear = "Fedora";
        detective.gloves = "Leather";
        detective.shoes = "Loafers";
        detective.upperGarment = "Trenchcoat";
        detective.lowerGarment = "Slacks";
        detective.accessory = "Magnifying Glass";


        //Call the behavior
        nurse.ShowWardrobe();
        detective.ShowWardrobe();
    }
}