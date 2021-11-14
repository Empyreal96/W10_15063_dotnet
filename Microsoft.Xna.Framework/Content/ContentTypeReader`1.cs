// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.ContentTypeReader`1
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

namespace Microsoft.Xna.Framework.Content
{
  public abstract class ContentTypeReader<T> : ContentTypeReader
  {
    protected ContentTypeReader()
      : base(typeof (T))
    {
    }

    protected internal override object Read(ContentReader input, object existingInstance)
    {
      if (existingInstance == null)
        existingInstance2 = default (T);
      else if (!(existingInstance is T existingInstance2))
        throw input.CreateContentLoadException(FrameworkResources.BadXnbWrongType, (object) typeof (T), (object) existingInstance.GetType());
      return (object) this.Read(input, existingInstance2);
    }

    protected internal abstract T Read(ContentReader input, T existingInstance);
  }
}
