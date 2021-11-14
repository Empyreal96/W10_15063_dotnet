// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.ArrayReader`1
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

namespace Microsoft.Xna.Framework.Content
{
  internal class ArrayReader<T> : ContentTypeReader<T[]>
  {
    private ContentTypeReader elementReader;

    protected internal override void Initialize(ContentTypeReaderManager manager) => this.elementReader = manager.GetTypeReader(typeof (T));

    protected internal override T[] Read(ContentReader input, T[] existingInstance)
    {
      int length = input.ReadInt32();
      T[] objArray = new T[length];
      for (int index = 0; index < length; ++index)
        objArray[index] = input.ReadObject<T>(this.elementReader);
      return objArray;
    }
  }
}
