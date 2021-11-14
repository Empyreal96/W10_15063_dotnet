// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.ModelBoneCollection
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class ModelBoneCollection : ReadOnlyCollection<ModelBone>
  {
    private ModelBone[] wrappedArray;

    internal ModelBoneCollection(ModelBone[] bones)
      : base((IList<ModelBone>) bones)
    {
      this.wrappedArray = bones;
    }

    public ModelBone this[string boneName]
    {
      get
      {
        ModelBone modelBone;
        if (!this.TryGetValue(boneName, out modelBone))
          throw new KeyNotFoundException();
        return modelBone;
      }
    }

    public bool TryGetValue(string boneName, out ModelBone value)
    {
      if (string.IsNullOrEmpty(boneName))
        throw new ArgumentNullException(nameof (boneName));
      int count = this.Items.Count;
      for (int index = 0; index < count; ++index)
      {
        ModelBone modelBone = this.Items[index];
        if (string.Compare(modelBone.Name, boneName, StringComparison.Ordinal) == 0)
        {
          value = modelBone;
          return true;
        }
      }
      value = (ModelBone) null;
      return false;
    }

    public ModelBoneCollection.Enumerator GetEnumerator() => new ModelBoneCollection.Enumerator(this.wrappedArray);

    public struct Enumerator : IEnumerator<ModelBone>, IEnumerator, IDisposable
    {
      private ModelBone[] wrappedArray;
      private int position;

      internal Enumerator(ModelBone[] wrappedArray)
      {
        this.wrappedArray = wrappedArray;
        this.position = -1;
      }

      public ModelBone Current => this.wrappedArray[this.position];

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
