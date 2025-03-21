# 🧠 Mental Ease - Your AI Mental Health Companion Chatbot

A compassionate AI chatbot built with **.NET 8** and **Retrieval-Augmented Generation (RAG)** to provide personalized, empathetic responses to mental health-related queries. The goal is to use OpenAI's GPT-4 combined with a custom wellness knowledge base to deliver supportive, meaningful interactions.

> ⚠️ This project is in early development. Core architecture and planning are complete — implementation is in progress.

---

## 🌟 Planned Features

- 🧠 **Context-Aware Chat** powered by GPT-4 and curated wellness content
- 🔍 **RAG Pipeline** using OpenAI Embeddings + Pinecone or Redis
- 📝 **Admin Panel** to upload and tag new resources
- 📚 **Chat History + Sentiment Analysis**
- 🌙 **User Modes** like “Anxious,” “Motivated,” etc. to adjust tone
- 📊 **Dashboard** with anonymized trends and usage insights
- 🔐 **JWT Auth + Role-Based Access Control**

---

## 📸 Screenshots

_Not yet available – UI design is in progress._

---

## 🧰 Planned Tech Stack

### 🔙 Backend
- [x] ASP.NET Core 8 Web API
- [ ] LangChain.NET or custom C# RAG pipeline
- [ ] Entity Framework Core (PostgreSQL or SQLite)
- [ ] Redis or Pinecone for vector search
- [ ] OpenAI API (GPT-4 + Embeddings)
- [ ] AutoMapper + FluentValidation

### 🖥️ Frontend
- [ ] Blazor WebAssembly **or** React + TypeScript
- [ ] Tailwind CSS / Blazorise / Radzen
- [ ] SignalR for real-time updates (optional)

### 🔐 Security
- [ ] ASP.NET Identity + JWT Authentication
- [ ] Admin/User roles
- [ ] OAuth2 login (optional)

### 🧠 AI/ML
- [ ] OpenAI Embeddings (`text-embedding-ada-002`)
- [ ] Pinecone or RedisVector for fast document retrieval
- [ ] ML.NET for sentiment/mood classification (optional)

### 🧪 Testing & DevOps
- [ ] xUnit + Moq for unit and integration tests
- [ ] Swagger/OpenAPI for API docs
- [ ] Docker + Docker Compose for local dev
- [ ] GitHub Actions for CI/CD
- [ ] Deploy to Azure App Service, Render, or Railway

---
