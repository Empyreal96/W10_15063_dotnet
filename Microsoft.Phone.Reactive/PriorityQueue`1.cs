// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.PriorityQueue`1
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;

namespace Microsoft.Phone.Reactive
{
  internal class PriorityQueue<T> where T : IComparable<T>
  {
    private const int defaultSize = 1024;
    private T[] items;
    private int size;

    public PriorityQueue()
    {
      this.items = new T[1024];
      this.size = 0;
    }

    public int Count => this.size;

    private bool IsHigherPriority(int left, int right) => this.items[left].CompareTo(this.items[right]) < 0;

    private void Percolate(int index)
    {
      if (index >= this.size || index < 0)
        return;
      int index1 = (index - 1) / 2;
      if (index1 < 0 || index1 == index || !this.IsHigherPriority(index, index1))
        return;
      T obj = this.items[index];
      this.items[index] = this.items[index1];
      this.items[index1] = obj;
      this.Percolate(index1);
    }

    private void Heapify() => this.Heapify(0);

    private void Heapify(int index)
    {
      if (index >= this.size || index < 0)
        return;
      int left1 = 2 * index + 1;
      int left2 = 2 * index + 2;
      int index1 = index;
      if (left1 < this.size && this.IsHigherPriority(left1, index1))
        index1 = left1;
      if (left2 < this.size && this.IsHigherPriority(left2, index1))
        index1 = left2;
      if (index1 == index)
        return;
      T obj = this.items[index];
      this.items[index] = this.items[index1];
      this.items[index1] = obj;
      this.Heapify(index1);
    }

    public T Peek()
    {
      if (this.size == 0)
        throw new InvalidOperationException("Heap is empty.");
      return this.items[0];
    }

    public T Dequeue()
    {
      T obj = this.Peek();
      this.items[0] = this.items[--this.size];
      this.Heapify();
      return obj;
    }

    public void Enqueue(T item)
    {
      if (this.size >= this.items.Length)
      {
        T[] items1 = this.items;
        this.items = new T[this.items.Length * 2];
        T[] items2 = this.items;
        items1.CopyTo((Array) items2, 0);
      }
      int index = this.size++;
      this.items[index] = item;
      this.Percolate(index);
    }
  }
}
