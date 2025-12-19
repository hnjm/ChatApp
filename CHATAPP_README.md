# ChatApp - Professional Real-Time Chat Application

## تطبيق دردشة احترافي متكامل

A complete, production-ready real-time chat application built with .NET 10, ASP.NET Core, Blazor, SignalR, and WebRTC.

## 🚀 Features / الميزات

### Core Features
- ✅ **Real-time Messaging** - Instant text messaging with delivery and read receipts
- ✅ **Media Support** - Share images, videos, audio files, and documents
- ✅ **Voice Messages** - Record and send voice messages with waveform visualization
- ✅ **Voice & Video Calls** - High-quality WebRTC-powered calls
- ✅ **Groups** - Create and manage group conversations with roles and permissions
- ✅ **Channels** - Broadcast channels for one-to-many communication
- ✅ **Message Reactions** - React to messages with emojis
- ✅ **Message Editing & Deletion** - Edit or delete messages (for me or everyone)
- ✅ **Reply & Forward** - Reply to specific messages or forward them
- ✅ **Search** - Search messages, users, groups, and channels
- ✅ **Online Status** - Real-time user presence (Online, Offline, Away, Busy)
- ✅ **Typing Indicators** - See when someone is typing
- ✅ **Push Notifications** - Real-time notifications via SignalR

### Authentication & Security
- ✅ **ASP.NET Core Identity** - Secure user authentication
- ✅ **JWT Authentication** - Token-based authentication with refresh tokens
- ✅ **OAuth 2.0** - Social login (Google, Facebook, Microsoft)
- ✅ **Two-Factor Authentication (2FA)** - Extra security layer
- ✅ **Password Encryption** - Secure password storage

### Architecture
- ✅ **Clean Architecture** - Separation of concerns with Domain, Application, Infrastructure, and Presentation layers
- ✅ **CQRS Pattern** - Command Query Responsibility Segregation with MediatR
- ✅ **Repository Pattern** - Generic and specific repositories
- ✅ **Unit of Work** - Transaction management
- ✅ **.NET Aspire** - Cloud-native orchestration and service management

## 🏗️ Architecture / البنية المعمارية

```
ChatApp/
├── src/
│   ├── Core/
│   │   ├── ChatApp.Domain/              # Domain entities, enums, interfaces
│   │   └── ChatApp.Application/         # DTOs, CQRS, Validators, Mappings
│   ├── Infrastructure/
│   │   └── ChatApp.Infrastructure/      # Data access, Identity, Services
│   ├── Presentation/
│   │   ├── ChatApp.Api/                 # REST API, SignalR Hubs
│   │   ├── ChatApp.WebClient/           # Blazor Client UI
│   │   └── ChatApp.WebAdmin/            # Blazor Admin Panel
│   ├── ChatApp.Aspire.AppHost/          # Aspire orchestration
│   └── ChatApp.ServiceDefaults/         # Shared service configurations
```

## 🛠️ Technology Stack / التقنيات المستخدمة

- **.NET 10** - Latest .NET framework
- **ASP.NET Core 10** - Web framework
- **Blazor** - Interactive web UI
- **Microsoft Fluent UI** - Modern, accessible UI components
- **Entity Framework Core** - ORM for database access
- **PostgreSQL** - Primary relational database
- **MongoDB** - NoSQL database for messages and media
- **SignalR** - Real-time communication
- **WebRTC** - Peer-to-peer voice and video calls
- **MediatR** - CQRS implementation
- **AutoMapper** - Object-to-object mapping
- **FluentValidation** - Input validation
- **ASP.NET Core Identity** - Authentication and authorization
- **JWT Bearer** - Token-based authentication
- **.NET Aspire** - Cloud-native orchestration

## 📦 Domain Model / نموذج البيانات

### Core Entities

#### User
- User management with profile, status, and preferences
- Support for multiple authentication methods
- Online status tracking

#### Message
- Text, Image, Video, Audio, File, Voice, Document types
- Reply and forward capabilities
- Edit and delete (for me or everyone)
- Message reactions and read status

#### Conversation
- Peer-to-peer, Group, and Channel types
- Message history and unread counts
- Mute and archive capabilities

#### Group
- Create groups with multiple members
- Member roles: Owner, Admin, Moderator, Member
- Group settings and permissions
- Invite links

#### Channel
- Broadcast channels for announcements
- Subscribe/unsubscribe functionality
- Public and private channels
- Verified channel badge

#### Call
- Voice and video call support
- WebRTC-powered P2P connections
- Call history and duration tracking

## 🔧 Setup Instructions / تعليمات التثبيت

