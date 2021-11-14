// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.ModelMeshCollection
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class ModelMeshCollection : ReadOnlyCollection<ModelMesh>
  {
    private ModelMesh[] wrappedArray;

    internal ModelMeshCollection(ModelMesh[] meshes)
      : base((IList<ModelMesh>) meshes)
    {
      this.wrappedArray = meshes;
    }

    public ModelMesh this[string meshName]
    {
      get
      {
        ModelMesh modelMesh;
        if (!this.TryGetValue(meshName, out modelMesh))
          throw new KeyNotFoundException();
        return modelMesh;
      }
    }

    public bool TryGetValue(string meshName, out ModelMesh value)
    {
      if (string.IsNullOrEmpty(meshName))
        throw new ArgumentNullException(nameof (meshName));
      int count = this.Items.Count;
      for (int index = 0; index < count; ++index)
      {
        ModelMesh modelMesh = this.Items[index];
        if (string.Compare(modelMesh.Name, meshName, StringComparison.Ordinal) == 0)
        {
          value = modelMesh;
          return true;
        }
      }
      value = (ModelMesh) null;
      return false;
    }

    public ModelMeshCollection.Enumerator GetEnumerator() => new ModelMeshCollection.Enumerator(this.wrappedArray);

    public struct Enumerator : IEnumerator<ModelMesh>, IEnumerator, IDisposable
    {
      private ModelMesh[] wrappedArray;
      private int position;

      internal Enumerator(ModelMesh[] wrappedArray)
      {
        this.wrappedArray = wrappedArray;
        this.position = -1;
      }

      public ModelMesh Current => this.wrappedArray[this.position];

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
