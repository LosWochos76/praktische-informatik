﻿using System;

public class MenschlicherSpieler : Spieler
{
    public MenschlicherSpieler(char spielstein) : base(spielstein)
    {
    }

    private int KoordinateAbfragen(char achse)
    {
        int wert;

        do
        {
            Console.Write("Bitte " + achse + "-Koordinate eingeben:");
            wert = Convert.ToInt32(Console.ReadLine());
        }
        while (wert < 0 || wert > 2);

        return wert;
    }

    public override void Ziehe(Spielfeld feld)
    {
        feld.Ausgeben();

        int x;
        int y;

        while (true)
        {
            x = KoordinateAbfragen('X');
            y = KoordinateAbfragen('Y');

            if (feld.IstBelegt(x, y))
                Console.WriteLine("Koordinate ist bereits belegt!");
            else
                break;
        }

        feld.Setzen(x, y, Spielstein);
    }
}