// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.DeclarationManager
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security;

namespace Microsoft.Xna.Framework.Graphics
{
  internal class DeclarationManager : IEqualityComparer<VertexElement[]>
  {
    private GraphicsDevice device;
    private Dictionary<VertexElement[], DeclarationBinding> bindings;
    private DeclarationBinding[] currentDeclarations;
    private int currentDeclarationCount;

    internal DeclarationManager(GraphicsDevice device)
    {
      this.device = device;
      this.bindings = new Dictionary<VertexElement[], DeclarationBinding>((IEqualityComparer<VertexElement[]>) this);
      this.currentDeclarations = new DeclarationBinding[device._profileCapabilities.MaxVertexStreams];
    }

    internal void ReleaseAllDeclarations()
    {
      lock (this)
      {
        this.ClearCurrent();
        foreach (DeclarationBinding declarationBinding in this.bindings.Values)
        {
          declarationBinding.root.RecursiveRelease(this.device);
          declarationBinding.indirectOffspring.Clear();
        }
      }
    }

    internal DeclarationBinding CreateBinding(VertexDeclaration declaration)
    {
      lock (this)
      {
        VertexElement[] elements = declaration._elements;
        DeclarationBinding declarationBinding;
        if (this.bindings.TryGetValue(elements, out declarationBinding))
        {
          ++declarationBinding.referenceCount;
          return declarationBinding;
        }
        declarationBinding = new DeclarationBinding(elements);
        this.bindings.Add(elements, declarationBinding);
        return declarationBinding;
      }
    }

    internal void ReleaseBinding(DeclarationBinding binding)
    {
      lock (this)
      {
        if (--binding.referenceCount > 0)
          return;
        binding.root.RecursiveRelease(this.device);
        foreach (DeclarationBinding.BindingNode bindingNode in new List<DeclarationBinding.BindingNode>((IEnumerable<DeclarationBinding.BindingNode>) binding.indirectOffspring.Keys))
          bindingNode.RemoveChild(binding, this.device);
        this.bindings.Remove(binding.elements);
      }
    }

    internal void SetVertexDeclaration(VertexDeclaration declaration)
    {
      lock (this)
      {
        try
        {
          if (this.currentDeclarationCount == 1 && declaration._binding == this.currentDeclarations[0])
            return;
          if (declaration._binding == null || declaration.GraphicsDevice != this.device)
            declaration.Bind(this.device);
          this.currentDeclarations[0] = declaration._binding;
          for (int index = 1; index < this.currentDeclarationCount; ++index)
            this.currentDeclarations[index] = (DeclarationBinding) null;
          this.currentDeclarationCount = 1;
          this.SetNativeDeclaration();
        }
        catch
        {
          this.ClearCurrent();
          throw;
        }
      }
    }

    internal void SetVertexDeclaration(VertexBufferBinding[] vertexBuffers)
    {
      lock (this)
      {
        try
        {
          bool flag = false;
          for (int index = 0; index < vertexBuffers.Length; ++index)
          {
            VertexDeclaration vertexDeclaration = vertexBuffers[index]._vertexBuffer._vertexDeclaration;
            DeclarationBinding binding = vertexDeclaration._binding;
            if (binding != this.currentDeclarations[index])
            {
              if (binding == null || vertexDeclaration.GraphicsDevice != this.device)
              {
                vertexDeclaration.Bind(this.device);
                binding = vertexDeclaration._binding;
              }
              this.currentDeclarations[index] = binding;
              flag = true;
            }
          }
          for (int length = vertexBuffers.Length; length < this.currentDeclarationCount; ++length)
          {
            this.currentDeclarations[length] = (DeclarationBinding) null;
            flag = true;
          }
          this.currentDeclarationCount = vertexBuffers.Length;
          if (!flag)
            return;
          this.SetNativeDeclaration();
        }
        catch
        {
          this.ClearCurrent();
          throw;
        }
      }
    }

