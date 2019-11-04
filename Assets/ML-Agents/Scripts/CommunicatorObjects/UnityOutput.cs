// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mlagents/envs/communicator_objects/unity_output.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MLAgents.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from mlagents/envs/communicator_objects/unity_output.proto</summary>
  public static partial class UnityOutputReflection {

    #region Descriptor
    /// <summary>File descriptor for mlagents/envs/communicator_objects/unity_output.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnityOutputReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVtbGFnZW50cy9lbnZzL2NvbW11bmljYXRvcl9vYmplY3RzL3VuaXR5X291",
            "dHB1dC5wcm90bxIUY29tbXVuaWNhdG9yX29iamVjdHMaOG1sYWdlbnRzL2Vu",
            "dnMvY29tbXVuaWNhdG9yX29iamVjdHMvdW5pdHlfcmxfb3V0cHV0LnByb3Rv",
            "GkdtbGFnZW50cy9lbnZzL2NvbW11bmljYXRvcl9vYmplY3RzL3VuaXR5X3Js",
            "X2luaXRpYWxpemF0aW9uX291dHB1dC5wcm90byKaAQoLVW5pdHlPdXRwdXQS",
            "NgoJcmxfb3V0cHV0GAEgASgLMiMuY29tbXVuaWNhdG9yX29iamVjdHMuVW5p",
            "dHlSTE91dHB1dBJTChhybF9pbml0aWFsaXphdGlvbl9vdXRwdXQYAiABKAsy",
            "MS5jb21tdW5pY2F0b3Jfb2JqZWN0cy5Vbml0eVJMSW5pdGlhbGl6YXRpb25P",
            "dXRwdXRCH6oCHE1MQWdlbnRzLkNvbW11bmljYXRvck9iamVjdHNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MLAgents.CommunicatorObjects.UnityRlOutputReflection.Descriptor, global::MLAgents.CommunicatorObjects.UnityRlInitializationOutputReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MLAgents.CommunicatorObjects.UnityOutput), global::MLAgents.CommunicatorObjects.UnityOutput.Parser, new[]{ "RlOutput", "RlInitializationOutput" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UnityOutput : pb::IMessage<UnityOutput> {
    private static readonly pb::MessageParser<UnityOutput> _parser = new pb::MessageParser<UnityOutput>(() => new UnityOutput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UnityOutput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MLAgents.CommunicatorObjects.UnityOutputReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityOutput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityOutput(UnityOutput other) : this() {
      rlOutput_ = other.rlOutput_ != null ? other.rlOutput_.Clone() : null;
      rlInitializationOutput_ = other.rlInitializationOutput_ != null ? other.rlInitializationOutput_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityOutput Clone() {
      return new UnityOutput(this);
    }

    /// <summary>Field number for the "rl_output" field.</summary>
    public const int RlOutputFieldNumber = 1;
    private global::MLAgents.CommunicatorObjects.UnityRLOutput rlOutput_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::MLAgents.CommunicatorObjects.UnityRLOutput RlOutput {
      get { return rlOutput_; }
      set {
        rlOutput_ = value;
      }
    }

    /// <summary>Field number for the "rl_initialization_output" field.</summary>
    public const int RlInitializationOutputFieldNumber = 2;
    private global::MLAgents.CommunicatorObjects.UnityRLInitializationOutput rlInitializationOutput_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::MLAgents.CommunicatorObjects.UnityRLInitializationOutput RlInitializationOutput {
      get { return rlInitializationOutput_; }
      set {
        rlInitializationOutput_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UnityOutput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UnityOutput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RlOutput, other.RlOutput)) return false;
      if (!object.Equals(RlInitializationOutput, other.RlInitializationOutput)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (rlOutput_ != null) hash ^= RlOutput.GetHashCode();
      if (rlInitializationOutput_ != null) hash ^= RlInitializationOutput.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (rlOutput_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RlOutput);
      }
      if (rlInitializationOutput_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RlInitializationOutput);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (rlOutput_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RlOutput);
      }
      if (rlInitializationOutput_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RlInitializationOutput);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UnityOutput other) {
      if (other == null) {
        return;
      }
      if (other.rlOutput_ != null) {
        if (rlOutput_ == null) {
          RlOutput = new global::MLAgents.CommunicatorObjects.UnityRLOutput();
        }
        RlOutput.MergeFrom(other.RlOutput);
      }
      if (other.rlInitializationOutput_ != null) {
        if (rlInitializationOutput_ == null) {
          RlInitializationOutput = new global::MLAgents.CommunicatorObjects.UnityRLInitializationOutput();
        }
        RlInitializationOutput.MergeFrom(other.RlInitializationOutput);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (rlOutput_ == null) {
              RlOutput = new global::MLAgents.CommunicatorObjects.UnityRLOutput();
            }
            input.ReadMessage(RlOutput);
            break;
          }
          case 18: {
            if (rlInitializationOutput_ == null) {
              RlInitializationOutput = new global::MLAgents.CommunicatorObjects.UnityRLInitializationOutput();
            }
            input.ReadMessage(RlInitializationOutput);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
