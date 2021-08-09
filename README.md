# Azure Digital Twin HOL(Hands On Lab) 

## 1️⃣ Overview
### ◽ Scenario of HOL 
    실습에서는 여러분이 초콜릿 공장의 라인 운영을 담당하고 있는 기술 전문가라고 가정을 합니다.
    여러분은 공장의 작업자들이 여러 공정들(Fanning, Roasting, Grinding, Moulding)을 모니터링하는 실시간 대시보드를 만들기로 했습니다.
    대시보드에서는 이런 질문들에 대한 답을 찾을 수 있습니다. 
    지난 24시간 동안 Roasting 과정에서 온도가 섭씨 65도 아래로 내려간 시간
    공장의 품질 기준에 맞추기 위한 그라인더의 2분 동안의 평균 진동값
    지난 5일간 몰딩 온도가 정상보다 높아진 모든 이벤트
---    
   
### ◽ Objective
   - [x] 또한 작업에 문제가 생길 때 원인을 분석하기 위하여 모든 데이터를 모아야 합니다
---

### ◽ Development Environment
page_type | languages | products
:------:|:------:|:------:
`Dev`|`C#` `DTDL`|`Azure` `Azure Digital Twin` `Azure Function` `Event Grid` `IoT hub`
---

### ◽ Architecture
![실습 아키텍쳐](images/hol-architecture.png)

---
<br>

## 2️⃣ PreRequirement
> **Setup a development environment** (Windows 10)
> - [.NET Core 3.1](https://dotnet.microsoft.com/download)
> - [Visual Studio Code](https://code.visualstudio.com/)
> - [VS Code C# Extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
> - [VS Code Azure Function Extension](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-azurefunctions)
> - [Git 설치](https://git-scm.com/downloads)
> - [Node.js 설치](https://nodejs.org/ko/download/)
> - [Azure CLI 설치(옵션)](https://docs.microsoft.com/ko-kr/cli/azure/install-azure-cli)
---
<br>

## 3️⃣ Methodology
### ◽ A Step-By-Step Guide to Azure Digital Twin Test

### [Lab 1 Azure Digital Twin 만들기 (5분)](lab1-adt-basic.md)
   ⏬
### [Lab 2 Azure Digital Twin Explorer 설정 (15분)](lab2-setup-model.md)
   ⏬
### [Lab 3 ADT 모델 만들기 (10분)](lab3-adt-model.md)
   ⏬
### [Lab 4 Function으로 이벤트 입력 (25분)](lab4-ingest-event.md)
   ⏬
### [Lab 5 ADT에서 다른 환경으로 데이터 라우팅 (25분)](lab5-adt-route.md)
   ⏬
### [Lab 6 Time Series Insights로 Visualize (10분)](lab6-visualize-tsi.md)
---
<br>

## 4️⃣ Reference

> **GA Announcement**
> - 
---
> **ADT Related Github Page**
> - [Digital Twins Definition Language (DTDL)](https://github.com/Azure/opendigitaltwins-dtdl/blob/master/DTDL/v2/dtdlv2.md)
> - [Azure Digital Twin Demo with Azure Data explorer](https://github.com/ilseokoh/adt-adx-demo)
---
> **Ontology building for Industries**
> - [RealEstateCore, a smart building ontology for digital twins, is now available](https://techcommunity.microsoft.com/t5/internet-of-things/realestatecore-a-smart-building-ontology-for-digital-twins-is/ba-p/1914794)
> - [Smart Cities Ontology for Digital Twins](https://techcommunity.microsoft.com/t5/internet-of-things/smart-cities-ontology-for-digital-twins/ba-p/2166585)
---
> **Domestic Customer Use Case**
> - [두산 풍력발전 디지털 트윈](https://customers.microsoft.com/en-us/story/848311-doosan-manufacturing-azure-digital-twins)
---
> **Deep Dive Yotube Content**
> - [Deep Dive: Azure Digital Twins for smart buildings: A look into WillowTwin solution](https://www.youtube.com/watch?v=Kbv1a_74FC0)
> - [RealEstateCore, a smart building ontology for digital twins](https://www.youtube.com/watch?v=mN0pAvC2pAo&list=RDCMUCL7wy-iy_V76xxPnrIzGOZQ&index=3)
> - [Deep Dive: Azure Digital Twins Updated Capabilities](https://channel9.msdn.com/Shows/Internet-of-Things-Show/Deep-Dive-Azure-Digital-Twins-Updated-Capabilities)
> - [Deep Dive: Integrating 3D Models and IoT data with iTwin and Azure Digital Twins](https://channel9.msdn.com/Shows/Internet-of-Things-Show/Deep-Dive-Integrating-3D-Models-and-IoT-data-with-iTwin-and-Azure-Digital-Twins?term=Bentley&lang-en=true)
