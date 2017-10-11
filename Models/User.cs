using System.Collections.Generic;

namespace Profiles.Models
{
  public class AppUser
  {
    private string _description;
    private int _id;
    private static List<AppUser> _instances = new List<AppUser> {};
    private string _address;
    private string _number;

    public AppUser (string description, string address, string number)
    {
      _description = description;
      _address = address;
      _number = number;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    //
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    //
    public string GetNumber()
    {
      return _number;
    }
    public void SetNumber(string newNumber)
    {
      _number = newNumber;
    }
    //
    public int GetId()
    {
      return _id;
    }
    //
    public static List<AppUser> GetAll()
    {
      return _instances;
    }
    //
    public static AppUser Find(int searchId)
    {
      return _instances[searchId-1];
    }
    //
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
