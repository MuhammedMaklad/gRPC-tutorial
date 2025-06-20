# gRPC Overview

## What is gRPC?
gRPC (Google Remote Procedure Call) is a high-performance, open-source RPC framework that enables client-server communication across distributed systems. It uses **Protocol Buffers (Protobuf)** as its interface definition language and data serialization format.

## Key Features
- **Language Independence**: Supports multiple languages (Java, Python, Go, etc.).
- **Efficiency**: Uses binary Protobuf for compact payloads and fast serialization.
- **HTTP/2 Based**: Enables multiplexing, streaming, and lower latency.
- **Strong Typing**: Strict schema definitions via `.proto` files.
- **Cross-Platform**: Works across OS environments.

## Communication Patterns
1. **Unary RPC**: Single request → single response (traditional request-reply).
2. **Server Streaming RPC**: Single request → multiple responses.
3. **Client Streaming RPC**: Multiple requests → single response.
4. **Bidirectional Streaming RPC**: Async two-way streaming.

## Advantages Over REST
- **Performance**: Smaller payloads and faster serialization than JSON/HTTP.
- **Streaming**: Native support for real-time data flows.
- **Schema Evolution**: Backward/forward compatibility with Protobuf.
- **Code Generation**: Auto-generates client/server code from `.proto` files.

## Common Use Cases
- Microservices communication.
- Real-time systems (e.g., chat, IoT).
- Low-latency APIs.
- Polyglot environments.

## Workflow
1. Define service/messages in a `.proto` file.
2. Generate client/server code using Protobuf compiler.
3. Implement server logic.
4. Call RPC methods from the client.

## Client Call Types
- **Blocking**: Synchronous (waits for response).
- **Non-Blocking**: Asynchronous (uses callbacks/observers).

## Requirements
- Protocol Buffers compiler (`protoc`).
- gRPC libraries for your language.
- HTTP/2 support (for most features).

---

For implementation details, refer to the official [gRPC documentation](https://grpc.io/).