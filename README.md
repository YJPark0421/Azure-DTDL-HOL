# Azure Digital Twin HOL(Hands On Lab) 

## 1️⃣ Overview
### ◽ Scenario of HOL 
    초콜릿 공장의 공정 담당자라고 가정한다.
    공장의 모든 공정작업(Fanning, Roasting, Grinding, Moulding)을 실시간으로 모니터링할 수 있는 대시보드를 구축하기로 했다.
    
    실시간 대시보드를 통해 궁금했던 사항들에 대한 데이터분석을 진행할 수 있었습니다. 
    공정작업 = Roasting 경우, 온도 ≤ 65℃ 경우, ➡ 총 시간 (1일 간)
    공정작업 = Grinding 경우, 도구 = 그라인더 경우, ➡ 평균 진동값 (2분 간) (공장 품질 기준 의거) 
    공정작업 = Grinding 경우, 온도 ＞ 정상 경우, ➡ 모든 이벤트 (5일 간)
---    
   
### ◽ Objective
   - [x] 유의미한 고장원인 분석 도출을 위해 지속적으로 많은 데이터수집이 필요합니다.
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
### ◽ Setup a development environment (Windows 10)
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
### ◽ A Step-By-Step Guide to Azure Digital Twin Test**
> - [Lab 1 Azure Digital Twin 만들기 (5분)](lab1-adt-basic.md)
> - [Lab 2 Azure Digital Twin Explorer 설정 (15분)](lab2-setup-model.md)
> - [Lab 3 ADT 모델 만들기 (10분)](lab3-adt-model.md)
> - [Lab 4 Function으로 이벤트 입력 (25분)](lab4-ingest-event.md)
> - [Lab 5 ADT에서 다른 환경으로 데이터 라우팅 (25분)](lab5-adt-route.md)
> - [Lab 6 Time Series Insights로 Visualize (10분)](lab6-visualize-tsi.md)
---
<br>

## 4️⃣ Reference

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
