# Azure Digital Twin HOL(Hands On Lab) 

## HOL
   - 실습에서는 여러분이 초콜릿 공장의 라인 운영을 담당하고 있는 기술 전문가라고 가정을 합니다.
   -  여러분은 공장의 작업자들이 여러 공정들(Fanning, Roasting, Grinding, Moulding)을 모니터링하는 실시간 대시보드를 만들기로 했습니다.
   -  대시보드에서는 이런 질문들에 대한 답을 찾을 수 있습니다. 
   -  지난 24시간 동안 Roasting 과정에서 온도가 섭씨 65도 아래로 내려간 시간
   -  공장의 품질 기준에 맞추기 위한 그라인더의 2분 동안의 평균 진동값
   -  지난 5일간 몰딩 온도가 정상보다 높아진 모든 이벤트 

![아키텍쳐](images/chocofactoryprocess.png)

> 또한 작업에 문제가 생길 때 원인을 분석하기 위하여 모든 데이터를 모아야 합니다. 

## Azure Digital Twin 개요 

[디지털 트윈을 활용한 IoT 솔루션 구축.pdf](./adt-intro.pdf)

## Overview

![실습 아키텍쳐](images/hol-architecture.png)

## PreRqu사전준비 내용 
1. Azure 구독: 구독이 없으면 [체험계정 만들기](https://azure.microsoft.com/ko-kr/free/)
1. 실습용 노트북 준비: Windows 10 PC (또는 Linux / Mac 가능) + 개발환경 설치 
    * [.NET Core 3.1](https://dotnet.microsoft.com/download) 설치
    * [Visual Studio Code](https://code.visualstudio.com/) 설치
    * [VS Code C# Extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
    * [VS Code Azure Function Extension](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-azurefunctions)
    * [Git 설치](https://git-scm.com/downloads)
    * [Node.js 설치](https://nodejs.org/ko/download/)
    * [Azure CLI 설치(옵션)](https://docs.microsoft.com/ko-kr/cli/azure/install-azure-cli)

## [Lab 1 Azure Digital Twin 만들기 (5분)](lab1-adt-basic.md)

## [Lab 2 Azure Digital Twin Explorer 설정 (15분)](lab2-setup-model.md)

## [Lab 3 ADT 모델 만들기 (10분)](lab3-adt-model.md)

## [Lab 4 Function으로 이벤트 입력 (25분)](lab4-ingest-event.md)

## [Lab 5 ADT에서 다른 환경으로 데이터 라우팅 (25분)](lab5-adt-route.md)

## [Lab 6 Time Series Insights로 Visualize (10분)](lab6-visualize-tsi.md)


## 🌐Reference

> **GA Announcement**
> - [Azure Digital Twins now generally available: Create IoT solutions that model the real world](https://azure.microsoft.com/en-us/blog/azure-digital-twins-now-generally-available-create-iot-solutions-that-model-the-real-world/)
> - [Bring your Digital Twins solutions to production with Azure](https://channel9.msdn.com/Shows/Internet-of-Things-Show/Bring-your-Digital-Twins-solutions-to-production-with-Azure)
---
> **Domestic Case**
> - [두산 풍력발전 디지털 트윈](https://customers.microsoft.com/en-us/story/848311-doosan-manufacturing-azure-digital-twins)
---
> **Product Page**
> - [Azure Digital Twins](https://azure.microsoft.com/en-us/services/digital-twins/)
> - [Azure Digital Twins Preview Documentation](https://docs.microsoft.com/en-us/azure/digital-twins/)
> - [Azure IoT Developer Certification](https://docs.microsoft.com/en-us/learn/certifications/azure-iot-developer-specialty)
---
> **IoT Shows**
> - [RealEstateCore, a smart building ontology for digital twins](https://channel9.msdn.com/Shows/Internet-of-Things-Show/RealEstateCore-a-smart-building-ontology-for-digital-twins)
> - [Azure Digital Twins New Capabilities](https://channel9.msdn.com/Shows/Internet-of-Things-Show/Azure-Digital-Twins-Preview-New-Capabilities?term=Azure%20Digital%20Twins&lang-en=true)
> - [Deep Dive: Azure Digital Twins Updated Capabilities](https://channel9.msdn.com/Shows/Internet-of-Things-Show/Deep-Dive-Azure-Digital-Twins-Updated-Capabilities)
> - [Deep Dive: Integrating 3D Models and IoT data with iTwin and Azure Digital Twins](https://channel9.msdn.com/Shows/Internet-of-Things-Show/Deep-Dive-Integrating-3D-Models-and-IoT-data-with-iTwin-and-Azure-Digital-Twins?term=Bentley&lang-en=true)
> - [Bentley iTwin and iModel.js Integration with Azure Digital Twins](https://channel9.msdn.com/Shows/Internet-of-Things-Show/Bentley-iTwin-and-iModeljs-Integration-with-Azure-Digital-Twins?term=Bentley&lang-en=true)
> - [Ansys Twin Builder Integration with Azure Digital Twins](https://channel9.msdn.com/Shows/Internet-of-Things-Show/Ansys-Twin-Builder-Integration-with-Azure-Digital-Twins?term=ANSYS&lang-en=true)
---
> **Customer Stories**
> - [Brookfield sets a new standard for innovation in real estate with WillowTwin and Azure Digital Twins](https://customers.microsoft.com/en-us/story/855907-brookfield-properties-professional-services-azure)
> - [GE Aviation’s Digital Group builds a holistic source of truth with Azure Digital Twins](https://customers.microsoft.com/en-us/story/846315-ge-aviation-manufacturing-azure)
> - [Bosch expands energy efficiency offerings with connected building solution using Azure Digital Twins](https://customers.microsoft.com/en-us/story/790031-bosch-building-technologies-smart-spaces-azure) 
> - [Bentley Systems helps close the global productivity gap with Azure Digital Twins](https://customers.microsoft.com/en-us/story/806028-bentley-systems-partner-professional-services-azure)
> - [Engineering simulation giant Ansys unlocks value and opportunity with Azure Digital Twins](https://customers.microsoft.com/en-us/story/795283-ansys-partner-professional-services-azure)
> - [Steelcase Demonstrates the Smart and Connected Workplace with New IoT-Powered Solutions](https://customers.microsoft.com/en-us/story/steelcase-manufacturing-azureiot-en)
> - [PCL Construction uses IoT with Azure to revolutionize the construction industry](https://customers.microsoft.com/en-us/story/pcl-construction-professional-services-azure)
---
> **Ignite On-Demand Content**
> > Azure IoT services, roadmap and vision: from connected assets to connected environments
> > > Sam George, Microsoft Ignite
> > > - [Azure IoT services, roadmap and vision: from connected assets to connected environments](https://myignite.microsoft.com/sessions/8c90945c-eec6-43ed-b16a-3adf3c2ba37a)
---
> **Ask the Expert: Azure IoT: From connected assets to connected environments with Digital Twins**
> > Christian Schormann, Ines Khelifi, Paul DeCarlo, Microsoft Ignite
> > - [Ask the Expert: Azure IoT: From connected assets to connected environments with Digital Twins](https://myignite.microsoft.com/sessions/aec5687c-d153-47e7-9dc5-5f2e3f536f0c)
