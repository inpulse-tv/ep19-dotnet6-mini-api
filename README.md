# Mini API sous .NET 6

Ce dépôt contient le code source relatif à l'épisode X de notre chaîne [inpulse.tv](https://www.inpulse.tv) dédié au développement d'API sous le **Framework .NET 6** de Microsoft :
- [Mini API avec .NET 6 - [1ntro] [#devtech] [ep.X]] (Episode bientôt disponible)

Il contient le code source permettant de réaliser et suivre le tutoriel de la vidéo. Celle-ci propose de réaliser une API sur le même modèle que celle disponible dans notre épisode dédié à **Node.js** : [Fullstack with Node.js  - [NodeJS partie.3]  [1ntro]  [#devtech]  [ep.17]](https://www.youtube.com/watch?v=BJNoyVIdsdw)

Le contenu du dépôt se partage en deux projets :
- Un projet ``mini-api`` proposant une API s'appuyant sur les principes amenés avec **ASP.NET Core MVC** et les nouvelles fonctionnalités de **C# 10**.
- Un projet ``macro-api`` proposant une version plus allégée de l'API ``mini-api`` et plus proche de ce que l'on trouve sous **Node.js**.

Chaque API pourra être consommée par un site web contenu dans le projet [Fullstack with Node.js](https://github.com/inpulse-tv/ep17-Fullstack-with-NodeJS). Le projet propose une application Web basée sur celle disponible depuis l'adresse [sandwichpouletmayonnaise.com](https://sandwichpouletmayonnaise.com/)

Pour comprendre le contenu de chaque projet il vous suffit de suivre les instructions de l'épisode sur notre chaîne [inpulse.tv](https://www.inpulse.tv).

## Installation et exécution

### API

Pour télécharger et lancer les API de l'épisode il vous faut d'abord cloner la solution sur votre poste en lançant la commande suivante dans un terminal Bash ou Powershell depuis le dossier de destination :
```bash
git clone https://github.com/inpulse-tv/epX-dotnet6-mini-api.git
```
Pour exécuter les API il vous faut au préalable une version du [SDK .NET 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) d'intallé sur votre poste. Ensuite il suffit de lancer la commande Shell suivante à la racine du projet d'API qui vous intéresse.
```bash
dotnet run
```
Vous aurez une API consultable en local sur le port 8000 via l'URL : http://localhost:8000.
L'API ne propose qu'un seul endpoint : ``api/entreesdujour``

*N.B* : Il est tout à fait possible d'utiliser [Visual Studio 2022](https://visualstudio.microsoft.com/fr/vs/) pour éditer et exécuter les API.

### Site web

Les sources du site web [sandwichpouletmayonnaise.com](https://sandwichpouletmayonnaise.com/) permettant de consommer les API sont disponibles sur le dépôt Git suivant : https://github.com/inpulse-tv/ep17-Fullstack-with-NodeJS.

Veuillez suivre les instructions d'installation de ce projet pour lancer dans votre navigateur le site via l'adresse : http://localhost:9000 (Ne nous tenez pas rigueur du design 😃 )

### Base de données
Ce projet utilise comme source de données la base **sqlite3** ``pouletmayo.db``, disponible dans le dossier ``sqlite3`` de ce dépôt Git.

Pour savoir comment installer et utiliser la base **sqlite3**, veuillez suivre le tutoriel suivant :- [Premiers pas sur SQL - [SQL partie.1] [n00b] [#data] [ep.3]](https://www.youtube.com/watch?v=_ALsx-CMyy8)

Bonne installation et à bientôt sur [inpulse.tv](https://www.inpulse.tv).

