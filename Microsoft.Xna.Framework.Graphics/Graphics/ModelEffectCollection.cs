// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.ModelEffectCollection
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class ModelEffectCollection : ReadOnlyCollection<Effect>
  {
    private List<Effect> wrappedList;

    internal ModelEffectCollection()
      : base((IList<Effect>) new List<Effect>())
    {
      this.wrappedList = (List<Effect>) this.Items;
    }

    internal void Add(Effect effect) => this.Items.Add(effect);

    internal void Remove(Effect effect) => this.Items.Remove(effect);

    public ModelEffectCollection.Enumerator GetEnumerator() => new ModelEffectCollection.Enumerator(this.wrappedList);

    public struct Enumerator : IEnumerator<Effect>, IEnumerator, IDisposable
    {
      private List<Effect>.Enumerator internalEnumerator;

      internal Enumerator(List<Effect> wrappedList) => this.internalEnumerator = wrappedList.GetEnumerator();

      public Effect Current => this.internalEnumerator.Current;

      public bool MoveNext() => this.internalEnumerator.MoveNext();

      void IEnumerator.Reset()
      {
        IEnumerator internalEnumerator = (IEnumerator) this.internalEnumerator;
        internalEnumerator.Reset();
        this.internalEnumerator = (List<Effect>.Enumerator) internalEnumerator;
      }

      public void Dispose() => this.internalEnumerator.Dispose();

      object IEnumerator.Current => (object) this.Current;
    }
  }
}
