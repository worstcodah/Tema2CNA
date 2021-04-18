// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/zodiac.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ZodiacClient {
  public static partial class StarSignService
  {
    static readonly string __ServiceName = "zodiac.StarSignService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::ZodiacClient.InputDate> __Marshaller_zodiac_InputDate = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ZodiacClient.InputDate.Parser));
    static readonly grpc::Marshaller<global::ZodiacClient.StarSignResponse> __Marshaller_zodiac_StarSignResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ZodiacClient.StarSignResponse.Parser));

    static readonly grpc::Method<global::ZodiacClient.InputDate, global::ZodiacClient.StarSignResponse> __Method_GetStarSignRequest = new grpc::Method<global::ZodiacClient.InputDate, global::ZodiacClient.StarSignResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetStarSignRequest",
        __Marshaller_zodiac_InputDate,
        __Marshaller_zodiac_StarSignResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ZodiacClient.ZodiacReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for StarSignService</summary>
    public partial class StarSignServiceClient : grpc::ClientBase<StarSignServiceClient>
    {
      /// <summary>Creates a new client for StarSignService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public StarSignServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for StarSignService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public StarSignServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected StarSignServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected StarSignServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::ZodiacClient.StarSignResponse GetStarSignRequest(global::ZodiacClient.InputDate request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStarSignRequest(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ZodiacClient.StarSignResponse GetStarSignRequest(global::ZodiacClient.InputDate request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetStarSignRequest, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ZodiacClient.StarSignResponse> GetStarSignRequestAsync(global::ZodiacClient.InputDate request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStarSignRequestAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ZodiacClient.StarSignResponse> GetStarSignRequestAsync(global::ZodiacClient.InputDate request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetStarSignRequest, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override StarSignServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new StarSignServiceClient(configuration);
      }
    }

  }
}
#endregion
