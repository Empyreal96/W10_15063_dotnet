// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.DeclarationBinding
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System.Collections.Generic;

namespace Microsoft.Xna.Framework.Graphics
{
  internal class DeclarationBinding
  {
    internal VertexElement[] elements;
    internal int referenceCount = 1;
    internal DeclarationBinding.BindingNode root = new DeclarationBinding.BindingNode();
    internal Dictionary<DeclarationBinding.BindingNode, bool> indirectOffspring = new Dictionary<DeclarationBinding.BindingNode, bool>();

    internal DeclarationBinding(VertexElement[] elements) => this.elements = elements;

    internal class BindingNode
    {
      internal uint handle = uint.MaxValue;
      private List<KeyValuePair<DeclarationBinding, DeclarationBinding.BindingNode>> children;

      internal DeclarationBinding.BindingNode GetChild(DeclarationBinding key)
      {
        if (this.children != null)
        {
          for (int index = 0; index < this.children.Count; ++index)
          {
            KeyValuePair<DeclarationBinding, DeclarationBinding.BindingNode> child = this.children[index];
            if (child.Key == key)
              return child.Value;
          }
        }
        return (DeclarationBinding.BindingNode) null;
      }

      internal void AddChild(DeclarationBinding key, DeclarationBinding.BindingNode value)
      {
        if (this.children == null)
          this.children = new List<KeyValuePair<DeclarationBinding, DeclarationBinding.BindingNode>>();
        this.children.Add(new KeyValuePair<DeclarationBinding, DeclarationBinding.BindingNode>(key, value));
      }

      internal void RemoveChild(DeclarationBinding key, GraphicsDevice device)
      {
        if (this.children == null)
          return;
        for (int index = 0; index < this.children.Count; ++index)
        {
          KeyValuePair<DeclarationBinding, DeclarationBinding.BindingNode> child = this.children[index];
          if (child.Key == key)
          {
            this.children.RemoveAt(index);
            child.Value.RecursiveRelease(device);
            break;
          }
        }
      }

      internal void RecursiveRelease(GraphicsDevice device)
      {
        if (this.handle != uint.MaxValue)
        {
          UnsafeNativeMethods.VertexDeclaration.GetGlobal(device).ReleaseHandle(device != null ? device.pComPtr : 0U, this.handle);
          this.handle = uint.MaxValue;
        }
        if (this.children == null)
          return;
        foreach (KeyValuePair<DeclarationBinding, DeclarationBinding.BindingNode> child in this.children)
        {
          child.Key.indirectOffspring.Remove(this);
          child.Value.RecursiveRelease(device);
        }
        this.children = (List<KeyValuePair<DeclarationBinding, DeclarationBinding.BindingNode>>) null;
      }
    }
  }
}
