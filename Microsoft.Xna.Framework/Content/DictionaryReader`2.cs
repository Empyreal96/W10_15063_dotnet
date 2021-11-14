// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.DictionaryReader`2
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System.Collections.Generic;

namespace Microsoft.Xna.Framework.Content
{
  internal class DictionaryReader<Key, Value> : ContentTypeReader<Dictionary<Key, Value>>
  {
    private ContentTypeReader keyReader;
    private ContentTypeReader valueReader;

    protected internal override void Initialize(ContentTypeReaderManager manager)
    {
      this.keyReader = manager.GetTypeReader(typeof (Key));
      this.valueReader = manager.GetTypeReader(typeof (Value));
    }

    protected internal override Dictionary<Key, Value> Read(
      ContentReader input,
      Dictionary<Key, Value> existingInstance)
    {
      int capacity = input.ReadInt32();
      Dictionary<Key, Value> dictionary = existingInstance ?? new Dictionary<Key, Value>(capacity);
      while (capacity-- > 0)
      {
        Key key = input.ReadObject<Key>(this.keyReader);
        Value obj = input.ReadObject<Value>(this.valueReader);
        dictionary.Add(key, obj);
      }
      return dictionary;
    }

    public override bool CanDeserializeIntoExistingObject => true;
  }
}
