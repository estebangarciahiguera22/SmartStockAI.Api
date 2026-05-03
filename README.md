# SmartStockAI.Api

SmartStockAI.Api is an ASP.NET Core Web API designed to manage jewelry inventory and prepare the system for future AI-powered features.

This project is part of my AI Engineering learning path. The goal is to build a backend API with a clean layered architecture and progressively integrate artificial intelligence features.
--------------------------------------------------------------------------------------------------
## Current Version
### v0.1.0 - Initial API structure with simulated AI layer

## Version Roadmap

- v0.1.0 - Initial API structure with simulated AI layer
- v0.2.0 - Database integration with Entity Framework
- v0.3.0 - Validation and error handling
- v0.4.0 - Authentication and authorization
- v0.5.0 - Real AI provider integration
- v0.6.0 - AI-generated marketing captions
- v0.7.0 - RAG or product knowledge base
- v0.8.0 - Docker and deployment
- v0.9.0 - Production-ready release
--------------------------------------------------------------------------------------------------
## Current features:

- ASP.NET Core Web API project structure
- Layered architecture
- Jewelry product CRUD
- Swagger API documentation
- Dependency Injection
- In-memory repository
- Simulated AI product description
- Simulated AI stock suggestion

## Technologies Used
- C#
- ASP.NET Core Web API
- Swagger / Swashbuckle
- Dependency Injection
- In-memory repository

--------------------------------------------------------------------------------------------------

## Project Purpose

The purpose of this project is to create an AI-ready inventory API for jewelry products.

The current version focuses on:

- Backend architecture
- Product inventory management
- Jewelry-specific product data
- Simulated AI services
- Clean separation of responsibilities
- Future integration with real AI models

## NOTES:
- The current version uses an in-memory repository.
- This means that products are stored only while the API is running. If the application stops or restarts, the product list will be reset.
- Future versions will include database persistence using Entity Framework.

--------------------------------------------------------------------------------------------------

## Architecture
The project follows a layered architecture:
- Controllers → Services → Repositories → Data

--------------------------------------------------------------------------------------------------

## Author 
Esteban Garcia Higuera 

