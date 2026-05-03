# SmartStockAI.Api

SmartStockAI.Api is an ASP.NET Core Web API designed to manage jewelry inventory and prepare the system for future AI-powered features.

This project is part of my AI Engineering learning path. The goal is to build a backend API with a clean layered architecture and progressively integrate artificial intelligence features.

--------------------------------------------------------------------------

## Current Version

### v1.3 - Validation and Error Handling

This version adds request validation using Data Annotations to ensure that the API receives coherent and valid data before executing business logic.


--------------------------------------------------------------------------

## Version History

### v1.0 - CRUD API

Initial version of the jewelry inventory API.

Includes:

- ASP.NET Core Web API structure
- Jewelry product CRUD
- Swagger API documentation
- Dependency Injection
- In-memory repository
- Layered architecture

--------------------------------------------------------------------------

### v1.1 - Simulated AI Layer

Introduced basic simulated AI services.

Includes:

- `AiController`
- `AiService`
- Simulated product description generation
- Simulated stock suggestion endpoint

--------------------------------------------------------------------------

### v1.2 - Provider Abstraction and PromptBuilder

Refactored the AI layer to prepare the project for future real AI provider integration.

Includes:

- `IAIProvider`
- `SimulatedAIProvider`
- `PromptBuilder`
- Product description prompt
- Marketing caption prompt
- Product story prompt
- AI provider abstraction


--------------------------------------------------------------------------

### v1.3 - Validation and Error Handling

Added request validation to improve API reliability.

Includes:

- Required field validation
- Minimum length validation
- Price validation
- Stock validation
- Minimum stock validation
- Currency code validation
- Automatic `400 Bad Request` responses for invalid requests


--------------------------------------------------------------------------

## Version Roadmap

- v1.0 - CRUD API
- v1.1 - Simulated AI Layer
- v1.2 - Provider Abstraction and PromptBuilder
- v1.3 - Validation and Error Handling
- v1.4 - Configuration and Security
- v1.5 - Real AI Provider Integration
- v2.0 - Database Integration with Entity Framework
- v2.1 - Authentication and Authorization
- v2.2 - AI-generated Marketing Captions Improvement
- v2.3 - RAG or Product Knowledge Base
- v2.4 - Docker and Deployment
- v3.0 - Production-ready Release

--------------------------------------------------------------------------

## Current Features

- ASP.NET Core Web API project structure
- Layered architecture
- Jewelry product CRUD
- Swagger API documentation
- Dependency Injection
- In-memory repository
- Simulated AI product description
- Simulated AI stock suggestion
- AI provider abstraction
- PromptBuilder for AI prompts
- Marketing caption endpoint
- Product story endpoint
- Request validation with Data Annotations
- Automatic validation error responses


--------------------------------------------------------------------------

## Technologies Used

- C#
- ASP.NET Core Web API
- Swagger / Swashbuckle
- Dependency Injection
- Data Annotations
- In-memory repository


--------------------------------------------------------------------------

## Project Purpose

The purpose of this project is to create an AI-ready inventory API for jewelry products.

The current version focuses on:

- Backend architecture
- Product inventory management
- Jewelry-specific product data
- Simulated AI services
- AI provider abstraction
- Prompt engineering structure
- Request validation
- Clean separation of responsibilities
- Future integration with real AI models


--------------------------------------------------------------------------

## Notes

- The current version uses an in-memory repository.
- Products are stored only while the API is running.
- If the application stops or restarts, the product list will be reset.
- Future versions will include database persistence using Entity Framework.
- The current AI provider is simulated.
- Future versions will integrate a real AI provider.

--------------------------------------------------------------------------

## Architecture

The project follows a layered architecture:

``text
Controllers → Services → Repositories → Data

