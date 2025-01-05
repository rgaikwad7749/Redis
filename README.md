# Redis Project

## Description
This repository demonstrates the use of **Redis** with .NET, showcasing examples like implementing **Leaderboards** and **Redis Publish/Subscribe (Pub/Sub)** mechanisms.

## Folder Structure
- **LeaderBoard**: Contains the implementation of a leaderboard using Redis for fast and efficient ranking.
- **RedisPubSub**: Demonstrates how to use Redis Pub/Sub for real-time messaging.

## Features
1. **LeaderBoard**:
   - Efficiently manages and ranks player scores.
   - Real-time updates for leaderboards.
   - Uses Redis sorted sets to maintain rankings.

2. **Redis Publish/Subscribe**:
   - Implements a real-time messaging system using Redis Pub/Sub.
   - Demonstrates broadcasting messages to multiple subscribers.

## Prerequisites
- **Redis Server**: Ensure Redis is installed and running on your system.
- **.NET SDK**: Requires .NET SDK 6.0 or later.
- A code editor like **Visual Studio** or **VS Code**.

## How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/rgaikwad7749/RedisProject.git

2. Navigate to the desired project folder:
   
   ```bash
   cd LeaderBoard
   ```
 or
 
   ```bash    
   cd RedisPubSub
   ```

3. Build and run the application:
   
   ```bash
   dotnet build
   dotnet run
   ```

 ## Dependencies
- **StackExchange.Redis**: A high-performance .NET client for Redis.
- Other dependencies are specified in the respective .csproj files.

 ## License
This project is licensed under the MIT License. See the LICENSE file for more details.

## Contribution
Contributions are welcome! Feel free to fork the repository, open issues, and submit pull requests for improvements or bug fixes.
