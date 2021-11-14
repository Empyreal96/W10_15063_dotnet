// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.ListReader`1
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System.Collections.Generic;

namespace Microsoft.Xna.Framework.Content
{
  internal class ListReader<T> : ContentTypeReader<List<T>>
  {
    private ContentTypeReader elementReader;

    protected internal override void Initialize(ContentTypeReaderManager manager) => this.elementReader = manager.GetTypeReader(typeof (T));

    protected internal override List<T> Read(ContentReader input, List<T> existingInstance)
    {
      int num = input.ReadInt32();
      List<T> objList = existingInstance ?? new List<T>();
      while (num-- > 0)
        objList.Add(input.ReadObject<T>(this.elementReader));
      return objList;
    }

    public override bool CanDeserializeIntoExistingObject => true;
  }
}
