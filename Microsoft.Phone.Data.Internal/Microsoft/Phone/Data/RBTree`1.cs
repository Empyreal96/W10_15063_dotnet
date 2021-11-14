// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.RBTree`1
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.Phone.Data
{
  internal abstract class RBTree<K> : IEnumerable
  {
    internal const int DefaultPageSize = 32;
    internal const int NIL = 0;
    private RBTree<K>.TreePage[] _pageTable;
    private int[] _pageTableMap;
    private int _inUsePageCount;
    private int nextFreePageLine;
    public int root;
    private int _version;
    private int _inUseNodeCount;
    private int _inUseSatelliteTreeCount;
    private readonly TreeAccessMethod _accessMethod;

    protected abstract int CompareNode(K record1, K record2);

    protected abstract int CompareSateliteTreeNode(K record1, K record2);

    protected RBTree(TreeAccessMethod accessMethod)
    {
      this._accessMethod = accessMethod;
      this.InitTree();
    }

    private void InitTree()
    {
      this.root = 0;
      this._pageTable = new RBTree<K>.TreePage[32];
      this._pageTableMap = new int[(this._pageTable.Length + 32 - 1) / 32];
      this._inUsePageCount = 0;
      this.nextFreePageLine = 0;
      this.AllocPage(32);
      this._pageTable[0].Slots[0].nodeColor = RBTree<K>.NodeColor.black;
      this._pageTable[0].SlotMap[0] = 1;
      this._pageTable[0].InUseCount = 1;
      this._inUseNodeCount = 1;
      this._inUseSatelliteTreeCount = 0;
    }

    private void FreePage(RBTree<K>.TreePage page)
    {
      this.MarkPageFree(page);
      this._pageTable[page.PageId] = (RBTree<K>.TreePage) null;
      --this._inUsePageCount;
    }

    private RBTree<K>.TreePage AllocPage(int size)
    {
      int index = this.GetIndexOfPageWithFreeSlot(false);
      if (index != -1)
      {
        this._pageTable[index] = new RBTree<K>.TreePage(size);
        this.nextFreePageLine = index / 32;
      }
      else
      {
        RBTree<K>.TreePage[] treePageArray = new RBTree<K>.TreePage[this._pageTable.Length * 2];
        Array.Copy((Array) this._pageTable, 0, (Array) treePageArray, 0, this._pageTable.Length);
        int[] numArray = new int[(treePageArray.Length + 32 - 1) / 32];
        Array.Copy((Array) this._pageTableMap, 0, (Array) numArray, 0, this._pageTableMap.Length);
        this.nextFreePageLine = this._pageTableMap.Length;
        index = this._pageTable.Length;
        this._pageTable = treePageArray;
        this._pageTableMap = numArray;
        this._pageTable[index] = new RBTree<K>.TreePage(size);
      }
      this._pageTable[index].PageId = index;
      ++this._inUsePageCount;
      return this._pageTable[index];
    }

    private void MarkPageFull(RBTree<K>.TreePage page) => this._pageTableMap[page.PageId / 32] |= 1 << page.PageId % 32;

    private void MarkPageFree(RBTree<K>.TreePage page) => this._pageTableMap[page.PageId / 32] &= ~(1 << page.PageId % 32);

    private static int GetIntValueFromBitMap(uint bitMap)
    {
      int num = 0;
      if (((int) bitMap & -65536) != 0)
      {
        num += 16;
        bitMap >>= 16;
      }
      if (((int) bitMap & 65280) != 0)
      {
        num += 8;
        bitMap >>= 8;
      }
      if (((int) bitMap & 240) != 0)
      {
        num += 4;
        bitMap >>= 4;
      }
      if (((int) bitMap & 12) != 0)
      {
        num += 2;
        bitMap >>= 2;
      }
      if (((int) bitMap & 2) != 0)
        ++num;
      return num;
    }

    private void FreeNode(int nodeId)
    {
      RBTree<K>.TreePage page = this._pageTable[nodeId >> 16];
      int index = nodeId & (int) ushort.MaxValue;
      page.Slots[index] = new RBTree<K>.Node();
      page.SlotMap[index / 32] &= ~(1 << index % 32);
      --page.InUseCount;
      --this._inUseNodeCount;
      if (page.InUseCount == 0)
      {
        this.FreePage(page);
      }
      else
      {
        if (page.InUseCount != page.Slots.Length - 1)
          return;
        this.MarkPageFree(page);
      }
    }

    private int GetIndexOfPageWithFreeSlot(bool allocatedPage)
    {
      int nextFreePageLine = this.nextFreePageLine;
      int num = -1;
      uint bitMap;
      for (; nextFreePageLine < this._pageTableMap.Length; ++nextFreePageLine)
      {
        if ((uint) this._pageTableMap[nextFreePageLine] < uint.MaxValue)
        {
          for (uint pageTable = (uint) this._pageTableMap[nextFreePageLine]; ((int) pageTable ^ -1) != 0; pageTable |= bitMap)
          {
            bitMap = (uint) (~(int) pageTable & (int) pageTable + 1);
            if (((long) this._pageTableMap[nextFreePageLine] & (long) bitMap) != 0L)
              throw ExceptionBuilder.InternalRBTreeError(RBTreeError.PagePositionInSlotInUse);
            int index = nextFreePageLine * 32 + RBTree<K>.GetIntValueFromBitMap(bitMap);
            if (allocatedPage)
            {
              if (this._pageTable[index] != null)
                return index;
            }
            else if (this._pageTable[index] == null)
              return index;
            num = -1;
          }
        }
      }
      if (this.nextFreePageLine != 0)
      {
        this.nextFreePageLine = 0;
        num = this.GetIndexOfPageWithFreeSlot(allocatedPage);
      }
      return num;
    }

    public int Count
    {
      get
      {
        Debug.Assert(this._inUseNodeCount - 1 == this.SubTreeSize(this.root), "count mismatch");
        return this._inUseNodeCount - 1;
      }
    }

    public bool HasDuplicates => (uint) this._inUseSatelliteTreeCount > 0U;

    private int GetNewNode(K key)
    {
      int pageWithFreeSlot = this.GetIndexOfPageWithFreeSlot(true);
      RBTree<K>.TreePage treePage = pageWithFreeSlot == -1 ? (this._inUsePageCount >= 4 ? (this._inUsePageCount >= 32 ? (this._inUsePageCount >= 128 ? (this._inUsePageCount >= 4096 ? (this._inUsePageCount >= 32768 ? this.AllocPage(65536) : this.AllocPage(8192)) : this.AllocPage(4096)) : this.AllocPage(1024)) : this.AllocPage(256)) : this.AllocPage(32)) : this._pageTable[pageWithFreeSlot];
      int index = treePage.AllocSlot(this);
      if (index == -1)
        throw ExceptionBuilder.InternalRBTreeError(RBTreeError.NoFreeSlots);
      treePage.Slots[index].selfId = treePage.PageId << 16 | index;
      Debug.Assert(treePage.Slots[index].leftId == 0, "node not cleared");
      Debug.Assert(treePage.Slots[index].rightId == 0, "node not cleared");
      Debug.Assert(treePage.Slots[index].parentId == 0, "node not cleared");
      Debug.Assert(treePage.Slots[index].nextId == 0, "node not cleared");
      treePage.Slots[index].subTreeSize = 1;
      treePage.Slots[index].keyOfNode = key;
      Debug.Assert(treePage.Slots[index].nodeColor == RBTree<K>.NodeColor.red, "node not cleared");
      return treePage.Slots[index].selfId;
    }

    private int Successor(int x_id)
    {
      if (this.Right(x_id) != 0)
        return this.Minimum(this.Right(x_id));
      int nodeId;
      for (nodeId = this.Parent(x_id); nodeId != 0 && x_id == this.Right(nodeId); nodeId = this.Parent(nodeId))
        x_id = nodeId;
      return nodeId;
    }

    private bool Successor(ref int nodeId, ref int mainTreeNodeId)
    {
      if (nodeId == 0)
      {
        nodeId = this.Minimum(mainTreeNodeId);
        mainTreeNodeId = 0;
      }
      else
      {
        nodeId = this.Successor(nodeId);
        if (nodeId == 0 && mainTreeNodeId != 0)
        {
          nodeId = this.Successor(mainTreeNodeId);
          mainTreeNodeId = 0;
        }
      }
      if (nodeId == 0)
        return false;
      if (this.Next(nodeId) != 0)
      {
        if (mainTreeNodeId != 0)
          throw ExceptionBuilder.InternalRBTreeError(RBTreeError.NestedSatelliteTreeEnumerator);
        mainTreeNodeId = nodeId;
        nodeId = this.Minimum(this.Next(nodeId));
      }
      return true;
    }

    private int Minimum(int x_id)
    {
      while (this.Left(x_id) != 0)
        x_id = this.Left(x_id);
      return x_id;
    }

    private int LeftRotate(int root_id, int x_id, int mainTreeNode)
    {
      int num = this.Right(x_id);
      this.SetRight(x_id, this.Left(num));
      if (this.Left(num) != 0)
        this.SetParent(this.Left(num), x_id);
      this.SetParent(num, this.Parent(x_id));
      if (this.Parent(x_id) == 0)
      {
        if (root_id == 0)
        {
          this.root = num;
        }
        else
        {
          this.SetNext(mainTreeNode, num);
          this.SetKey(mainTreeNode, this.Key(num));
          root_id = num;
        }
      }
      else if (x_id == this.Left(this.Parent(x_id)))
        this.SetLeft(this.Parent(x_id), num);
      else
        this.SetRight(this.Parent(x_id), num);
      this.SetLeft(num, x_id);
      this.SetParent(x_id, num);
      if (x_id != 0)
        this.SetSubTreeSize(x_id, this.SubTreeSize(this.Left(x_id)) + this.SubTreeSize(this.Right(x_id)) + (this.Next(x_id) == 0 ? 1 : this.SubTreeSize(this.Next(x_id))));
      if (num != 0)
        this.SetSubTreeSize(num, this.SubTreeSize(this.Left(num)) + this.SubTreeSize(this.Right(num)) + (this.Next(num) == 0 ? 1 : this.SubTreeSize(this.Next(num))));
      return root_id;
    }

    private int RightRotate(int root_id, int x_id, int mainTreeNode)
    {
      int num = this.Left(x_id);
      this.SetLeft(x_id, this.Right(num));
      if (this.Right(num) != 0)
        this.SetParent(this.Right(num), x_id);
      this.SetParent(num, this.Parent(x_id));
      if (this.Parent(x_id) == 0)
      {
        if (root_id == 0)
        {
          this.root = num;
        }
        else
        {
          this.SetNext(mainTreeNode, num);
          this.SetKey(mainTreeNode, this.Key(num));
          root_id = num;
        }
      }
      else if (x_id == this.Left(this.Parent(x_id)))
        this.SetLeft(this.Parent(x_id), num);
      else
        this.SetRight(this.Parent(x_id), num);
      this.SetRight(num, x_id);
      this.SetParent(x_id, num);
      if (x_id != 0)
        this.SetSubTreeSize(x_id, this.SubTreeSize(this.Left(x_id)) + this.SubTreeSize(this.Right(x_id)) + (this.Next(x_id) == 0 ? 1 : this.SubTreeSize(this.Next(x_id))));
      if (num != 0)
        this.SetSubTreeSize(num, this.SubTreeSize(this.Left(num)) + this.SubTreeSize(this.Right(num)) + (this.Next(num) == 0 ? 1 : this.SubTreeSize(this.Next(num))));
      return root_id;
    }

    private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append)
    {
      ++this._version;
      int num1 = 0;
      int num2 = root_id == 0 ? this.root : root_id;
      if (this._accessMethod == TreeAccessMethod.KEY_SEARCH_AND_INDEX && !append)
      {
        Debug.Assert(-1 == position, "KEY_SEARCH_AND_INDEX with bad position");
        while (num2 != 0)
        {
          this.IncreaseSize(num2);
          num1 = num2;
          int num3 = root_id == 0 ? this.CompareNode(this.Key(x_id), this.Key(num2)) : this.CompareSateliteTreeNode(this.Key(x_id), this.Key(num2));
          if (num3 < 0)
            num2 = this.Left(num2);
          else if (num3 > 0)
          {
            num2 = this.Right(num2);
          }
          else
          {
            if (root_id != 0)
              throw ExceptionBuilder.InternalRBTreeError(RBTreeError.InvalidStateinInsert);
            if (this.Next(num2) != 0)
            {
              root_id = this.RBInsert(this.Next(num2), x_id, num2, -1, false);
              this.SetKey(num2, this.Key(this.Next(num2)));
            }
            else
            {
              int newNode = this.GetNewNode(this.Key(num2));
              ++this._inUseSatelliteTreeCount;
              this.SetNext(newNode, num2);
              this.SetColor(newNode, this.color(num2));
              this.SetParent(newNode, this.Parent(num2));
              this.SetLeft(newNode, this.Left(num2));
              this.SetRight(newNode, this.Right(num2));
              if (this.Left(this.Parent(num2)) == num2)
                this.SetLeft(this.Parent(num2), newNode);
              else if (this.Right(this.Parent(num2)) == num2)
                this.SetRight(this.Parent(num2), newNode);
              if (this.Left(num2) != 0)
                this.SetParent(this.Left(num2), newNode);
              if (this.Right(num2) != 0)
                this.SetParent(this.Right(num2), newNode);
              if (this.root == num2)
                this.root = newNode;
              this.SetColor(num2, RBTree<K>.NodeColor.black);
              this.SetParent(num2, 0);
              this.SetLeft(num2, 0);
              this.SetRight(num2, 0);
              int size = this.SubTreeSize(num2);
              this.SetSubTreeSize(num2, 1);
              root_id = this.RBInsert(num2, x_id, newNode, -1, false);
              this.SetSubTreeSize(newNode, size);
            }
            return root_id;
          }
        }
      }
      else
      {
        if (!(this._accessMethod == TreeAccessMethod.INDEX_ONLY | append))
          throw ExceptionBuilder.InternalRBTreeError(RBTreeError.UnsupportedAccessMethod1);
        if (position == -1)
          position = this.SubTreeSize(this.root);
        while (num2 != 0)
        {
          this.IncreaseSize(num2);
          num1 = num2;
          int num3 = position - this.SubTreeSize(this.Left(num1));
          if (num3 <= 0)
          {
            num2 = this.Left(num2);
          }
          else
          {
            num2 = this.Right(num2);
            if (num2 != 0)
              position = num3 - 1;
          }
        }
      }
      this.SetParent(x_id, num1);
      if (num1 == 0)
      {
        if (root_id == 0)
        {
          this.root = x_id;
        }
        else
        {
          this.SetNext(mainTreeNodeID, x_id);
          this.SetKey(mainTreeNodeID, this.Key(x_id));
          root_id = x_id;
        }
      }
      else
      {
        int num3;
        if (this._accessMethod == TreeAccessMethod.KEY_SEARCH_AND_INDEX)
        {
          num3 = root_id == 0 ? this.CompareNode(this.Key(x_id), this.Key(num1)) : this.CompareSateliteTreeNode(this.Key(x_id), this.Key(num1));
        }
        else
        {
          if (this._accessMethod != TreeAccessMethod.INDEX_ONLY)
            throw ExceptionBuilder.InternalRBTreeError(RBTreeError.UnsupportedAccessMethod2);
          num3 = position <= 0 ? -1 : 1;
        }
        if (num3 < 0)
          this.SetLeft(num1, x_id);
        else
          this.SetRight(num1, x_id);
      }
      this.SetLeft(x_id, 0);
      this.SetRight(x_id, 0);
      this.SetColor(x_id, RBTree<K>.NodeColor.red);
      while (this.color(this.Parent(x_id)) == RBTree<K>.NodeColor.red)
      {
        if (this.Parent(x_id) == this.Left(this.Parent(this.Parent(x_id))))
        {
          int nodeId = this.Right(this.Parent(this.Parent(x_id)));
          if (this.color(nodeId) == RBTree<K>.NodeColor.red)
          {
            this.SetColor(this.Parent(x_id), RBTree<K>.NodeColor.black);
            this.SetColor(nodeId, RBTree<K>.NodeColor.black);
            this.SetColor(this.Parent(this.Parent(x_id)), RBTree<K>.NodeColor.red);
            x_id = this.Parent(this.Parent(x_id));
          }
          else
          {
            if (x_id == this.Right(this.Parent(x_id)))
            {
              x_id = this.Parent(x_id);
              root_id = this.LeftRotate(root_id, x_id, mainTreeNodeID);
            }
            this.SetColor(this.Parent(x_id), RBTree<K>.NodeColor.black);
            this.SetColor(this.Parent(this.Parent(x_id)), RBTree<K>.NodeColor.red);
            root_id = this.RightRotate(root_id, this.Parent(this.Parent(x_id)), mainTreeNodeID);
          }
        }
        else
        {
          int nodeId = this.Left(this.Parent(this.Parent(x_id)));
          if (this.color(nodeId) == RBTree<K>.NodeColor.red)
          {
            this.SetColor(this.Parent(x_id), RBTree<K>.NodeColor.black);
            this.SetColor(nodeId, RBTree<K>.NodeColor.black);
            this.SetColor(this.Parent(this.Parent(x_id)), RBTree<K>.NodeColor.red);
            x_id = this.Parent(this.Parent(x_id));
          }
          else
          {
            if (x_id == this.Left(this.Parent(x_id)))
            {
              x_id = this.Parent(x_id);
              root_id = this.RightRotate(root_id, x_id, mainTreeNodeID);
            }
            this.SetColor(this.Parent(x_id), RBTree<K>.NodeColor.black);
            this.SetColor(this.Parent(this.Parent(x_id)), RBTree<K>.NodeColor.red);
            root_id = this.LeftRotate(root_id, this.Parent(this.Parent(x_id)), mainTreeNodeID);
          }
        }
      }
      if (root_id == 0)
        this.SetColor(this.root, RBTree<K>.NodeColor.black);
      else
        this.SetColor(root_id, RBTree<K>.NodeColor.black);
      return root_id;
    }

    public void UpdateNodeKey(K currentKey, K newKey)
    {
      RBTree<K>.NodePath nodeByKey = this.GetNodeByKey(currentKey);
      if (this.Parent(nodeByKey.NodeID) == 0 && nodeByKey.NodeID != this.root)
        this.SetKey(nodeByKey.MainTreeNodeID, newKey);
      this.SetKey(nodeByKey.NodeID, newKey);
    }

    public K DeleteByIndex(int i)
    {
      RBTree<K>.NodePath nodeByIndex = this.GetNodeByIndex(i);
      K k = this.Key(nodeByIndex.NodeID);
      this.RBDeleteX(0, nodeByIndex.NodeID, nodeByIndex.MainTreeNodeID);
      return k;
    }

    public int RBDelete(int z_id)
    {
      Debug.Assert(this._accessMethod == TreeAccessMethod.INDEX_ONLY, "not expecting anything else");
      return this.RBDeleteX(0, z_id, 0);
    }

    private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID)
    {
      if (this.Next(z_id) != 0)
        return this.RBDeleteX(this.Next(z_id), this.Next(z_id), z_id);
      bool flag = false;
      int nodeId1 = this._accessMethod == TreeAccessMethod.KEY_SEARCH_AND_INDEX ? mainTreeNodeID : z_id;
      if (this.Next(nodeId1) != 0)
        root_id = this.Next(nodeId1);
      if (this.SubTreeSize(this.Next(nodeId1)) == 2)
        flag = true;
      else if (this.SubTreeSize(this.Next(nodeId1)) == 1)
        throw ExceptionBuilder.InternalRBTreeError(RBTreeError.InvalidNextSizeInDelete);
      int num1 = this.Left(z_id) == 0 || this.Right(z_id) == 0 ? z_id : this.Successor(z_id);
      int num2 = this.Left(num1) == 0 ? this.Right(num1) : this.Left(num1);
      int num3 = this.Parent(num1);
      if (num2 != 0)
        this.SetParent(num2, num3);
      if (num3 == 0)
      {
        if (root_id == 0)
          this.root = num2;
        else
          root_id = num2;
      }
      else if (num1 == this.Left(num3))
        this.SetLeft(num3, num2);
      else
        this.SetRight(num3, num2);
      if (num1 != z_id)
      {
        this.SetKey(z_id, this.Key(num1));
        this.SetNext(z_id, this.Next(num1));
      }
      if (this.Next(nodeId1) != 0)
      {
        if (root_id == 0 && z_id != nodeId1)
          throw ExceptionBuilder.InternalRBTreeError(RBTreeError.InvalidStateinDelete);
        if (root_id != 0)
        {
          this.SetNext(nodeId1, root_id);
          this.SetKey(nodeId1, this.Key(root_id));
        }
      }
      for (int nodeId2 = num3; nodeId2 != 0; nodeId2 = this.Parent(nodeId2))
        this.RecomputeSize(nodeId2);
      if (root_id != 0)
      {
        for (int nodeId2 = nodeId1; nodeId2 != 0; nodeId2 = this.Parent(nodeId2))
          this.DecreaseSize(nodeId2);
      }
      if (this.color(num1) == RBTree<K>.NodeColor.black)
        root_id = this.RBDeleteFixup(root_id, num2, num3, mainTreeNodeID);
      if (flag)
      {
        if (nodeId1 == 0 || this.SubTreeSize(this.Next(nodeId1)) != 1)
          throw ExceptionBuilder.InternalRBTreeError(RBTreeError.InvalidNodeSizeinDelete);
        --this._inUseSatelliteTreeCount;
        int num4 = this.Next(nodeId1);
        this.SetLeft(num4, this.Left(nodeId1));
        this.SetRight(num4, this.Right(nodeId1));
        this.SetSubTreeSize(num4, this.SubTreeSize(nodeId1));
        this.SetColor(num4, this.color(nodeId1));
        if (this.Parent(nodeId1) != 0)
        {
          this.SetParent(num4, this.Parent(nodeId1));
          if (this.Left(this.Parent(nodeId1)) == nodeId1)
            this.SetLeft(this.Parent(nodeId1), num4);
          else
            this.SetRight(this.Parent(nodeId1), num4);
        }
        if (this.Left(nodeId1) != 0)
          this.SetParent(this.Left(nodeId1), num4);
        if (this.Right(nodeId1) != 0)
          this.SetParent(this.Right(nodeId1), num4);
        if (this.root == nodeId1)
          this.root = num4;
        this.FreeNode(nodeId1);
        nodeId1 = 0;
      }
      else if (this.Next(nodeId1) != 0)
      {
        if (root_id == 0 && z_id != nodeId1)
          throw ExceptionBuilder.InternalRBTreeError(RBTreeError.InvalidStateinEndDelete);
        if (root_id != 0)
        {
          this.SetNext(nodeId1, root_id);
          this.SetKey(nodeId1, this.Key(root_id));
        }
      }
      if (num1 != z_id)
      {
        this.SetLeft(num1, this.Left(z_id));
        this.SetRight(num1, this.Right(z_id));
        this.SetColor(num1, this.color(z_id));
        this.SetSubTreeSize(num1, this.SubTreeSize(z_id));
        if (this.Parent(z_id) != 0)
        {
          this.SetParent(num1, this.Parent(z_id));
          if (this.Left(this.Parent(z_id)) == z_id)
            this.SetLeft(this.Parent(z_id), num1);
          else
            this.SetRight(this.Parent(z_id), num1);
        }
        else
          this.SetParent(num1, 0);
        if (this.Left(z_id) != 0)
          this.SetParent(this.Left(z_id), num1);
        if (this.Right(z_id) != 0)
          this.SetParent(this.Right(z_id), num1);
        if (this.root == z_id)
          this.root = num1;
        else if (root_id == z_id)
          root_id = num1;
        if (nodeId1 != 0 && this.Next(nodeId1) == z_id)
          this.SetNext(nodeId1, num1);
      }
      this.FreeNode(z_id);
      ++this._version;
      return z_id;
    }

    private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID)
    {
      if (x_id == 0 && px_id == 0)
        return 0;
      while ((root_id == 0 ? this.root : root_id) != x_id && this.color(x_id) == RBTree<K>.NodeColor.black)
      {
        if (x_id != 0 && x_id == this.Left(this.Parent(x_id)) || x_id == 0 && this.Left(px_id) == 0)
        {
          int num = x_id == 0 ? this.Right(px_id) : this.Right(this.Parent(x_id));
          if (num == 0)
            throw ExceptionBuilder.InternalRBTreeError(RBTreeError.RBDeleteFixup);
          if (this.color(num) == RBTree<K>.NodeColor.red)
          {
            this.SetColor(num, RBTree<K>.NodeColor.black);
            this.SetColor(px_id, RBTree<K>.NodeColor.red);
            root_id = this.LeftRotate(root_id, px_id, mainTreeNodeID);
            num = x_id == 0 ? this.Right(px_id) : this.Right(this.Parent(x_id));
          }
          if (this.color(this.Left(num)) == RBTree<K>.NodeColor.black && this.color(this.Right(num)) == RBTree<K>.NodeColor.black)
          {
            this.SetColor(num, RBTree<K>.NodeColor.red);
            x_id = px_id;
            px_id = this.Parent(px_id);
          }
          else
          {
            if (this.color(this.Right(num)) == RBTree<K>.NodeColor.black)
            {
              this.SetColor(this.Left(num), RBTree<K>.NodeColor.black);
              this.SetColor(num, RBTree<K>.NodeColor.red);
              root_id = this.RightRotate(root_id, num, mainTreeNodeID);
              num = x_id == 0 ? this.Right(px_id) : this.Right(this.Parent(x_id));
            }
            this.SetColor(num, this.color(px_id));
            this.SetColor(px_id, RBTree<K>.NodeColor.black);
            this.SetColor(this.Right(num), RBTree<K>.NodeColor.black);
            root_id = this.LeftRotate(root_id, px_id, mainTreeNodeID);
            x_id = root_id == 0 ? this.root : root_id;
            px_id = this.Parent(x_id);
          }
        }
        else
        {
          int num = this.Left(px_id);
          if (this.color(num) == RBTree<K>.NodeColor.red)
          {
            this.SetColor(num, RBTree<K>.NodeColor.black);
            if (x_id != 0)
            {
              this.SetColor(px_id, RBTree<K>.NodeColor.red);
              root_id = this.RightRotate(root_id, px_id, mainTreeNodeID);
              num = x_id == 0 ? this.Left(px_id) : this.Left(this.Parent(x_id));
            }
            else
            {
              this.SetColor(px_id, RBTree<K>.NodeColor.red);
              root_id = this.RightRotate(root_id, px_id, mainTreeNodeID);
              num = x_id == 0 ? this.Left(px_id) : this.Left(this.Parent(x_id));
              if (num == 0)
                throw ExceptionBuilder.InternalRBTreeError(RBTreeError.CannotRotateInvalidsuccessorNodeinDelete);
            }
          }
          if (this.color(this.Right(num)) == RBTree<K>.NodeColor.black && this.color(this.Left(num)) == RBTree<K>.NodeColor.black)
          {
            this.SetColor(num, RBTree<K>.NodeColor.red);
            x_id = px_id;
            px_id = this.Parent(px_id);
          }
          else
          {
            if (this.color(this.Left(num)) == RBTree<K>.NodeColor.black)
            {
              this.SetColor(this.Right(num), RBTree<K>.NodeColor.black);
              this.SetColor(num, RBTree<K>.NodeColor.red);
              root_id = this.LeftRotate(root_id, num, mainTreeNodeID);
              num = x_id == 0 ? this.Left(px_id) : this.Left(this.Parent(x_id));
            }
            if (x_id != 0)
            {
              this.SetColor(num, this.color(px_id));
              this.SetColor(px_id, RBTree<K>.NodeColor.black);
              this.SetColor(this.Left(num), RBTree<K>.NodeColor.black);
              root_id = this.RightRotate(root_id, px_id, mainTreeNodeID);
              x_id = root_id == 0 ? this.root : root_id;
              px_id = this.Parent(x_id);
            }
            else
            {
              this.SetColor(num, this.color(px_id));
              this.SetColor(px_id, RBTree<K>.NodeColor.black);
              this.SetColor(this.Left(num), RBTree<K>.NodeColor.black);
              root_id = this.RightRotate(root_id, px_id, mainTreeNodeID);
              x_id = root_id == 0 ? this.root : root_id;
              px_id = this.Parent(x_id);
            }
          }
        }
      }
      this.SetColor(x_id, RBTree<K>.NodeColor.black);
      return root_id;
    }

    private int SearchSubTree(int root_id, K key)
    {
      if (root_id != 0 && this._accessMethod != TreeAccessMethod.KEY_SEARCH_AND_INDEX)
        throw ExceptionBuilder.InternalRBTreeError(RBTreeError.UnsupportedAccessMethodInNonNillRootSubtree);
      int nodeId;
      int num;
      for (nodeId = root_id == 0 ? this.root : root_id; nodeId != 0; nodeId = num >= 0 ? this.Right(nodeId) : this.Left(nodeId))
      {
        num = root_id == 0 ? this.CompareNode(key, this.Key(nodeId)) : this.CompareSateliteTreeNode(key, this.Key(nodeId));
        if (num == 0)
          break;
      }
      return nodeId;
    }

    public int Search(K key)
    {
      int nodeId;
      int num;
      for (nodeId = this.root; nodeId != 0; nodeId = num >= 0 ? this.Right(nodeId) : this.Left(nodeId))
      {
        num = this.CompareNode(key, this.Key(nodeId));
        if (num == 0)
          break;
      }
      return nodeId;
    }

    public K this[int index] => this.Key(this.GetNodeByIndex(index).NodeID);

    private RBTree<K>.NodePath GetNodeByKey(K key)
    {
      int num = this.SearchSubTree(0, key);
      if (this.Next(num) != 0)
        return new RBTree<K>.NodePath(this.SearchSubTree(this.Next(num), key), num);
      if (!this.Key(num).Equals((object) key))
        num = 0;
      return new RBTree<K>.NodePath(num, 0);
    }

    public int GetIndexByKey(K key)
    {
      int num = -1;
      RBTree<K>.NodePath nodeByKey = this.GetNodeByKey(key);
      if (nodeByKey.NodeID != 0)
        num = this.GetIndexByNodePath(nodeByKey);
      return num;
    }

    public int GetIndexByNode(int node)
    {
      Debug.Assert((uint) node > 0U, "GetIndexByNode(NIL)");
      if (this._inUseSatelliteTreeCount == 0)
        return this.ComputeIndexByNode(node);
      if (this.Next(node) != 0)
        return this.ComputeIndexWithSatelliteByNode(node);
      int nodeId = this.SearchSubTree(0, this.Key(node));
      return nodeId == node ? this.ComputeIndexWithSatelliteByNode(node) : this.ComputeIndexWithSatelliteByNode(nodeId) + this.ComputeIndexByNode(node);
    }

    private int GetIndexByNodePath(RBTree<K>.NodePath path)
    {
      if (this._inUseSatelliteTreeCount == 0)
        return this.ComputeIndexByNode(path.NodeID);
      return path.MainTreeNodeID == 0 ? this.ComputeIndexWithSatelliteByNode(path.NodeID) : this.ComputeIndexWithSatelliteByNode(path.MainTreeNodeID) + this.ComputeIndexByNode(path.NodeID);
    }

    private int ComputeIndexByNode(int nodeId)
    {
      int num = this.SubTreeSize(this.Left(nodeId));
      int nodeId1;
      for (; nodeId != 0; nodeId = nodeId1)
      {
        nodeId1 = this.Parent(nodeId);
        if (nodeId == this.Right(nodeId1))
          num += this.SubTreeSize(this.Left(nodeId1)) + 1;
      }
      return num;
    }

    private int ComputeIndexWithSatelliteByNode(int nodeId)
    {
      int num = this.SubTreeSize(this.Left(nodeId));
      int nodeId1;
      for (; nodeId != 0; nodeId = nodeId1)
      {
        nodeId1 = this.Parent(nodeId);
        if (nodeId == this.Right(nodeId1))
          num += this.SubTreeSize(this.Left(nodeId1)) + (this.Next(nodeId1) == 0 ? 1 : this.SubTreeSize(this.Next(nodeId1)));
      }
      return num;
    }

    private RBTree<K>.NodePath GetNodeByIndex(int userIndex)
    {
      int nodeByIndex;
      int satelliteRootId;
      if (this._inUseSatelliteTreeCount == 0)
      {
        nodeByIndex = this.ComputeNodeByIndex(this.root, userIndex + 1);
        satelliteRootId = 0;
      }
      else
        nodeByIndex = this.ComputeNodeByIndex(userIndex, out satelliteRootId);
      if (nodeByIndex != 0)
        return new RBTree<K>.NodePath(nodeByIndex, satelliteRootId);
      if (TreeAccessMethod.INDEX_ONLY == this._accessMethod)
        throw ExceptionBuilder.RowOutOfRange(userIndex);
      throw ExceptionBuilder.InternalRBTreeError(RBTreeError.IndexOutOFRangeinGetNodeByIndex);
    }

    private int ComputeNodeByIndex(int index, out int satelliteRootId)
    {
      ++index;
      satelliteRootId = 0;
      int nodeId = this.root;
      int num;
      while (nodeId != 0 && ((num = this.SubTreeSize(this.Left(nodeId)) + 1) != index || this.Next(nodeId) != 0))
      {
        if (index < num)
        {
          nodeId = this.Left(nodeId);
        }
        else
        {
          if (this.Next(nodeId) != 0 && index >= num && index <= num + this.SubTreeSize(this.Next(nodeId)) - 1)
          {
            satelliteRootId = nodeId;
            index = index - num + 1;
            return this.ComputeNodeByIndex(this.Next(nodeId), index);
          }
          if (this.Next(nodeId) == 0)
            index -= num;
          else
            index -= num + this.SubTreeSize(this.Next(nodeId)) - 1;
          nodeId = this.Right(nodeId);
        }
      }
      return nodeId;
    }

    private int ComputeNodeByIndex(int x_id, int index)
    {
      while (x_id != 0)
      {
        Debug.Assert(this.Next(x_id) == 0, "has unexpected satellite tree");
        int nodeId = this.Left(x_id);
        int num = this.SubTreeSize(nodeId) + 1;
        if (index < num)
          x_id = nodeId;
        else if (num < index)
        {
          x_id = this.Right(x_id);
          index -= num;
        }
        else
          break;
      }
      return x_id;
    }

    public bool CheckUnique(int curNodeId) => curNodeId == 0 || this.Next(curNodeId) == 0 && this.CheckUnique(this.Left(curNodeId)) && this.CheckUnique(this.Right(curNodeId));

    public int Insert(K item)
    {
      int newNode = this.GetNewNode(item);
      this.RBInsert(0, newNode, 0, -1, false);
      return newNode;
    }

    public int Add(K item)
    {
      int newNode = this.GetNewNode(item);
      this.RBInsert(0, newNode, 0, -1, false);
      return newNode;
    }

    public IEnumerator GetEnumerator() => (IEnumerator) new RBTree<K>.RBTreeEnumerator(this);

    public int IndexOf(int nodeId, K item)
    {
      int num1 = -1;
      if (nodeId == 0)
        return num1;
      if ((object) this.Key(nodeId) == (object) item)
        return this.GetIndexByNode(nodeId);
      int num2;
      if ((num2 = this.IndexOf(this.Left(nodeId), item)) != -1)
        return num2;
      return this.IndexOf(this.Right(nodeId), item);
    }

    public int Insert(int position, K item) => this.InsertAt(position, item, false);

    public int InsertAt(int position, K item, bool append)
    {
      int newNode = this.GetNewNode(item);
      this.RBInsert(0, newNode, 0, position, append);
      return newNode;
    }

    public void RemoveAt(int position) => this.DeleteByIndex(position);

    public void Clear()
    {
      this.InitTree();
      ++this._version;
    }

    public void CopyTo(Array array, int index)
    {
      if (array == null)
        throw ExceptionBuilder.ArgumentNull(nameof (array));
      if (index < 0)
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (index));
      int count = this.Count;
      if (array.Length - index < this.Count)
        throw ExceptionBuilder.InvalidOffsetLength();
      int num = this.Minimum(this.root);
      for (int index1 = 0; index1 < count; ++index1)
      {
        array.SetValue((object) this.Key(num), index + index1);
        num = this.Successor(num);
      }
    }

    public void CopyTo(K[] array, int index)
    {
      if (array == null)
        throw ExceptionBuilder.ArgumentNull(nameof (array));
      if (index < 0)
        throw ExceptionBuilder.ArgumentOutOfRange(nameof (index));
      int count = this.Count;
      if (array.Length - index < this.Count)
        throw ExceptionBuilder.InvalidOffsetLength();
      int num = this.Minimum(this.root);
      for (int index1 = 0; index1 < count; ++index1)
      {
        array[index + index1] = this.Key(num);
        num = this.Successor(num);
      }
    }

    private void SetRight(int nodeId, int rightNodeId) => this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].rightId = rightNodeId;

    private void SetLeft(int nodeId, int leftNodeId) => this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].leftId = leftNodeId;

    private void SetParent(int nodeId, int parentNodeId)
    {
      Debug.Assert((uint) nodeId > 0U, " in SetParent  nodeId == NIL");
      this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].parentId = parentNodeId;
    }

    private void SetColor(int nodeId, RBTree<K>.NodeColor color)
    {
      Debug.Assert((uint) nodeId > 0U, " in SetColor  nodeId == NIL");
      this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].nodeColor = color;
    }

    private void SetKey(int nodeId, K key) => this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].keyOfNode = key;

    private void SetNext(int nodeId, int nextNodeId) => this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].nextId = nextNodeId;

    private void SetSubTreeSize(int nodeId, int size)
    {
      Debug.Assert(nodeId != 0 && (size != 0 || this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].selfId == 0) && (size != 1 || this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].nextId == 0), "SetSize");
      this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].subTreeSize = size;
      this.VerifySize(nodeId, size);
    }

    private void IncreaseSize(int nodeId) => ++this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].subTreeSize;

    private void RecomputeSize(int nodeId)
    {
      int num = this.SubTreeSize(this.Left(nodeId)) + this.SubTreeSize(this.Right(nodeId)) + (this.Next(nodeId) == 0 ? 1 : this.SubTreeSize(this.Next(nodeId)));
      this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].subTreeSize = num;
    }

    private void DecreaseSize(int nodeId)
    {
      --this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].subTreeSize;
      this.VerifySize(nodeId, this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].subTreeSize);
    }

    [Conditional("DEBUG")]
    private void VerifySize(int nodeId, int size) => Debug.Assert(this.SubTreeSize(this.Left(nodeId)) + this.SubTreeSize(this.Right(nodeId)) + (this.Next(nodeId) == 0 ? 1 : this.SubTreeSize(this.Next(nodeId))) == size, nameof (VerifySize));

    public int Right(int nodeId) => this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].rightId;

    public int Left(int nodeId) => this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].leftId;

    public int Parent(int nodeId) => this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].parentId;

    private RBTree<K>.NodeColor color(int nodeId) => this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].nodeColor;

    public int Next(int nodeId) => this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].nextId;

    public int SubTreeSize(int nodeId) => this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].subTreeSize;

    public K Key(int nodeId) => this._pageTable[nodeId >> 16].Slots[nodeId & (int) ushort.MaxValue].keyOfNode;

    private enum NodeColor
    {
      red,
      black,
    }

    private struct Node
    {
      internal int selfId;
      internal int leftId;
      internal int rightId;
      internal int parentId;
      internal int nextId;
      internal int subTreeSize;
      internal K keyOfNode;
      internal RBTree<K>.NodeColor nodeColor;
    }

    private struct NodePath
    {
      internal readonly int NodeID;
      internal readonly int MainTreeNodeID;

      internal NodePath(int nodeID, int mainTreeNodeID)
      {
        this.NodeID = nodeID;
        this.MainTreeNodeID = mainTreeNodeID;
      }
    }

    private sealed class TreePage
    {
      public const int slotLineSize = 32;
      internal readonly RBTree<K>.Node[] Slots;
      internal readonly int[] SlotMap;
      private int _inUseCount;
      private int _pageId;
      private int _nextFreeSlotLine;

      internal TreePage(int size)
      {
        this.Slots = size <= 65536 ? new RBTree<K>.Node[size] : throw ExceptionBuilder.InternalRBTreeError(RBTreeError.InvalidPageSize);
        this.SlotMap = new int[(size + 32 - 1) / 32];
      }

      internal int AllocSlot(RBTree<K> tree)
      {
        int num1 = -1;
        if (this._inUseCount < this.Slots.Length)
        {
          for (int nextFreeSlotLine = this._nextFreeSlotLine; nextFreeSlotLine < this.SlotMap.Length; ++nextFreeSlotLine)
          {
            if ((uint) this.SlotMap[nextFreeSlotLine] < uint.MaxValue)
            {
              int num2 = ~this.SlotMap[nextFreeSlotLine] & this.SlotMap[nextFreeSlotLine] + 1;
              Debug.Assert((this.SlotMap[nextFreeSlotLine] & num2) == 0, "Slot position segment[segmentPos ]: [freeSlot] is in use. Expected to be empty");
              this.SlotMap[nextFreeSlotLine] |= num2;
              ++this._inUseCount;
              if (this._inUseCount == this.Slots.Length)
                tree.MarkPageFull(this);
              ++tree._inUseNodeCount;
              int intValueFromBitMap = RBTree<K>.GetIntValueFromBitMap((uint) num2);
              this._nextFreeSlotLine = nextFreeSlotLine;
              num1 = nextFreeSlotLine * 32 + intValueFromBitMap;
              break;
            }
          }
          if (num1 == -1 && this._nextFreeSlotLine != 0)
          {
            this._nextFreeSlotLine = 0;
            num1 = this.AllocSlot(tree);
          }
        }
        return num1;
      }

      internal int InUseCount
      {
        get => this._inUseCount;
        set => this._inUseCount = value;
      }

      internal int PageId
      {
        get => this._pageId;
        set => this._pageId = value;
      }
    }

    internal struct RBTreeEnumerator : IEnumerator<K>, IEnumerator, IDisposable
    {
      private readonly RBTree<K> tree;
      private readonly int version;
      private int index;
      private int mainTreeNodeId;
      private K current;

      internal RBTreeEnumerator(RBTree<K> tree)
      {
        this.tree = tree;
        this.version = tree._version;
        this.index = 0;
        this.mainTreeNodeId = tree.root;
        this.current = default (K);
      }

      internal RBTreeEnumerator(RBTree<K> tree, int position)
      {
        this.tree = tree;
        this.version = tree._version;
        if (position == 0)
        {
          this.index = 0;
          this.mainTreeNodeId = tree.root;
        }
        else
        {
          this.index = tree.ComputeNodeByIndex(position - 1, out this.mainTreeNodeId);
          if (this.index == 0)
            throw ExceptionBuilder.InternalRBTreeError(RBTreeError.IndexOutOFRangeinGetNodeByIndex);
        }
        this.current = default (K);
      }

      public void Dispose()
      {
      }

      public bool MoveNext()
      {
        if (this.version != this.tree._version)
          throw ExceptionBuilder.EnumeratorModified();
        int num = this.tree.Successor(ref this.index, ref this.mainTreeNodeId) ? 1 : 0;
        this.current = this.tree.Key(this.index);
        return num != 0;
      }

      public K Current => this.current;

      object IEnumerator.Current => (object) this.Current;

      void IEnumerator.Reset()
      {
        if (this.version != this.tree._version)
          throw ExceptionBuilder.EnumeratorModified();
        this.index = 0;
        this.mainTreeNodeId = this.tree.root;
        this.current = default (K);
      }
    }
  }
}
