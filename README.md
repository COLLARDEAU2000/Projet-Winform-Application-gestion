# mission3-bts-sio-slam
Description du laboratoire GSB Galaxy Swiss Bourdin
Le secteur d'activité
L’industrie pharmaceutique est un secteur très lucratif dans lequel le mouvement de fusion acquisition
est très fort. Les regroupements de laboratoires ces dernières années ont donné naissance à des
entités gigantesques au sein desquelles le travail est longtemps resté organisé selon les anciennes
structures.
Des déboires divers récents autour de médicaments ou molécules ayant entraîné des complications
médicales ont fait s'élever des voix contre une partie de l'activité des laboratoires : la visite médicale,
réputée être le lieu d'arrangements entre l'industrie et les praticiens, et tout du moins un terrain
d'influence opaque.
L'entreprise
Le laboratoire GSB est issu de la fusion entre le géant américain Galaxy (spécialisé dans le secteur
des maladies virales dont le SIDA et les hépatites) et le conglomérat européen Swiss Bourdin
(travaillant sur des médicaments plus conventionnels), lui même déjà union de trois petits laboratoires.
En 2009, les deux géants pharmaceutiques ont uni leurs forces pour créer un leader de ce secteur
industriel. L'entité Galaxy Swiss Bourdin Europe a établi son siège administratif à Paris.
Le siège social de la multinationale est situé à Philadelphie, Pennsylvanie, aux Etats-Unis.
Réorganisation
Une conséquence de cette fusion, est la recherche d'une optimisation de l’activité du groupe ainsi
constitué en réalisant des économies d’échelle dans la production et la distribution des médicaments
(en passant par une nécessaire restructuration et vague de licenciement), tout en prenant le meilleur
des deux laboratoires sur les produits concurrents.
L'entreprise compte 480 visiteurs médicaux en France métropolitaine (Corse comprise), et 60 dans les
départements et territoires d'outre-mer. Les territoires sont répartis en 6 secteurs géographiques
(Paris-Centre, Sud, Nord, Ouest, Est, DTOM Caraïbes-Amériques, DTOM Asie-Afrique).

Description du cas
Nom : gestion des rapports
Acteur : la secrétaire
Pré-condition : la secrétaire dispose des rapports de visites envoyés par les visiteurs
Scénario nominal
1. La secrétaire demande à ajouter un rapport
2. Le système retourne un formulaire permettant d’ajouter un rapport, avec une liste de
visiteurs disponibles, des listes permettant d’obtenir un médecin, une liste de famille de
médicaments et des champs de saisie
3. La secrétaire sélectionne les informations, effectue les saisies et valide
4. Le système enregistre les informations
Extensions
5.1 La secrétaire demande à modifier un rapport
5.1.1 Le système retourne un formulaire de recherche du rapport avec une sélection de
dates et de visiteurs
5.1.2 La secrétaire sélectionne la date et le visiteur
5.1.3 Le système retourne les rapports concernant le visiteur et la date
5.1.4 La secrétaire modifie des informations
5.1.5 Le système enregistre ces modifications
5.2 La secrétaire demande à visualiser des rapports
5.2.1 le système retourne un formulaire avec des listes de filtres
5.2.2 La secrétaire sélectionne les informations dans les listes
5.2.3 Le système génère un fichier XML avec les différents rapports concernés
Scénarios alternatifs
4.1 Les informations ne sont pas valides. Le système en informe la secrétaire. Retour à 3
5.1.5.1 Les modifications ne sont pas cohérentes, le système retourne un message d’erreurs
sur les informations incohérentes. Retour à 5.1.4

