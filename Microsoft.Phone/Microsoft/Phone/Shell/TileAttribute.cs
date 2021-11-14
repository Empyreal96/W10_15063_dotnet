// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.TileAttribute
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Shell
{
  [AttributeUsage(AttributeTargets.Property)]
  internal class TileAttribute : Attribute
  {
    private TILE_PROPERTY_TYPE propertyId;
    private string defaultValue;
    private string valueConverter;

    public TILE_PROPERTY_TYPE PropertyId
    {
      get => this.propertyId;
      set => this.propertyId = value;
    }

    public string DefaultValue
    {
      get => this.defaultValue;
      set => this.defaultValue = value;
    }

    public string ValueConverter
    {
      get => this.valueConverter;
      set => this.valueConverter = value;
    }
  }
}
