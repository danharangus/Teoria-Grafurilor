-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Gazdă: 127.0.0.1
-- Timp de generare: mai 24, 2021 la 10:44 PM
-- Versiune server: 10.1.40-MariaDB
-- Versiune PHP: 7.3.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Bază de date: `atestat`
--

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `conturi`
--

CREATE TABLE `conturi` (
  `id` int(11) NOT NULL,
  `utilizator` text NOT NULL,
  `parola` text NOT NULL,
  `mail` text NOT NULL,
  `tip` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Eliminarea datelor din tabel `conturi`
--

INSERT INTO `conturi` (`id`, `utilizator`, `parola`, `mail`, `tip`) VALUES
(1, 'admin', 'admin', 'admin@yahoo.com', 'admin'),
(11, 'Popescu Alexandru', 'test', 'popescu@yahoo.com', 'elev'),
(12, 'Alexandrescu Gheroghe', 'test', 'alex@yahoo.com', 'elev'),
(13, 'Ionescu Vasile', 'test', 'ionescuv@yahoo.com', 'elev'),
(14, 'Grigorescu Ionel', 'test', 'grigorescu@yahoo.com', 'elev');

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `intrebari`
--

CREATE TABLE `intrebari` (
  `id` int(11) NOT NULL,
  `intrebare` text NOT NULL,
  `var_a` text NOT NULL,
  `var_b` text NOT NULL,
  `var_c` text NOT NULL,
  `corect` text NOT NULL,
  `lectie` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Eliminarea datelor din tabel `intrebari`
--

INSERT INTO `intrebari` (`id`, `intrebare`, `var_a`, `var_b`, `var_c`, `corect`, `lectie`) VALUES
(1, 'Intr-un graf neorientat cu 10 noduri, fiecare nod are gradul 2. Care este numarul maxim de componente conexe din care poate fi format graful?', '6', '3', '5', 'b', 'Conexitate'),
(2, 'Care este numarul maxim de arce într-un graf orientat cu 10 noduri?', '100', '45', '90', 'c', 'Grafuri orientate'),
(3, 'Intr-un graf neorientat cu 10 noduri, exista muchii între nodurile i, j care au proprietatea ca abs(i-j) > 0. Numarul de valori egale cu 1 din matricea de adiacenta este:', '91', '100', '90', 'c', 'GN - Reprezentare'),
(4, 'Care este numarul de grafuri neorientate cu 5 varfuri cu proprietatea ca varfurile 1 si 2 respectiv 1 si 3 nu sunt adiacente?', '2^8', '2^6', '32', 'a', 'Grafuri neorientate - Introducere'),
(5, 'Se considera un graf orientat cu 8 noduri si 2 componente tare conexe, o componenta cu 4 noduri si o componenta cu 3 noduri. Numarul maxim de arce care pot exista in graf este:', '14', '30', '25', 'b', 'GO - Tare conexitate'),
(6, 'Se considera un graf neorientat cu 12 noduri si 3 componentet conexe. Numarul maxim de muchii care pot exista in graf este:', '45', '55', '15', 'a', ''),
(7, 'Fiind dat un graf orientat cu 10 noduri si fara circuite atunci numarul maxim de arce pe care le poate avea graful este:', '110', '55', '45', 'c', ''),
(8, 'Se considera un graf orientat cu 10 noduri si 2 componente conexe, o componenta cu 7 noduri si una cu 3 noduri. Numarul minim de muchii care pot exista in graf este:', '10', '8', '16', 'b', ''),
(9, 'Matricea de adiacenta a unui graf neorientat cu 20 de noduri, fara varfuri izolate, contine 24 de valori egale cu 1. Care este numarul minim de componente conexe ale grafului?', '8', '6', '1', 'a', ''),
(10, 'Se considera urmatorul arbore dat prin vectorul de tati: T= (8, 9, 9, 9, 4, 4, 5, 5, 0, 5). Cate noduri pot fi alese ca radacina astfel incat inaltimea arborelui sa fie minima?', '3', '2', '5', 'c', '');

-- --------------------------------------------------------

--
-- Structură tabel pentru tabel `lectii`
--

CREATE TABLE `lectii` (
  `id` int(11) NOT NULL,
  `titlu` text NOT NULL,
  `continut` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Eliminarea datelor din tabel `lectii`
--

INSERT INTO `lectii` (`id`, `titlu`, `continut`) VALUES
(28, 'Grafuri neorientate - Introducere', '-> Grafurile au numeroase aplicatii in diverse domenii: proiectarea circuitelor electrice, determinarea celui mai scurt drum dintre doua localitati, retelele sociale (ex. Facebook), etc.\r\n	-> Primele rezultate legate de teoria grafurilor au fost obtinute de matematicianul Leonard Euler, cel care a studiat Problema podurilor din Königsberg, din imaginea de mai jos. A demonstrat ca problema nu are solutie, iar in onoarea lui o categorie speciala de grafuri au fost numite grafuri euleriene.\r\n	-> Definitie: Se numeste graf neorientat o pereche ordonata de multimi G=(X,U), unde:\r\n		- X este o multime finita si nevida de elemente numite varfuri sau noduri;\r\n		- U este o multime finita de submultimi cu doua elemente din X, numite muchii.\r\n	-> Vom nota in continuare varfurile cu valori intre 1 si n – unde n este numaru de varfuri din graf, iar muchiile cu [x,y] sau (x,y), unde x si y sunt varfuri si se numesc extremitatile muchiei.\r\n	-> Un vecin al unui varf x este orice varf y cu proprietatea ca exista muchia [x,y].\r\n	-> Doua varfuri intre care exista muchie se numesc adiacente.\r\n	-> Doua muchii sunt incidente daca au o o extremitate comuna. Un varf este incident cu o muchie daca varful este extremitate a acelei muchii.\r\n	-> Multimea muchiilor are proprietatea de simetrie: daca [x,y] este muchie, atunci si [y,x] este muchie.\r\n	-> Conform definitiei:\r\n		- intr-un graf neorientat nu exista muchie de la un varf la el insusi;\r\n		- intre doua varfuri distincte exista cel mult o muchie.\r\n'),
(29, 'GN - Gradul unui varf', '-> Definitie Intr-un graf neorientat se numeste grad al unui varf numarul de varful adiacente cu acesta (sau numarul de muchii incidente cu acesta). Gradul unui varf x se noteaza d(x) (degree).\r\n\r\n	-> Observatii:\r\n		- un varf cu gradul 0 se numeste izolat. In graful de mai sus, varful 6 este izolat.\r\n		- un varf cu gradul 1 se numeste terminal. In graful de mai sus, varful 9 este varf terminal.\r\n		- gradul maxim al unui varf intr-un graf cu n varfuri este n-1.\r\n	-> Teorema: Intr-un graf neorientat, suma gradelor tuturor varfurilor este dublul numarului de muchii.\r\n	-> Consecinte:\r\n		- Suma gradelor tuturor varfurilor este numar par.\r\n		- Intr-un graf neorientat, numarul de varfuri de grad impar este intotdeauna par.\r\n\r\n'),
(30, 'GN - Reprezentare', 'Matricea de adiacenta\r\n	Pentru un graf neorientat G=(X,U) cu n varfuri, matricea de adiacenta este o matrice cu n linii si n coloane si elemente din {0,1}, cu: Ai,j={1 daca [i,j] ? U sau 0, daca [i,j] ? U}\r\n	Exemplu: Pentru graful neorientat din imagine avem urmatoarea matrice de adiacenta:\r\n0 1 0 0 1\r\n1 0 0 0 1\r\n0 0 0 0 0\r\n0 0 0 0 1\r\n1 1 0 1 0\r\n	Observatii:\r\n	-> matricea de adiacenta este simetrica fata de diagonala principala;\r\n	-> elementele de pe diagonala principala sunt 0;\r\n	-> gradul unui varf x este egal cu numarul de elemente 1 de pe linia (sau coloana) x;\r\n	-> suma tuturor elementelor din matricea de adiacenta a unui graf neorientat este egala cu dublul numarului de muchii din graf.\r\n\r\n\r\nLista de muchii\r\n	-> Lista de muchii a unui graf neorientat reprezinta o multime ce contine toate muchiile din graf.\r\n\r\nPentru graful alaturat, lista de muchii este: U={[1,2],[1,5],[2,5],[4,5]}\r\n\r\nPentru reprezentarea in memorie putem folosi:\r\n	 -> un tablou unidimensional cu elemente de tip struct {int I, J;}\r\n	-> doua tablouri unidimensionale cu elemente de tip int\r\n	-> o lista alocata dinamic\r\n\r\n\r\nListe de adiacente (de vecini)\r\n	 -> Pentru un graf neorientat cu G=(X,U) se va memora numarul de varfuri n si apoi, pentru fiecare varf x, lista varfurilor adiacente cu x, adica a varfurilor y cu proprietatea ca exista muchia [x,y].\r\n\r\nPentru graful alaturat, listele de adiacenta sunt:\r\n1: 2 5\r\n2: 1 5\r\n3: vida\r\n4: 5\r\n5: 1 2 4\r\nLa reprezentarea in memorie trebui avut in vedere ca dimensiunile listelor de vecini sunt variabile. De aceea, este neeficienta utilizarea unor tablouri alocate static. Astfel, putem folosi:\r\n\r\n	-> un sir de n tablouri unidimensionale alocate dinamic;\r\n	-> un sir de n vectori din STL;\r\n	-> un sir de n liste simplu (dublu) inlantuite alocate dinamic.\r\n'),
(31, 'GN - Graf partial. Subgraf. Graf complementar', '	-> Definitie. Fie G=(X, U) un graf neorientat. Se numeste graf partial al grafului G, graful neorientat G1=(X, U1), unde U1 apartine lui U.\r\n\r\n	Din definitie rezulta:\r\n	-> Un graf partial al unui graf neorientat G=(V,U), are aceeasi multime de varfuri ca si G, iar multimea muchiilor este o submultime a lui U sau chiar U.\r\n	->Fie G=(X, U) un graf neorientat. Un graf partial al grafului G se obtine pastrand varfurile si\r\neliminand eventual niste muchii (se pot elimina si toate muchiile sau chiar nici una).\r\n\r\n\r\n	-> Definitie. Fie G=(X, U) un graf orientat. Se numeste subgraf al grafului G graful neorientat G1=(X1,U1) unde X1 apartine lui X iar U1 contine toate arcele din U care au extremitatile in X1.\r\n\r\n	Din definitie rezulta:	\r\n	-> Fie G=(X,U) un graf orientat. Un subgraf al grafului G, se obtine stergand eventual anumite\r\nvarfuri si odata cu acestea si muchiile care le admit ca extremitate (nu se pot sterge toate varfurile deoarece s-ar obtine un graf cu multimea varfurilor vida).\r\n\r\n\r\n	-> Definitie. Fie G=(X, U) un graf neorientat. Se numeste graf complementar al grafului G, graful neorientat G1=(X, U1), cu proprietatea ca doua varfuri x si y sunt adiacente in G1 daca si numai daca nu sunt adiacente in G.\r\n\r\n->  Observatii: Un graf neorientat oarecare poate avea mai multe grafuri partiale si subgrafuri, dar un unic graf complementar. Mai precis:\r\n\r\n	-> Teorema: Fie G un graf neorientat cu n varfuri si m muchii. Atunci:\r\n\r\n	-> graful G admite 2^m grafuri partiale;\r\n	-> graful G admite 2^(n–1) subgrafuri;\r\n	-> graful G admite un unic graf complementar.\r\n	\r\n	Justificare:\r\n	-> Sa ne amintim ca o multime cu a elemente are 2a submultimi, inclusiv multimea vida si multimea initiala. Atunci:\r\n\r\n	-> orice submultime a multimii muchiilor induce un graf partial. Sunt m muchii, deci 2^m submultimi, deci 2m grafuri partiale.\r\n	-> orice submultime a multimii varfuri induce un subgraf, mai putin multimea vida – un graf nu poate avea 0 varfuri. Similar ca mai sus, sunt 2^(n–1) subgrafuri.\r\n	-> graful complementar este unic determinat, deoarece complementara unei submultimi fata de o multime data este unic determinata.\r\n'),
(32, 'GN - Graf nul. Graf complet. Graf regulat. Graf bipartit', '	-> Definitie: Un graf neorientat se numeste graf nul daca multimea muchiilor este vida.\r\n	\r\n	->Intr-un graf nul toate varfurile sunt izolate.\r\n\r\n\r\n	->Definitie. Fie G=(X, U) un graf neorientat. Graful G se numeste graf complet daca oricare doua varfuri distincte ale sale sunt adiacente. Un graf complet cu n varfuri se noteaza Kn.\r\n\r\n	-> Intr-un graf complet cu n varfuri sunt C(2, n) = (n?(n?1))/2 muchii si fiecare varf are gradul n-1.\r\n\r\n	->Propozitie:  Sunt 2^((n?(n?1))/2) grafuri neorientate distincte cu n varfuri.\r\n\r\n	-> Definitie:  Un graf in care toate nodurile au acelasi grad se numeste graf regulat.\r\n\r\n\r\n	-> Definitie: Un graf G=(X, U) se numeste graf bipartit daca exista doua multimi nevide A si B astfel incat X=A ? B, A ? B = ? si orice muchie u a lui G are o extremitate in A iar cealalta in B. Multimile A si B formeaza o partitie a lui X.\r\n\r\n	-> Definitie: Un graf bipartit G=(X,U) se numeste bipartit complet daca pentru oricare doua varfuri x apartinand lui A si y apartinand lui B, exista in graf muchia [x,y]; adica [x,y] apartine lui U.\r\n\r\n\r\n'),
(33, 'GN - Lant. Ciclu', '	-> Definitie: Se numeste lant o succesiune de varfuri L=[x1,x2,...xk] cu proprietatea ca oricare doua varfuri consecutive sunt adiacente.\r\n\r\n	-> Varfurile x1 si xk se numesc extremitatile lantului. Numarul k-1 se numeste lungimea lantului si este numarul de muchii din care este format.\r\n\r\n	-> Lantul care contine numai varfuri distincte, doua cate doua, este lant elementar.\r\n\r\n	-> Lantul care contine numai muchii distincte este lant simplu. Daca muchiile unui lant nu sunt distincte se numeste lant compus.\r\n\r\n	-> Definitie: Se numeste ciclu un lant simplu in care primul varf este identic cu ultimul. Daca toate varfurile sunt distincte, mai putin primul si ultimul, se numeste ciclu elementar.\r\n\r\n	-> Lungimea unui ciclu este egala cu numarul de muchii din ciclu. Lungimea minima a unui ciclu este 3.\r\n\r\n	-> Un ciclu se numeste par daca lungimea sa este para, respectiv impar in caz contrar.\r\n\r\n	-> Un graf neorientat care nu contine niciun ciclu se numeste aciclic.\r\n\r\n	Exemple: In graful din imagine:\r\n	->  [2,4,1,3,5,7] este un lant elementar\r\n	->  [3,5,7,6,5,1] este un lant neelementar, dar simplu\r\n	->  [2,3,5,7,6,5,3,1] este un lant compus\r\n	->  [1,5,3,2,4,1] este un ciclu elementar\r\n	->  [1,3,5,7,6,5,1] este un ciclu neelementar\r\n'),
(34, 'GN - Graf conex. Componente conexe', '	-> Definitie: Un graf neorientat se numeste graf conex daca pentru oricare doua varfuri x si y diferite ale sale, exista cel putin un lant care le leaga, adica x este extremitatea initiala si y este extremitatea finala.\r\n\r\n	-> Un graf cu un singur nod este, prin definitie, conex.\r\n\r\n	-> Definitie: Se numeste componenta conexa a unui graf G=(X,U) un subgraf H=(Y, V), conex, al lui G care are proprietatea ca nu exista nici un lant in G care sa lege un varf din Y cu un varf din X – Y.\r\n\r\n	-> Subgraful H este conex si maximal cu aceasta proprietate (daca s-ar mai adauga un varf nu ar mai fi conex.)\r\n\r\n	-> Un graf este conex daca admite o singura componenta conexa.\r\n\r\n	-> Definitie: Un graf este biconex daca este conex si pentru orice varf eliminat subgraful generat isi pastreaza proprietatea de conexitate.\r\n'),
(35, 'GN - Arbore. Padure', '	-> Definitie: Se numeste arbore un graf conex si aciclic.\r\n\r\n	-> Observatii:\r\n	-  Un arbore cu n varfuri are n-1 muchii.\r\n	-  Un arbore este un graf conex si minimal cu aceasta proprietate; daca s-ar mai elimina o muchie, graful nu ar mai fi conex.\r\n	- Un arbore este un graf aciclic si maximal cu aceasta proprietate; daca s-ar mai adauga o muchie, s-ar obtine un ciclu.\r\n	- Un graf partial care este arbore se numeste arbore partial.\r\n\r\n	-> Un graf care nu contine cicluri se mai numeste padure. Intr-o padure fiecare componenta conexa este arbore.\r\n'),
(36, 'GN - Graf hamiltonian. Graf eulerian', '	-> Definitie: Se numeste graf hamiltonian un graf care contine un ciclu hamiltonian. Se numeste ciclu hamiltonian un ciclu elementar care contine toate varfurile grafului.\r\n\r\n	-> Teorema: Un G un graf neorientat. Daca are n?3 varfuri si gradul oricarui varf verifica inegalitatea d(x)>=n/2 atunci G este hamiltonian.\r\n\r\n\r\n	-> Definitie: Se numeste graf eulerian un graf care contine un ciclu eulerian. Se numeste ciclu eulerian un ciclu care contine toate muchiile grafului.\r\n\r\n	-> Teorema: Un graf G = (X,U), fara varfuri izolate, este eulerian daca si numai daca este conex si\r\ngradele tuturor varfurilor sale sunt numere pare.\r\n\r\n'),
(37, 'Grafuri orientate - Introducere', '	-> Definitie. Se numeste graf orientat sau digraf o pereche ordonata de multimi notata G=(V, U), unde:\r\n		-V este o multime finita si nevida ale carei elemente se numesc noduri sau varfuri;\r\n		- U este o multime de perechi ordonate de elemente distincte din V ale carei elemente se numesc arce.\r\n\r\n\r\n	->Notiuni\r\n	- extremitati ale unui arc: pentru arcul u=(x,y), se numesc extremitati ale sale nodurile x si y;\r\n	- x se numeste extremitate initiala;\r\n	- y se numeste extremitate finala;\r\n	- y se numeste succesor al lui x;\r\n	- x se numeste predecesor al lui y.\r\n	- varfuri adiacente: daca intr-un graf exista arcul u=(x,y) (sau u=(y,x), sau amandoua), se spune despre nodurile x si y ca sunt adiacente;\r\n	- incidenta:\r\n		- daca u1 si u2 sunt doua arce ale aceluiasi graf, se numesc incidente daca au o extremitate comuna. Exemplu: u1=(x,y) si u2=(y,z) sunt incidente;\r\n		-daca u1=(x,y) este un arc intr-un graf, se spune despre el si nodul x, sau nodul y, ca sunt incidente.\r\n\r\n\r\n	-> Definitii alternative\r\n\r\n	-> Definitie. Se numeste graf orientat o pereche ordonata de multimi notata G=(V, U), unde:\r\n\r\n	- V este o multime, finita si nevida, ale carei elemente se numesc noduri sau varfuri;\r\n	- U este o multime, de perechi ordonate de elemente din V, ale carei elemente se numesc arce.\r\n	Aceasta definitie difera de prima definitie prin faptul ca acum nu se mai spune despre extremitatile unui arc ca trebuie sa fie distincte. In baza acestei definitii, sunt permise si arce de genul: u=(x,x) unde x?V; aceste arce se numesc bucle.\r\n\r\n\r\nDefinitie. Se numeste graf orientat o pereche ordonata de multimi notata G=(V, U), unde:\r\n\r\nV este o multime, finita si nevida, ale carei elemente se numesc noduri sau varfuri;\r\nU este o familie de perechi ordonate de elemente din V, numita familia de arce.\r\nAceasta definitie difera de cea anterioara prin faptul ca acum nu numai ca se admit bucle, dar se admit si mai multe arce identice.\r\n\r\n\r\nObservatie. Daca intr-un graf orientat numarul arcelor identice nu depaseste numarul p, atunci se numeste p-graf. Graful de mai sus este un 3-graf.\r\n'),
(38, 'GO - Grade', '	-> Definitie. Fie G=(V, U) un graf orientat si x un nod al sau.\r\n\r\n	->  Se numeste grad exterior al nodului x, numarul arcelor de forma (x,y) (adica numarul arcelor care ies din x), notat d+(x).\r\n	-> Se numeste grad interior al nodului x, numarul arcelor de forma (y,x) (adica numarul arcelor care intra in x), notat d-(x).\r\n\r\n        -> Pentru graful alaturat:\r\n           d+(2)=2\r\n           d-(2)=3\r\n\r\n	->  Teorema: Intr-un graf orientat, suma gradelor exterioare a tuturor nodurilor este egala cu suma gradelor interioare a tuturor nodurilor si cu numarul de arce.\r\n\r\n	-> Un nod x se numeste izolat daca d+(x)=d-(x)=0 (are gradul interior si gradul exterior egal cu 0).\r\n'),
(39, 'GO - Reprezentare', '-> Fie G=(V,U) un graf orientat cu n noduri, in care nu exista mai multe arce de la un nod la altul. 	-> Matricea de adiacenta a grafului este o matrice cu n linii si n coloane si elemente 0 sau 1, astfel:\r\n 	- Ai,j=1 daca exista arcul (i,j)\r\n	- Ai,j=0 daca exista nu arcul (i,j)\r\nPentru graful alaturat, matricea de adiacenta este:\r\n\r\n0 0 0 0 0 1\r\n1 0 0 1 0 0\r\n0 1 0 0 0 0\r\n0 1 0 0 0 0\r\n0 0 0 1 0 0\r\n1 1 0 1 0 0\r\nObservam ca matricea de adiacenta:\r\n** are zerouri pe diagonala (daca in graf nu avem bucle)\r\n** nu este simetrica fata de diagonala principala\r\n\r\n	-> Pentru reprezentarea in memorie vom folosi un tablou bidimensional ale carui dimensiuni sunt in concordanta cu numarul de noduri din graf.\r\n\r\n	-> Consideram un graf cu maxim 50 de noduri. In C/C++ vom avea declaratia:  int A[51][51];\r\n\r\n\r\n	-> Lista de arce\r\n	Lista de arce a unui graf orientat reprezinta o multime (familie, daca arcele se pot repeta) ce contine toate arcele din graf.\r\n\r\n	Pentru graful alaturat, lista de arce este:\r\n\r\n		U={(1,6),(2,1),(2,4),(3,2),(4,2),(5,4),(6,1),(6,4)}\r\n\r\n	Pentru reprezentarea in memorie putem folosi:\r\n	- un tablou unidimensional cu elemente de tip struct {int I,J;}\r\n	- doua tablouri unidimensionale cu elemente de tip int\r\n	- o lista alocata dinamic\r\n	- etc.\r\n\r\n\r\n\r\n	-> Listele de adiacenta\r\n	Pentru un graf orientat cu G=(V,U) se va memora numarul de noduri n si apoi, pentru fiecare nod x, lista succesorilor lui x, adica nodurilor y cu proprietatea ca exista arcul (x,y).\r\n\r\n	Pentru graful alaturat, listele de adiacenta sunt:\r\n1: 6\r\n2: 1 4\r\n3: 2\r\n4: 2\r\n5: 4\r\n6: 1 2 4\r\nLa reprezentarea in memorie trebui avut in vedere ca dimensiunile listelor de succesori sunt variabile. De aceea, este neeficienta utilizarea unor tablouri alocate static. Astfel, putem folosi:\r\n\r\n	- un sir de n tablouri unidimensionale alocate dinamic;\r\n	- un sir de n vectori din STL;\r\n	- un sir de n liste simplu (dublu) inlantuite alocate dinamic.\r\n'),
(40, 'GO - Graf partial, subgraf', '	-> Definitie. Fie G=(V, U) un graf orientat. Se numeste graf partial al grafului G, graful orientat G1=(V, U1), unde U1 ? U.\r\n\r\n	-> Din definitie rezulta:\r\n	- Un graf partial al unui graf orientat G=(V,U), are aceeasi multime de varfuri ca si G, iar multimea arcelor este o submultime a lui U sau chiar U.\r\n	- Fie G=(V, U) un graf orientat. Un graf partial al grafului G, se obtine pastrand varfurile si eliminand eventual niste arce (se pot elimina si toate arcele sau chiar nici unul).\r\n\r\n\r\n\r\n	-> Definitie. Fie G=(V, U) un graf orientat. Se numeste subgraf al grafului G graful orientat G1=(V1,U1) unde V1 ? V iar U1 contine toate arcele din U care au extremitatile in V1.\r\n\r\n	->  Din definitie rezulta:\r\n	- Fie G=(V,U) un graf orientat. Un subgraf al grafului G, se obtine stergand eventual anumite varfuri si odata cu acestea si arcele care le admit ca extremitate (nu se pot sterge toate varfurile deoarece s-ar obtine un graf cu multimea varfurilor vida).\r\n'),
(41, 'GO - Graf complet. Graf turneu.', '	-> Definitie. Fie G=(V, U) un graf orientat. Graful G se numeste graf complet daca oricare doua varfuri distincte ale sale sunt adiacente.\r\n\r\n	-> Doua varfuri x si y sunt adiacente daca:\r\n		- intre ele exista arcul (x,y), sau\r\n		- intre ele exista arcul (y,x), sau\r\n		- intre ele exista arcele (x,y) si (y,x).\r\n\r\n\r\n	-> Teorema: Numarul de grafuri orientate complete cu n noduri este 3^(n*(n-1)/2).\r\n\r\n\r\n\r\n	-> Definitie: Un graf orientat este turneu, daca oricare ar fi doua varfuri i si j, i?j, intre ele exista un singur arc: arcul (i,j) sau arcul (j,i).\r\n\r\n	->  Proprietati:\r\n	1) Orice graf turneu este graf complet.\r\n	2) Avem 2n*(n-1)/2 grafuri turneu cu n noduri.\r\n	3) In orice graf turneu exista un drum elementar care trece prin toate varfurile grafului.\r\n'),
(42, 'GO - Conexitate', 'Lant. Drum\r\n	-> Definitie: Fie G=(V, U) un graf orientat. Se numeste lant, in graful G, o succesiune de arce, notata\r\nL = (u1 , u2 ,..., uk) cu proprietatea ca oricare doua arce consecutive au o extremitate comuna (nu are importanta orientarea arcelor).\r\n	sau\r\n\r\n	-> Definitie: Fie G=(V, U) un graf orientat. Se numeste lant, in graful G, o succesiune de noduri, notata\r\nL = (x1 , x2 ,..., xp) cu proprietatea ca oricare doua noduri consecutive sunt adiacente.\r\n\r\nLungimea unui lant este egala cu numarul de arce din care este alcatuit.\r\n\r\nPrimul nod si ultimul nod dintr-un lant formeaza extremitatile lantului.\r\n\r\n\r\n	->  Definitie. Fie G=(V, U) un graf orientat. Se numeste drum in graful G o succesiune de noduri, notata\r\nD = (x1 , x2 ,..., xk), cu proprietatea ca pentru orice 1=i<k, (xi,xi+1) este arc in G.\r\n\r\nLungimea unui drum este egala cu numarul de arce din care este alcatuit.\r\n\r\nPentru un drum D = (x1 , x2 ,..., xk), nodurile x1 si xk reprezinta extremitatile – initiala, respectiv finala.\r\n\r\nUn lant (drum) se numeste elementar daca in el nu se repeta noduri. Un lant (drum) se numeste simplu daca in el nu se repeta arce.\r\nExemple in graful alaturat\r\nL=(5,4,2,6,1) este un lant elementar, dar nu este drum.\r\nD=(3,2,1,6,4) este drum elementar.\r\nD=(3,2,1,6,2,4) este drum neelementar, dar simplu.\r\n\r\n\r\n	-> Definitie: Se numeste circuit un drum simplu in care extremitatea initiala si finala sunt egale. Se numeste circuit elementar un circuit in care, cu exceptia extremitatilor, nu se repeta noduri.\r\n\r\nLungimea unui circuit este reprezentata de numarul de arce din care acesta este alcatuit.\r\n\r\nExemple in graful alaturat:\r\n(1,6,2,1) si (1,6,4,2,1) sunt circuite elementare.\r\n'),
(43, 'GO - Tare conexitate', '	-> Definitii: Fie G=(V,U) un graf orientat.\r\n\r\n	-> Graful se numeste tare conex daca intre oricare doua noduri distincte exista cel putin un drum.\r\n\r\n	-> Se numeste componenta tare conexa un subgraf tare conex si maximal cu aceasta calitate – daca am mai adauga un nod, n-ar mai fi tare conex.\r\n\r\n	-> Graful din imagine nu este tare conex. El contine trei componente tare conexe: (1, 3, 4),  (2) si (5, 6, 7, 8).\r\n\r\n	-> Observatie: Un nod al grafului face parte dintr-o singura componenta tare conexa. Daca ar face parte din doua compoenente tare conexe, ele s-ar “reuni” prin intermediul acelui nod.\r\n'),
(44, 'GO - Graf hamiltonian. Graf eulerian', '	-> Definitii: Fie un graf orientat G=(V,U).\r\n\r\n	- Un drum elementar care contine toate nodurile grafului se numeste drum hamiltonian.\r\n	- Un circuit elementar care contine toate nodurile grafului se numeste circuit hamiltonian.\r\n	- Un graf care contine un circuit hamiltonian se numeste graf hamiltonian.\r\n\r\nExemplu: Graful orientat din imagine este hamiltonian, deoarece contine circuitul hamiltonian (2, 1, 5 , 6, 4, 3, 2).\r\n\r\n\r\n\r\n	-> Definitii: Fie un graf orientat G=(V,U).\r\n\r\n	- Un drum care contine toate arcele grafului se numeste drum eulerian.\r\n	- Un circuit care contine toate arcele grafului se numeste circuit eulerian.\r\n	- Un graf care contine un circuit eulerian se numeste graf eulerian.\r\n\r\n\r\n	-> Teorema: Un graf fara noduri izolate este eulerian daca si numai daca este conex si pentru fiecare nod, gradul interior este egal cu cel exterior.\r\n');

--
-- Indexuri pentru tabele eliminate
--

--
-- Indexuri pentru tabele `conturi`
--
ALTER TABLE `conturi`
  ADD PRIMARY KEY (`id`);

--
-- Indexuri pentru tabele `intrebari`
--
ALTER TABLE `intrebari`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`),
  ADD KEY `id_2` (`id`);

--
-- Indexuri pentru tabele `lectii`
--
ALTER TABLE `lectii`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pentru tabele eliminate
--

--
-- AUTO_INCREMENT pentru tabele `conturi`
--
ALTER TABLE `conturi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT pentru tabele `intrebari`
--
ALTER TABLE `intrebari`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pentru tabele `lectii`
--
ALTER TABLE `lectii`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
