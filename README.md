# abp-io-rabbitmq-notification
Abp-io projects with Microservice architecture implementing notification with rabbitmq.

- Source project as Message Producer. 
- Destination project as Message Consumer.
- RabbitMQ is the middleware which collects the messages from the Source Project and send to the Destination projects.

# What does these application do?
This repository contains two solutions one is source and another is destination. After executing an API in source a dummy notification id is send to destination using rabbitmq.

# Prerequisite
1. ASP.NET 5
2. SQL Server (SQL Server 2019 was used for developing)
3. [ABP CLI](https://docs.abp.io/en/abp/latest/CLI) (For running RabbitMQ.Source.DbMigrator in Source)
4. [Erlang](https://www.erlang.org/downloads)
5. [RabbitMQ](https://www.rabbitmq.com/install-windows.html#downloads)
6. Visual Studio (Good to have)

# Architecture of these solutions
These projects are being utilized by both solutions and should be in same location as in the repository.
1. RabbitMQ.Source.DbMigrator
2. RabbitMQ.Source.Domain
3. RabbitMQ.Source.Domain.Shared
4. RabbitMQ.Source.EntityFrameworkcore

API is executed in source and the api sends data using local event bus within the same solution, and necessary notification steps should be done here like (generating notification, adding notification to database etc.). Then, it would send notification id to destination soludtion using distributed event bus, and it is here sending of notification step should be done.

# Steps to follow
1. Open both solutions and restore nuget packages.
2. Set RabbitMQ.Source.HttpApi.Host and RabbitMQ.Destination.HttpApi.Host as startup projects.
3. Run RabbitMQ.Source.DbMigrator
  - Right click on project
  - Debug
  - Start new instance (This will open a console application and create necessary tables in sql server will default seed data).
4. Run both solutions.
5. Two swaggers will open.
6. Add breakpoint in RabbitMQ.Destination.Application > EventHandlers > EmailNotificationEventHandler > HandleEventAsync method.
7. Execute WishBirthday api from source swagger.

# Conclusion
These applications utilizes LocalEvent available in abp.io and rabbitmq to send data from one solution to another.

Additional resources
1. [Abp.io](https://abp.io/)
2. [Abp.io docs](https://docs.abp.io)
3. [Abp.io RabbitMQ integration 1](https://docs.abp.io/en/abp/latest/Background-Jobs-RabbitMq)
4. [Abp.io RabbitMQ integration 2](https://docs.abp.io/en/abp/latest/Distributed-Event-Bus-RabbitMQ-Integration)
5. [Local Event Bus](https://docs.abp.io/en/abp/latest/Local-Event-Bus)
6. [Distributed Event Bus](https://docs.abp.io/en/abp/latest/Distributed-Event-Bus)
