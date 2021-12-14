using System;
using System.Collections.Generic;

namespace Parcel.Models
{
  public class ParcelItem
  {
    public int Weight { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public int Length { get; set; }

    private static List<ParcelItem> _allParcels = new List<ParcelItem>() { };

    public static List<ParcelItem> GetAll()
    {
      return _allParcels;
    }

    public static void ClearAll()
    {
      _allParcels.Clear();
    }

    public ParcelItem(int weight, int height, int width, int length)
    {
      Weight = weight;
      Height = height;
      Width = width;
      Length = length;
      _allParcels.Add(this);
    }

    public int Volume()
    {
      int volume = Length * Height * Width;
      return volume;
    }

    public int CostToShip()
    {
      return 2 * Weight * Volume();
    }
  }

}