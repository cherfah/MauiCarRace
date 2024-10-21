using System;

namespace MauiAppCSharpBasic1.Classes;

public class Car
{
    public string Model ;
    public string Color;
    public double speed;
    public double Fuel;
    public double TotalMlie;
    public double UseFuelRate; // xxx mile per liter


    public Car(string model , double speed , double fuel )
    {
        this.Model = model;
        this.speed = speed;
        this.Fuel = Fuel;
    }
    public void Run(double mile)
    {
        //this.TotalMile = this.TotalMile + Mile;
        this.TotalMlie += mile;
        var use_fuel = mile * this.UseFuelRate ;
        this.Fuel = this.Fuel - use_fuel;
        
        
    }

    public uint TimeUseForRun(double mile)
    {
        var timeuse = mile/speed;
        this.Run(mile);
        return Convert.ToUInt16(timeuse);
    }
    public string ShowInfo()
    {
        var info = $"Model { this.Model } \nTotal Mile : { this.TotalMlie }\nFuel : {this.Fuel }";
        return info;
    }
}