    private void ClearCurrent()
    {
      for (int index = 0; index < this.currentDeclarationCount; ++index)
        this.currentDeclarations[index] = (DeclarationBinding) null;
      this.currentDeclarationCount = 0;
    }

    private void SetNativeDeclaration()
    {
      DeclarationBinding.BindingNode key = this.currentDeclarations[0].root;
      for (int index = 1; index < this.currentDeclarationCount; ++index)
      {
        DeclarationBinding.BindingNode bindingNode = key.GetChild(this.currentDeclarations[index]);
        if (bindingNode == null)
        {
          bindingNode = new DeclarationBinding.BindingNode();
          key.AddChild(this.currentDeclarations[index], bindingNode);
          this.currentDeclarations[index].indirectOffspring.Add(key, true);
        }
        key = bindingNode;
      }
      if (key.handle == uint.MaxValue)
        key.handle = this.CreateNativeDeclaration();
      PacketHelpers.SendResourceSetPacket(this.device, HLCBPacketType.SetVertexDeclaration, key.handle);
    }

    [SecuritySafeCritical]
    private unsafe uint CreateNativeDeclaration()
    {
      int length = 0;
      for (int index = 0; index < this.currentDeclarationCount; ++index)
        length += this.currentDeclarations[index].elements.Length;
      if (length > this.device._profileCapabilities.MaxVertexStreams)
        this.device._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileMaxVertexElements, (object) this.device._profileCapabilities.MaxVertexStreams);
      UnsafeNativeStructures.VERTEX_ELEMENT[] elements1 = new UnsafeNativeStructures.VERTEX_ELEMENT[length];
      int pos = 0;
      for (int index1 = 0; index1 < this.currentDeclarationCount; ++index1)
      {
        VertexElement[] elements2 = this.currentDeclarations[index1].elements;
        for (int index2 = 0; index2 < elements2.Length; ++index2)
        {
          elements1[pos].Stream = index1;
          elements1[pos].Offset = elements2[index2].Offset;
          elements1[pos].Format = elements2[index2].VertexElementFormat;
          elements1[pos].Usage = elements2[index2].VertexElementUsage;
          elements1[pos].UsageIndex = elements2[index2].UsageIndex;
          while (DeclarationManager.IsDuplicateElement(elements1, pos))
          {
            ++elements1[pos].UsageIndex;
            if (elements1[pos].UsageIndex >= this.device._profileCapabilities.MaxVertexStreams)
              throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.DuplicateVertexElement, (object) elements2[index2].VertexElementUsage, (object) elements2[index2].UsageIndex));
          }
          ++pos;
        }
      }
      int handle;
      fixed (UnsafeNativeStructures.VERTEX_ELEMENT* vertexElementPtr = &elements1[0])
        handle = (int) UnsafeNativeMethods.VertexDeclaration.GetGlobal(this.device).CreateHandle(this.device.pComPtr, (void*) vertexElementPtr, (uint) length);
      return handle != -1 ? (uint) handle : throw new OutOfMemoryException(FrameworkResources.CouldNotCreateResource);
    }

    private static bool IsDuplicateElement(
      UnsafeNativeStructures.VERTEX_ELEMENT[] elements,
      int pos)
    {
      for (int index = 0; index < pos; ++index)
      {
        if (elements[pos].Usage == elements[index].Usage && elements[pos].UsageIndex == elements[index].UsageIndex)
          return true;
      }
      return false;
    }

    int IEqualityComparer<VertexElement[]>.GetHashCode(
      VertexElement[] obj)
    {
      int num = 0;
      for (int index = 0; index < obj.Length; ++index)
        num ^= obj[index].GetHashCode();
      return num;
    }

    bool IEqualityComparer<VertexElement[]>.Equals(
      VertexElement[] x,
      VertexElement[] y)
    {
      if (x.Length != y.Length)
        return false;
      for (int index = 0; index < x.Length; ++index)
      {
        if (x[index] != y[index])
          return false;
      }
      return true;
    }
  }
}
