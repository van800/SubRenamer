using System;
using System.Collections.Generic;
using System.Text;

namespace SubRenamer
{
    [Serializable]
    public class ExtensionList:List<string>
    {

        public override string ToString()
        {
            string totalStr = "";
            foreach (string myString in this)
            {
                totalStr = totalStr + myString + ";";
            }
            char[] charArray = { ';' };
            if (totalStr != "")
                totalStr = totalStr.TrimEnd(charArray);
            return totalStr;
        }
        public string ToStringCustom()
        {
            string totalStr = "";
            foreach (string myString in this)
            {
                totalStr = totalStr + "*"+myString + ";";
            }
            char[] charArray = { ';' };
            if (totalStr != "")
                totalStr = totalStr.TrimEnd(charArray);
            return totalStr;
        }

        public static ExtensionList Parse(string myString)
        {

            string[] separator = new string[1];
            separator[0] = ";";
            string[] myStrArray=myString.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            ExtensionList myExtList = new ExtensionList();
            foreach (string Ext in myStrArray)
            {
                myExtList.Add(Ext);
            }
            return myExtList;
        }
    }
}
