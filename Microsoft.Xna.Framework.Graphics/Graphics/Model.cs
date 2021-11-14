// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.Model
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using Microsoft.Xna.Framework.Content;
using System;

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class Model
  {
    private ModelBone root;
    private ModelBoneCollection bones;
    private ModelMeshCollection meshes;
    private object tag;
    private static Matrix[] sharedDrawBoneMatrices;

    internal Model()
    {
    }

    public void CopyBoneTransformsTo(Matrix[] destinationBoneTransforms)
    {
      if (destinationBoneTransforms == null)
        throw new ArgumentNullException(nameof (destinationBoneTransforms));
      if (destinationBoneTransforms.Length < this.bones.Count)
        throw new ArgumentOutOfRangeException(nameof (destinationBoneTransforms));
      int count = this.bones.Count;
      for (int index = 0; index < count; ++index)
        destinationBoneTransforms[index] = this.bones[index].transform;
    }

    public void CopyAbsoluteBoneTransformsTo(Matrix[] destinationBoneTransforms)
    {
      if (destinationBoneTransforms == null)
        throw new ArgumentNullException(nameof (destinationBoneTransforms));
      if (destinationBoneTransforms.Length < this.bones.Count)
        throw new ArgumentOutOfRangeException(nameof (destinationBoneTransforms));
      int count = this.bones.Count;
      for (int index1 = 0; index1 < count; ++index1)
      {
        ModelBone bone = this.bones[index1];
        if (bone.Parent == null)
        {
          destinationBoneTransforms[index1] = bone.transform;
        }
        else
        {
          int index2 = bone.Parent.Index;
          destinationBoneTransforms[index1] = bone.transform * destinationBoneTransforms[index2];
        }
      }
    }

    public void CopyBoneTransformsFrom(Matrix[] sourceBoneTransforms)
    {
      if (sourceBoneTransforms == null)
        throw new ArgumentNullException(nameof (sourceBoneTransforms));
      if (sourceBoneTransforms.Length < this.bones.Count)
        throw new ArgumentOutOfRangeException(nameof (sourceBoneTransforms));
      int count = this.bones.Count;
      for (int index = 0; index < count; ++index)
        this.bones[index].transform = sourceBoneTransforms[index];
    }

    public void Draw(Matrix world, Matrix view, Matrix projection)
    {
      int count1 = this.meshes.Count;
      int count2 = this.bones.Count;
      Matrix[] destinationBoneTransforms = Model.sharedDrawBoneMatrices;
      if (destinationBoneTransforms == null || destinationBoneTransforms.Length < count2)
      {
        destinationBoneTransforms = new Matrix[count2];
        Model.sharedDrawBoneMatrices = destinationBoneTransforms;
      }
      this.CopyAbsoluteBoneTransformsTo(destinationBoneTransforms);
      for (int index1 = 0; index1 < count1; ++index1)
      {
        ModelMesh mesh = this.meshes[index1];
        int index2 = mesh.ParentBone.Index;
        int count3 = mesh.Effects.Count;
        for (int index3 = 0; index3 < count3; ++index3)
        {
          Effect effect = mesh.Effects[index3];
          if (effect == null)
            throw new InvalidOperationException(FrameworkResources.ModelHasNoEffect);
          if (!(effect is IEffectMatrices effectMatrices4))
            throw new InvalidOperationException(FrameworkResources.ModelHasNoIEffectMatrices);
          effectMatrices4.World = destinationBoneTransforms[index2] * world;
          effectMatrices4.View = view;
          effectMatrices4.Projection = projection;
        }
        mesh.Draw();
      }
    }

    public ModelBone Root => this.root;

    public ModelBoneCollection Bones => this.bones;

    public object Tag
    {
      get => this.tag;
      set => this.tag = value;
    }

    public ModelMeshCollection Meshes => this.meshes;

    internal static Model Read(ContentReader input)
    {
      Model model = new Model();
      model.ReadBones(input);
      model.ReadMeshes(input);
      model.root = model.ReadBoneReference(input);
      model.Tag = input.ReadObject<object>();
      return model;
    }

    private void ReadBones(ContentReader input)
    {
      ModelBone[] bones = new ModelBone[input.ReadInt32()];
      for (int index = 0; index < bones.Length; ++index)
      {
        string name = input.ReadObject<string>();
        Matrix transform = input.ReadMatrix();
        bones[index] = new ModelBone(name, transform, index);
      }
      this.bones = new ModelBoneCollection(bones);
      foreach (ModelBone modelBone in bones)
      {
        ModelBone newParent = this.ReadBoneReference(input);
        int length = input.ReadInt32();
        ModelBone[] newChildren = new ModelBone[length];
        for (int index = 0; index < length; ++index)
          newChildren[index] = this.ReadBoneReference(input);
        modelBone.SetParentAndChildren(newParent, newChildren);
      }
    }

    private ModelBone ReadBoneReference(ContentReader input)
    {
      int num = this.bones.Count + 1 > (int) byte.MaxValue ? input.ReadInt32() : (int) input.ReadByte();
      return num != 0 ? this.bones[num - 1] : (ModelBone) null;
    }

    private void ReadMeshes(ContentReader input)
    {
      int length = input.ReadInt32();
      ModelMesh[] meshes = new ModelMesh[length];
      for (int index = 0; index < length; ++index)
      {
        string name = input.ReadObject<string>();
        ModelBone parentBone = this.ReadBoneReference(input);
        BoundingSphere boundingSphere = new BoundingSphere();
        boundingSphere.Center = input.ReadVector3();
        boundingSphere.Radius = input.ReadSingle();
        object tag = input.ReadObject<object>();
        ModelMeshPart[] meshParts = Model.ReadMeshParts(input);
        meshes[index] = new ModelMesh(name, parentBone, boundingSphere, meshParts, tag);
      }
      this.meshes = new ModelMeshCollection(meshes);
    }

    private static ModelMeshPart[] ReadMeshParts(ContentReader input)
    {
      int length = input.ReadInt32();
      ModelMeshPart[] meshParts = new ModelMeshPart[length];
      for (int index = 0; index < length; ++index)
      {
        int vertexOffset = input.ReadInt32();
        int numVertices = input.ReadInt32();
        int startIndex = input.ReadInt32();
        int primitiveCount = input.ReadInt32();
        object tag = input.ReadObject<object>();
        meshParts[index] = new ModelMeshPart(vertexOffset, numVertices, startIndex, primitiveCount, tag);
        int uniqueCopyOfI = index;
        input.ReadSharedResource<VertexBuffer>((Action<VertexBuffer>) (vb => meshParts[uniqueCopyOfI].vertexBuffer = vb));
        input.ReadSharedResource<IndexBuffer>((Action<IndexBuffer>) (ib => meshParts[uniqueCopyOfI].indexBuffer = ib));
        input.ReadSharedResource<Effect>((Action<Effect>) (effect => meshParts[uniqueCopyOfI].Effect = effect));
      }
      return meshParts;
    }
  }
}
