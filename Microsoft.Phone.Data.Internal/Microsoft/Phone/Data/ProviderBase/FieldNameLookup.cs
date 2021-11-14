// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.ProviderBase.FieldNameLookup
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using Microsoft.Phone.Data.Common;
using Microsoft.Phone.Data.Workaround;
using System.Diagnostics;
using System.Globalization;

namespace Microsoft.Phone.Data.ProviderBase
{
  internal sealed class FieldNameLookup
  {
    private Hashtable _fieldNameLookup;
    private string[] _fieldNames;
    private CompareInfo _compareInfo;
    private int _defaultLocaleID;

    public FieldNameLookup(IDataReader reader, int defaultLocaleID)
    {
      Debug.Assert(-1 == defaultLocaleID, "only invariant lookup supported");
      int fieldCount = reader.FieldCount;
      string[] strArray = new string[fieldCount];
      for (int i = 0; i < fieldCount; ++i)
      {
        strArray[i] = reader.GetName(i);
        Debug.Assert(strArray[i] != null, "MDAC 66681");
      }
      this._fieldNames = strArray;
      this._defaultLocaleID = defaultLocaleID;
    }

    public int GetOrdinal(string fieldName)
    {
      int num = fieldName != null ? this.IndexOf(fieldName) : throw ADP.ArgumentNull(nameof (fieldName));
      return -1 != num ? num : throw ADP.IndexOutOfRange(fieldName);
    }

    public int IndexOf(string fieldName)
    {
      if (this._fieldNameLookup == null)
        this.GenerateLookup();
      object obj = this._fieldNameLookup[(object) fieldName];
      int num;
      if (obj != null)
      {
        num = (int) obj;
      }
      else
      {
        num = this.LinearIndexOf(fieldName, CompareOptions.IgnoreCase);
        if (-1 == num)
          num = this.LinearIndexOf(fieldName, CompareOptions.IgnoreCase | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);
      }
      return num;
    }

    private int LinearIndexOf(string fieldName, CompareOptions compareOptions)
    {
      CompareInfo compareInfo = this._compareInfo;
      if (compareInfo == null)
      {
        Debug.Assert(-1 == this._defaultLocaleID, "Only InvariantCulture supported for lookups");
        if (compareInfo == null)
          compareInfo = CultureInfo.InvariantCulture.CompareInfo;
        this._compareInfo = compareInfo;
      }
      int length = this._fieldNames.Length;
      for (int index = 0; index < length; ++index)
      {
        if (compareInfo.Compare(fieldName, this._fieldNames[index], compareOptions) == 0)
        {
          this._fieldNameLookup[(object) fieldName] = (object) index;
          return index;
        }
      }
      return -1;
    }

    private void GenerateLookup()
    {
      int length = this._fieldNames.Length;
      Hashtable hashtable = new Hashtable(length);
      for (int index = length - 1; 0 <= index; --index)
      {
        string fieldName = this._fieldNames[index];
        hashtable[(object) fieldName] = (object) index;
      }
      this._fieldNameLookup = hashtable;
    }
  }
}
