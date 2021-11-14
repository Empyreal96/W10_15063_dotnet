// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.LeaderboardColumnFiller
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework.GamerServices.Stub;
using System;
using System.IO;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal class LeaderboardColumnFiller : ILeaderboardColumnFiller
  {
    internal bool IsReadOnly;
    internal PropertyDictionary Target;

    public void Reserve(int size) => this.Target = new PropertyDictionary(this.IsReadOnly, size);

    public void BeginFillData() => this.Target.BeginFillData();

    public void EndFillData() => this.Target.EndFillData();

    public void AddColumn(string name, Type type, bool readOnly)
    {
      PropertyValue propertyValue = (PropertyValue) null;
      if (type == typeof (int))
        propertyValue = (PropertyValue) new TypedPropertyValue<int>();
      else if (type == typeof (long))
        propertyValue = (PropertyValue) new TypedPropertyValue<long>();
      else if (type == typeof (float))
        propertyValue = (PropertyValue) new TypedPropertyValue<float>();
      else if (type == typeof (double))
        propertyValue = (PropertyValue) new TypedPropertyValue<double>();
      else if (type == typeof (Stream))
        propertyValue = (PropertyValue) new StreamPropertyValue();
      propertyValue.IsReadOnly = readOnly;
      this.Target.Add(name, propertyValue);
    }
  }
}