### Prerequisites
- .NET 10 SDK
- PostgreSQL
- MongoDB (optional, for scalability)
- Redis (optional, for caching)
- Docker (optional, for containerization)

### Installation Steps

1. **Clone the repository**
```bash
git clone https://github.com/hnjm/ChatApp.git
cd ChatApp
```

2. **Restore NuGet packages**
```bash
dotnet restore
```

3. **Update connection strings**
Edit `appsettings.json` in `ChatApp.Api` project:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=chatapp;Username=postgres;Password=yourpassword",
    "IdentityConnection": "Host=localhost;Database=chatapp_identity;Username=postgres;Password=yourpassword",
    "MongoConnection": "mongodb://localhost:27017",
    "RedisConnection": "localhost:6379"
  }
}
```

4. **Run database migrations**
```bash
cd src/Presentation/ChatApp.Api
dotnet ef database update --context ChatDbContext
dotnet ef database update --context IdentityDbContext
```

5. **Build the solution**
```bash
dotnet build
```

6. **Run the application**
```bash
# Run with Aspire AppHost (recommended)
cd src/ChatApp.Aspire.AppHost
dotnet run

# Or run individual projects
cd src/Presentation/ChatApp.Api
dotnet run
```

7. **Access the application**
- API: `https://localhost:7001`
- Swagger: `https://localhost:7001/swagger`
- Web Client: `https://localhost:7002`
- Admin Panel: `https://localhost:7003`

## 📚 API Documentation / توثيق API

### Authentication Endpoints
- `POST /api/auth/register` - Register new user
- `POST /api/auth/login` - Login
- `POST /api/auth/refresh-token` - Refresh JWT token
- `POST /api/auth/logout` - Logout

### Message Endpoints
- `GET /api/messages/{conversationId}` - Get conversation messages
- `POST /api/messages/send` - Send text message
- `PUT /api/messages/{id}` - Edit message
- `DELETE /api/messages/{id}` - Delete message
- `POST /api/messages/{id}/react` - React to message

### Group Endpoints
- `GET /api/groups` - Get user groups
- `POST /api/groups` - Create group
- `POST /api/groups/{id}/members` - Add member
- `DELETE /api/groups/{id}/members/{userId}` - Remove member
- `GET /api/groups/{id}/members` - Get group members

### Call Endpoints
- `POST /api/calls/initiate` - Initiate call
- `POST /api/calls/{id}/accept` - Accept call
- `POST /api/calls/{id}/reject` - Reject call
- `POST /api/calls/{id}/end` - End call

### SignalR Hubs
- `/hubs/chat` - Chat messages and typing indicators
- `/hubs/call` - Voice/video call signaling
- `/hubs/notification` - Real-time notifications

## 🧪 Testing / الاختبار

```bash
# Run unit tests
dotnet test

# Run with coverage
dotnet test /p:CollectCoverage=true
```

## 🐳 Docker Support / دعم Docker

```bash
# Build Docker image
docker build -t chatapp:latest .

# Run with Docker Compose
docker-compose up -d
```

## 📝 Project Structure Details

### Domain Layer
- **Entities**: Core business entities (User, Message, Group, etc.)
- **Enums**: MessageType, ConversationType, CallType, UserStatus, MemberRole
- **Interfaces**: Repository and Unit of Work interfaces

### Application Layer
- **DTOs**: Data Transfer Objects for all entities
- **CQRS Commands**: SendMessage, CreateGroup, InitiateCall, etc.
- **CQRS Queries**: GetMessages, GetGroups, SearchUsers, etc.
- **Validators**: FluentValidation rules for input validation
- **Mappings**: AutoMapper profiles
- **Service Interfaces**: IMessageService, IGroupService, etc.

### Infrastructure Layer
- **PostgreSQL**: Main database with EF Core
- **MongoDB**: Optional NoSQL for scalability
- **Repositories**: Generic and specific repositories
- **Identity**: ASP.NET Core Identity configuration
- **Services**: Media storage, notifications, SignalR, WebRTC

### Presentation Layer
- **ChatApp.Api**: REST API with SignalR hubs
- **ChatApp.WebClient**: Blazor web app for users
- **ChatApp.WebAdmin**: Blazor admin panel

## 🌍 Internationalization / التوطين

The application supports multiple languages:
- English
- Arabic (العربية)

## 📄 License / الترخيص

This project is open-source and available under the MIT License.

## 👥 Contributing / المساهمة

Contributions are welcome! Please read our contributing guidelines before submitting pull requests.

## 📧 Contact / التواصل

For questions or support, please open an issue on GitHub.

---

**Built with ❤️ using .NET 10 and modern web technologies**
