using System;
using System.Collections.Generic;

namespace SubRenamer
{
  [Serializable]
  public class ExtensionList : List<string>
  {
    public override string ToString()
    {
      string totalStr = "";
      foreach (string myString in this)
      {
        totalStr = totalStr + myString + ";";
      }
      char[] charArray = {';'};
      if (totalStr != "")
        totalStr = totalStr.TrimEnd(charArray);
      return totalStr;
    }

    public string ToStringCustom()
    {
      string totalStr = "";
      foreach (string myString in this)
      {
        totalStr = totalStr + "*" + myString + ";";
      }
      char[] charArray = {';'};
      if (totalStr != "")
        totalStr = totalStr.TrimEnd(charArray);
      return totalStr;
    }

    public static ExtensionList Parse(string myString)
    {

      var separator = new string[1];
      separator[0] = ";";
      string[] myStrArray = myString.Split(separator, StringSplitOptions.RemoveEmptyEntries);
      var myExtList = new ExtensionList();
      foreach (string ext in myStrArray)
      {
        myExtList.Add(ext);
      }
      return myExtList;
    }
  }
}