# I - CLASSE ABSTRAITE

1 -- Une classe abstraite ne peut être instancier avec le mot clé "new"
2 -- Une classe abstraite ne possède pas d'implémentation dans ses méthoses
3 -- Une classe contenant au moins une méthode abstraire doit automatiquement devenir abstraite
4 -- Une classe abstraire n'est pas forcé d'avoir des méthodes abstraites

# II LES STRUCTURES

1- La différence entre une structure et une classe
*Les classes sont les types références et les types références ne possèdent pas de valeurs mais une référence de l'objet en mémoire*
*Tandis que les structures sont types valeurs et contient directement la valeur de l'objet en mémoire*
*L'autre différence est qu'une structure bien qu'étant un objet ne peut être hérité. donc en résumé une structure n'hérite pas du comportement d'une autre structure excepté le type de base Object*
*Une structure peut avoir un constructeur à l'exception du constructeur par défaut qui est interdit*



# III - DESIGN PATTERNS

# A - CREATION

1 -- Singleton
*Le design pattern singleton est caractérisé par le fait que son constructeur ne doit pas être instanciable dépuis l'extérieur,il doit être privé et enfin on doit pouvoir l'initialiser une et unique fois.*
*le design pattern singleton garanti qu'il y aura une seule instance de la classe malgré le fait que deux variables pointent vers la même instance.*
*Le design pattern singleton est déjà automatisé dans les conteneurs d'injection de dépendance donc il nous servira pas trop mais il bien de savoir l'implémenter*
*en plus il viol le premier principe solid qui est l'unique responsabilité pour chaque classe

2 -- Factory

*Le design pattern Factory (ou fabrique) est un design pattern de création qui permet de déléguer la création d'objets à une classe dédiée, appelée "fabrique".*
*L'objectif principal du pattern Factory est d'abstraire le processus de création d'objets et de fournir une interface commune pour créer différentes implémentations d'une classe*


3 -- Différence entre Abstract Factory et Factory Method
*Abstract factory renvoit une famille de produits tandis que Factor Method renvoi un unique produit*


4 -- 
*Il est possible d'empêcher une classe d'être dérivée grâce au mot-clé sealed.*
*Le garbage collector est le mécanisme permettant de libérer la mémoire allouée sur le tas managé qui n'est plus référencée dans une application.*
*Le mot-clé yield permet de créer des énumérateurs facilement et participe au mécanisme d'exécution différée.*