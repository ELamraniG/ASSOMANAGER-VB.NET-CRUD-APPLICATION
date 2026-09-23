# AssoManager

Application desktop en **VB.NET** pour la gestion d'une association.

AssoManager permet de centraliser la gestion des membres, cotisations, dépenses, événements, documents et utilisateurs à partir d'une application Windows Forms connectée à une base de données Microsoft Access.

## Fonctionnalités

### Gestion des membres

* ajout, modification et suppression des membres
* recherche de membres
* catégories de membres
* suivi du statut actif / inactif
* affichage et impression des listes

### Cotisations

* enregistrement des cotisations
* suivi des paiements des membres
* gestion du montant et de la date
* différents modes de paiement

### Dépenses

* ajout et suivi des dépenses
* catégories de dépenses
* montant et date de dépense
* recherche et consultation des opérations

### Événements

* création et modification des événements
* gestion du lieu et des dates
* gestion des participants
* suivi de la participation aux événements

### Documents

Gestion des documents de l'association :

* statuts
* procès-verbaux
* rapports financiers
* autres documents

L'application permet d'enregistrer le chemin du fichier, son type et sa date d'ajout.

### Utilisateurs et rôles

L'application possède plusieurs niveaux d'accès :

* Administrateur
* Trésorier
* Secrétaire
* Membre

Les droits d'accès permettent de limiter les fonctionnalités disponibles selon le rôle de l'utilisateur.

### Paramètres

* gestion des types d'association
* gestion des catégories
* configuration des informations de l'association
* gestion des utilisateurs

### Recherche et impression

Plusieurs modules proposent :

* recherche par nom ou autre critère
* affichage des données dans des `DataGridView`
* aperçu avant impression
* impression des différentes listes

## Technologies utilisées

* Visual Basic .NET
* .NET Framework
* Windows Forms
* ADO.NET
* OleDb
* Microsoft Access
* Visual Studio

## Base de données

Le projet utilise une base Microsoft Access :

```text
AssoManager.accdb
```

La connexion est réalisée avec :

```text
Microsoft.ACE.OLEDB.12.0
```

Les principales données concernent :

* membres
* utilisateurs
* rôles
* types d'association
* catégories de membres
* cotisations
* dépenses
* catégories de dépenses
* événements
* participants
* documents
* paramètres

## Structure du projet

```text
Assomanager.sln
└── Assomanager/
    ├── Assomanager.vbproj
    ├── AssoManager.accdb
    ├── Module1.vb
    ├── Form1.vb ... Form28.vb
    ├── aides/
    ├── images/
    └── My Project/
```

`Module1.vb` contient notamment la connexion globale à la base de données et les fonctions utilisées pour exécuter les requêtes SQL.

Les différents formulaires correspondent aux modules de gestion de l'application.

La base de données, les images et les pages d'aide sont conservées avec les sources et copiées automatiquement dans le dossier de sortie lors de la compilation. Les dossiers générés par Visual Studio (`bin`, `obj`, fichiers utilisateur et caches) ne sont pas versionnés.

## Installation

### Prérequis

* Windows
* Visual Studio avec support VB.NET
* .NET Framework
* Microsoft Access Database Engine

### Lancer le projet

1. Cloner le dépôt :

```bash
git clone https://github.com/ELamraniG/ASSOMANAGER-VB.NET-CRUD-APPLICATION.git
```

2. Ouvrir :

```text
Assomanager.sln
```

3. Vérifier que le driver `Microsoft.ACE.OLEDB.12.0` est installé.

4. Compiler et lancer le projet avec Visual Studio. Le fichier `AssoManager.accdb` et les ressources nécessaires sont copiés automatiquement dans le dossier de sortie.

## À propos

AssoManager est un projet de développement **VB.NET / Windows Forms** réalisé afin de pratiquer la création d'une application CRUD complète avec interface graphique, base de données Microsoft Access, ADO.NET, gestion des utilisateurs et impression de données.
