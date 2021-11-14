// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GameComponentCollection
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using System;
using System.Collections.ObjectModel;

namespace Microsoft.Xna.Framework
{
  public sealed class GameComponentCollection : Collection<IGameComponent>
  {
    public event EventHandler<GameComponentCollectionEventArgs> ComponentAdded;

    public event EventHandler<GameComponentCollectionEventArgs> ComponentRemoved;

    protected override void InsertItem(int index, IGameComponent item)
    {
      if (this.IndexOf(item) != -1)
        throw new ArgumentException(Resources.CannotAddSameComponentMultipleTimes);
      base.InsertItem(index, item);
      if (item == null)
        return;
      this.OnComponentAdded(new GameComponentCollectionEventArgs(item));
    }

    protected override void RemoveItem(int index)
    {
      IGameComponent gameComponent = this[index];
      base.RemoveItem(index);
      if (gameComponent == null)
        return;
      this.OnComponentRemoved(new GameComponentCollectionEventArgs(gameComponent));
    }

    protected override void SetItem(int index, IGameComponent item) => throw new NotSupportedException(Resources.CannotSetItemsIntoGameComponentCollection);

    protected override void ClearItems()
    {
      for (int index = 0; index < this.Count; ++index)
        this.OnComponentRemoved(new GameComponentCollectionEventArgs(this[index]));
      base.ClearItems();
    }

    private void OnComponentAdded(GameComponentCollectionEventArgs eventArgs)
    {
      if (this.ComponentAdded == null)
        return;
      this.ComponentAdded((object) this, eventArgs);
    }

    private void OnComponentRemoved(GameComponentCollectionEventArgs eventArgs)
    {
      if (this.ComponentRemoved == null)
        return;
      this.ComponentRemoved((object) this, eventArgs);
    }
  }
}
