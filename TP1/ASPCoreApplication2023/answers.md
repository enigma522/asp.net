1. Modifiez le route pour inclure l’URL Movie/released/2020/03 pour une Action
ByRelease ayant comme arguments (month, year) retournant juste un contenu.

C'est fait dans le fichier MovieController.cs

2. Exécutez. Que remarquez vous? Quel changement à faire pour que le système de routage
prend en charge cet route? Expliquez les différentes éventualités rencontrées.

Si on accede à l'url Movie/released/2020/03 on obtient une erreur 404 car le route n'est pas défini.
Pour que le système de routage prenne en charge cette route il faut ajouter le route dans le fichier Program.cs

les différentes éventualités rencontrées:
	- Il faut mapper le route dans le fichier Program.cs avec le controlleur et l'action correspondante
	-Il faut respecter l'ordre des routes dans le fichier Program.cs


3. Présentez avec des exemples les différents systèmes de routage si vous travaillez avec le
framework de développement web ASP.Net.
1. Convention-based routing: 
	- C'est le système de routage par défaut
	- Il est basé sur le nom du controlleur et le nom de l'action
	- Il est défini dans le fichier Program.cs

2. Attribute routing:
	- Il est basé sur les attributs
	- Il est défini au niveau du controlleur

3. Custom routing:
	- Il est basé sur une classe qui implémente l'interface IRouter

4. On veut à présent passer deux modèles à la vue (Movie et Customer)
• Ajouter une classe Customer (Id, Name)
• On veut passer à la vue un film et une Liste de Clients (Penser à ajouter ViewModel)
• Lister (statique) les enregistrements au niveau du contrôleur (retourner le VM)
• Changer le modèle assigné à la vue
• Récupérer les détails du client par son Id.