// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.ModelMeshPartCollection
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class ModelMeshPartCollection : ReadOnlyCollection<ModelMeshPart>
  {
    private ModelMeshPart[] wrappedArray;

    internal ModelMeshPartCollection(ModelMeshPart[] parts)
      : base((IList<ModelMeshPart>) parts)
    {
      this.wrappedArray = parts;
    }

    public ModelMeshPartCollection.Enumerator GetEnumerator() => new ModelMeshPartCollection.Enumerator(this.wrappedArray);

    public struct Enumerator : IEnumerator<ModelMeshPart>, IEnumerator, IDisposable
    {
      private ModelMeshPart[] wrappedArray;
      private int position;

      internal Enumerator(ModelMeshPart[] wrappedArray)
      {
        this.wrappedArray = wrappedArray;
        this.position = -1;
      }

      public ModelMeshPart Current => this.wrappedArray[this.position];

      public bool MoveNext()
      {
        ++this.position;
        if (this.position < this.wrappedArray.Length)
          return true;
        this.position = this.wrappedArray.Length;
        return false;
      }

      void IEnumerator.Reset() => this.position = -1;

      public void Dispose()
      {
      }

      object IEnumerator.Current => (object) this.Current;
    }
  }
}
