1. Modifiez le route pour inclure l�URL Movie/released/2020/03 pour une Action
ByRelease ayant comme arguments (month, year) retournant juste un contenu.

C'est fait dans le fichier MovieController.cs

2. Ex�cutez. Que remarquez vous? Quel changement � faire pour que le syst�me de routage
prend en charge cet route? Expliquez les diff�rentes �ventualit�s rencontr�es.

Si on accede � l'url Movie/released/2020/03 on obtient une erreur 404 car le route n'est pas d�fini.
Pour que le syst�me de routage prenne en charge cette route il faut ajouter le route dans le fichier Program.cs

les diff�rentes �ventualit�s rencontr�es:
	- Il faut mapper le route dans le fichier Program.cs avec le controlleur et l'action correspondante
	-Il faut respecter l'ordre des routes dans le fichier Program.cs


3. Pr�sentez avec des exemples les diff�rents syst�mes de routage si vous travaillez avec le
framework de d�veloppement web ASP.Net.
1. Convention-based routing: 
	- C'est le syst�me de routage par d�faut
	- Il est bas� sur le nom du controlleur et le nom de l'action
	- Il est d�fini dans le fichier Program.cs

2. Attribute routing:
	- Il est bas� sur les attributs
	- Il est d�fini au niveau du controlleur

3. Custom routing:
	- Il est bas� sur une classe qui impl�mente l'interface IRouter

4. On veut � pr�sent passer deux mod�les � la vue (Movie et Customer)
� Ajouter une classe Customer (Id, Name)
� On veut passer � la vue un film et une Liste de Clients (Penser � ajouter ViewModel)
� Lister (statique) les enregistrements au niveau du contr�leur (retourner le VM)
� Changer le mod�le assign� � la vue
� R�cup�rer les d�tails du client par son Id.