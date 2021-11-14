// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.StreamPropertyValue
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System;
using System.IO;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal class StreamPropertyValue : PropertyValue
  {
    private int handle;
    private Stream stream;

    public int Handle
    {
      set
      {
        this.handle = value;
        this.stream = (Stream) null;
      }
      get => this.handle;
    }

    public override object GetValue()
    {
      if (this.stream == null)
      {
        if (!this.IsReadOnly)
        {
          this.handle = GamerServicesDispatcher.Gsp.CreateStream((byte[]) null, 10240);
          this.IsChanged = true;
        }
        this.stream = GamerServicesDispatcher.Gsp.GetStream(this.handle);
      }
      return (object) this.stream;
    }

    public override void SetValue(object value) => throw new InvalidOperationException();
  }
}
