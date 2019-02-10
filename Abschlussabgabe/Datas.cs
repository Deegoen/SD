using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Datas
    {
        public static void createDatas(Generator generator)
        {
            Dozent Waldowski = new Dozent("Michael", "Waldowski", new int[2] { 4, 5 });
            generator.allDozenten.Add(Waldowski); //0
            Dozent DellOro = new Dozent("Fridl", "Dell'Oro", new int[2] { 1, 2 });
            generator.allDozenten.Add(DellOro); //1
            Dozent Eisenbigler = new Dozent("Dirk", "Eisenbigler", new int[2] { 3, 4 });
            generator.allDozenten.Add(Eisenbigler);  //2
            Dozent Reusch = new Dozent("Matthias", "Reusch", new int[2] { 2, 3 });
            generator.allDozenten.Add(Reusch); //3
            Dozent Herbstreit = new Dozent("Achim", "Herbstreit", new int[2] { 4, 5 });
            generator.allDozenten.Add(Herbstreit); //4
            Dozent Schneider = new Dozent("Thomas", "Schneider", new int[2] { 3, 5 });
            generator.allDozenten.Add(Schneider); //5
            Dozent Hottong = new Dozent("Nikolaus", "Hottong", new int[2] { 1, 2 });
            generator.allDozenten.Add(Hottong); //6
            Dozent Dittler = new Dozent("Ullrich", "Dittler", new int[2] { 1, 5 });
            generator.allDozenten.Add(Dittler); //7
            Dozent Fries = new Dozent("Christian", "Fries", new int[2] { 2, 5 });
            generator.allDozenten.Add(Fries); //8
            Dozent Eberle = new Dozent("Christoph", "Eberle", new int[2] { 1, 2 });
            generator.allDozenten.Add(Eberle); //9
            Dozent Müller = new Dozent("Christoph", "Müller", new int[2] { 4, 5 });
            generator.allDozenten.Add(Müller);
            Dozent Dufner = new Dozent("Timo", "Dufner", new int[2] { 4, 5 });
            generator.allDozenten.Add(Dufner);
            Dozent Lasowski = new Dozent("Ruxandra", "Lasowski", new int[2] { 1, 5 });
            generator.allDozenten.Add(Lasowski);
            Dozent Krach = new Dozent("Thomas", "Krach", new int[2] { 2, 1 });
            generator.allDozenten.Add(Krach);
            Dozent Zydorek = new Dozent("Christoph", "Zydorek", new int[2] { 1, 3 });
            generator.allDozenten.Add(Zydorek);
            Dozent Anders = new Dozent("Jürgen", "Anders", new int[2] { 1, 5 });
            generator.allDozenten.Add(Anders);
            Dozent Unbekannt = new Dozent("Un", "Bekannt", new int[2] { 1, 5 });
            generator.allDozenten.Add(Unbekannt);
            Dozent Frieß = new Dozent("Regina", "Frieß", new int[2] { 2, 5 });
            generator.allDozenten.Add(Frieß);
            Dozent Timmalog = new Dozent("Philipp", "Timmalog", new int[2] { 4, 5 });
            generator.allDozenten.Add(Frieß);
            Dozent Ruf = new Dozent("Oliver", "Ruf", new int[2] { 1, 2 });
            generator.allDozenten.Add(Frieß);
            Dozent Taube = new Dozent("Wolfgang", "Taube", new int[2] { 3, 5 });
            generator.allDozenten.Add(Taube);
            Dozent Pietsch = new Dozent("Gotthard", "Pietsch", new int[2] { 1, 2 });
            generator.allDozenten.Add(Pietsch);
            Dozent Engenhart = new Dozent("Marc", "Engenhart", new int[2] { 3, 4 });
            generator.allDozenten.Add(Engenhart);



            //************************************************************************************* */
            //MIB
            //************************************************************************************* */

            Studium MIB1 = new Studium("MIB1", 35);
            generator.allStudys.Add(MIB1);
            Studium MIB2 = new Studium("MIB2", 30);
            generator.allStudys.Add(MIB2);
            Studium MIB4 = new Studium("MIB4", 12);
            generator.allStudys.Add(MIB4);
            Studium MIB5 = new Studium("MIB5", 12);
            generator.allStudys.Add(MIB5);
            Studium MIB6 = new Studium("MIB6", 10);
            generator.allStudys.Add(MIB6);

            //MIB1
            generator.allCourses.Add(new Course("PGR", "Programmieren", Eisenbigler, MIB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("AT", "Audiotechnik", Reusch, MIB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("BWL", "Grundlagen der Betriebswirtschaftslehre", Herbstreit, MIB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("PGR PR", "Programmieren Praktikum", Eisenbigler, MIB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("BWL PR", "Grundlagen der Betriebswirtschaftslehre Praktikum", Herbstreit, MIB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("MatMedInf1", "Mathematik in Medien und Informatik 1", Schneider, MIB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("VideoTech", "Videotechnik", Hottong, MIB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("MedTechPra", "Medientechnik Praktikum", Hottong, MIB1, new List<Conditions>() { Conditions.Fernsehstudio }));
            generator.allCourses.Add(new Course("MedPsych", "Medienpsychologie", Dittler, MIB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("PhysMedInf", "Physik in Medien und Informatik", Schneider, MIB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("MINT-Pra", "MINT-Praktikum", Schneider, MIB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("GrMedGest", "Grundlagen Mediengestaltung", Fries, MIB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("GrMedGestPra", "Grundlagen Mediengestaltung Praktikum", Eberle, MIB1, new List<Conditions>() { Conditions.Normal }));

            //MIB2
            generator.allCourses.Add(new Course("MathSimSem", "Mathematik und Simulation Seminar", Schneider, MIB2, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("ComGra", "Computergrafik Vorlesung", Müller, MIB2, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("GIS", "Grundlagen Interaktiver Systeme", Dufner, MIB2, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("MathSim", "Mathematik und Simulation", Lasowski, MIB2, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("MathSimPra", "Mathematik und Simulation Praktikum", Lasowski, MIB2, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("GIS Pra", "Grundlagen Interaktiver Systeme Praktikum", Dufner, MIB2, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("UsExDe", "User Experience Design Vorlesung", Krach, MIB2, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("ComGraPra", "Computergrafik Praktikum", Müller, MIB2, new List<Conditions>() { Conditions.Computer }));
            generator.allCourses.Add(new Course("MedÖko", "Medienökonomie", Zydorek, MIB2, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("Mark", "Marketing", Zydorek, MIB2, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("UsExDeSe", "User Experience Design Seminar", Krach, MIB2, new List<Conditions>() { Conditions.Normal }));

            //MIB4
            generator.allCourses.Add(new Course("GDV", "Grafische Datenverarbeitung 1", Waldowski, MIB4, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("SWD Se", "Softwaredesign Seminar", DellOro, MIB4, new List<Conditions> { Conditions.Computer }));
            generator.allCourses.Add(new Course("GrafDV", "Grafische Datenverarbeitung 2", Waldowski, MIB4, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("GrafDV Üb", "Grafische Datenverarbeitung Übung", Waldowski, MIB4, new List<Conditions> { Conditions.Computer }));
            generator.allCourses.Add(new Course("KoSy", "Kommunikationssysteme", Waldowski, MIB4, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("PrStu", "Projektstudium", Krach, MIB4, new List<Conditions> { Conditions.Normal })); //Dozent? Eig variabel
            generator.allCourses.Add(new Course("SWD Pra", "Softwaredesign Praktikum", DellOro, MIB4, new List<Conditions> { Conditions.Computer }));
            generator.allCourses.Add(new Course("KoSy Pra", "Kommunikationssysteme Praktikum", Anders, MIB4, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("PrStud Vor", "Projektstudium Vorlesung", Zydorek, MIB4, new List<Conditions> { Conditions.Vorlesungssaal }));

            //MIB5
            generator.allCourses.Add(new Course("DaVerMePro", "Datenverarbeitung in der Medienproduktion", Müller, MIB5, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("VerAnw", "Verteilte Anwendungen", Eisenbigler, MIB5, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("VerAnw Pra", "Verteilte Anwendungen Praktikum", Eisenbigler, MIB5, new List<Conditions> { Conditions.Computer }));
            generator.allCourses.Add(new Course("DigAvTec", "Digitale AV-Technik", Hottong, MIB5, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("PrStud", "Projektstudium", Krach, MIB5, new List<Conditions> { Conditions.Normal })); //Dozent? Variabel

            //MIB6
            generator.allCourses.Add(new Course("ITuMedpro", "IT und Medienproduktion", Zydorek, MIB6, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("FreSpr", "Fremdsprachenmodul", Unbekannt, MIB6, new List<Conditions> { Conditions.Vorlesungssaal }));



            //************************************************************************************* */
            //OMB
            //************************************************************************************* */
            Studium OMB1 = new Studium("OMB1", 40);
            generator.allStudys.Add(OMB1);
            Studium OMB2 = new Studium("OMB2", 30);
            generator.allStudys.Add(OMB2);
            Studium OMB4 = new Studium("OMB4", 35);
            generator.allStudys.Add(OMB4);
            Studium OMB5 = new Studium("OMB5", 33);
            generator.allStudys.Add(OMB5);
            Studium OMB6 = new Studium("OMB6", 33);
            generator.allStudys.Add(OMB6);

            //OMB1
            generator.allCourses.Add(new Course("AT", "Audiotechnik", Reusch, OMB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("BWL", "Grundlagen der Betriebswirtschaftslehre", Herbstreit, OMB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("BWL PR", "Grundlagen der Betriebswirtschaftslehre Praktikum", Herbstreit, OMB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("MatMedInf1", "Mathematik in Medien und Informatik 1", Schneider, OMB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("VideoTech", "Videotechnik", Schneider, OMB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("MedTechPra", "Medientechnik Praktikum", Waldowski, OMB1, new List<Conditions>() { Conditions.Fernsehstudio }));
            generator.allCourses.Add(new Course("MedPsych", "Medienpsychologie", Dittler, OMB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("PhysMedInf", "Physik in Medien und Informatik", Schneider, OMB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("MINT-Pra", "MINT-Praktikum", Schneider, OMB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("GrMedGest", "Grundlagen Mediengestaltung", Fries, OMB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("GrMedGestPra", "Grundlagen Mediengestaltung Praktikum", Eberle, OMB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("ProgVor", "Programmierung Vorlesung", Taube, OMB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("ProgPra", "Programmierung Praktikum", Taube, OMB1, new List<Conditions>() { Conditions.Computer }));

            //OMB2
            generator.allCourses.Add(new Course("AVProdPra", "AV-Produktion Praktikum", Reusch, OMB2, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("AV Prod", "AV-Produktion", Reusch, OMB2, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("GIS", "Grundlagen Interaktiver Systeme", Taube, OMB2, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("GeStMoVo", "Geometrische und statistische Modellierung", Schneider, OMB2, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("GeStMoVoPr", "Geometrische und statistische Modellierung Praktikum", Schneider, OMB2, new List<Conditions>() { Conditions.Computer }));
            generator.allCourses.Add(new Course("GIS Pra", "Grundlagen Interaktiver Systeme Praktikum", Taube, OMB2, new List<Conditions>() { Conditions.Computer }));
            generator.allCourses.Add(new Course("UsExDe", "User Experience Design Vorlesung", Krach, OMB2, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("ComGraPra", "Computergrafik Praktikum", Müller, OMB2, new List<Conditions>() { Conditions.Computer }));
            generator.allCourses.Add(new Course("MedÖko", "Medienökonomie", Zydorek, OMB2, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("Mark", "Marketing", Zydorek, OMB2, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("UsExDeSe", "User Experience Design Seminar", Krach, OMB2, new List<Conditions>() { Conditions.Normal }));

            //OMB4
            generator.allCourses.Add(new Course("WebTech", "Webtechnologien", Anders, OMB4, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("ResWebDes", "Responsive Webdesign", Krach, OMB4, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("ResWebDesPra", "Responsive Webdesign Praktikum", Krach, OMB4, new List<Conditions> { Conditions.Computer }));
            generator.allCourses.Add(new Course("E-Bus", "E-Business", Pietsch, OMB4, new List<Conditions> { Conditions.Computer }));
            generator.allCourses.Add(new Course("WebTechPra", "Webtechnologie Praktikum", Anders, OMB4, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("PrStu", "Projektstudium", Krach, OMB4, new List<Conditions> { Conditions.Normal })); //Dozent? Eig variabel
            generator.allCourses.Add(new Course("MedMomWi", "Medien und Kommunikationswirtschaft", Zydorek, OMB4, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("PrStud Vor", "Projektstudium Vorlesung", Zydorek, OMB4, new List<Conditions> { Conditions.Vorlesungssaal }));

            //OMB5
            generator.allCourses.Add(new Course("IntDesVor", "Interface Design", Engenhart, OMB5, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("IntDesPra", "Interface Design Praktikum", Engenhart, OMB5, new List<Conditions> { Conditions.Computer }));
            generator.allCourses.Add(new Course("SteAnwPra", "Streaming Anwendungen Praktikum", Hottong, OMB5, new List<Conditions> { Conditions.Computer }));
            generator.allCourses.Add(new Course("StrAnw", "Streaming Anwendungen", Hottong, OMB5, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("PrStud", "Projektstudium", Krach, OMB5, new List<Conditions> { Conditions.Normal })); //Dozent? Variabel

            //OMB6
            generator.allCourses.Add(new Course("OnPrOnMark", "Online Produktmanagement und Online Marketing", Pietsch, OMB6, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("FreSpr", "Fremdsprachenmodul", Unbekannt, MIB6, new List<Conditions> { Conditions.Vorlesungssaal }));




            //************************************************************************************* */
            //MKB
            //************************************************************************************* */
            Studium MKB1 = new Studium("MKB1", 35);
            generator.allStudys.Add(MKB1);
            Studium MKB2 = new Studium("MKB2", 33);
            generator.allStudys.Add(MKB2);
            Studium MKB4 = new Studium("MKB4", 32);
            generator.allStudys.Add(MKB4);
            Studium MKB5 = new Studium("MKB5", 32);
            generator.allStudys.Add(MKB5);
            Studium MKB6 = new Studium("MKB6", 20);
            generator.allStudys.Add(MKB6);
            Studium MKB7 = new Studium("MKB7", 18);
            generator.allStudys.Add(MKB7);

            //MKB1
            generator.allCourses.Add(new Course("AT", "Audiotechnik", Reusch, MKB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("BWL", "Grundlagen der Betriebswirtschaftslehre", Herbstreit, MKB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("PGR PR", "Programmieren Praktikum", Eisenbigler, MKB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("MedAn", "Medienanlayse Vorlesung", Frieß, MKB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("GrdMedKonS", "Grundlagen der Medienkonzeption Seminar", Frieß, MKB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("VideoTech", "Videotechnik", Schneider, MKB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("MedPsych", "Medienpsychologie", Dittler, MKB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("EnInAn1VL", "Entwicklung Interaktiver Anwendungen 1 Vorlesung", Timmalog, MKB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("EnInAn1PR", "Entwicklung Interaktiver Anwendungen 1 Praktikum", Timmalog, MKB1, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("GrMedGest", "Grundlagen Mediengestaltung", Fries, MKB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("GrMedGestPra", "Grundlagen Mediengestaltung Praktikum", Fries, MKB1, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("MedTechPra", "Medientechnik Praktikum", Waldowski, MKB1, new List<Conditions>() { Conditions.Fernsehstudio }));

            //MKB2
            generator.allCourses.Add(new Course("MaGrCGGe", "Mathematische Grundlangen von Computergrafik und Gestaltung", Schneider, MKB2, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("AVProdPra", "AV-Produktion Praktikum", Reusch, MKB2, new List<Conditions>() { Conditions.Fernsehstudio }));
            generator.allCourses.Add(new Course("AVProdukt", "AV-Produktion Vorlesung", Reusch, MKB2, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("EnInAn2", "Entwicklung Interaktiver Anwendungen 2", DellOro, MKB2, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("EnInAn2Pra", "Entwicklung Interaktiver Anwendungen 2 Praktikum", DellOro, MKB2, new List<Conditions>() { Conditions.Computer }));
            generator.allCourses.Add(new Course("CoGr3DMPR", "Computergrafik und 3D Modellierung Praktikum", Müller, MKB2, new List<Conditions>() { Conditions.Computer }));
            generator.allCourses.Add(new Course("UsExDe", "User Experience Design Vorlesung", Krach, MKB2, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("MedÖko", "Medienökonomie", Zydorek, MKB2, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("Mark", "Marketing", Zydorek, MKB2, new List<Conditions>() { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("UsExDeSe", "User Experience Design Seminar", Krach, MKB2, new List<Conditions>() { Conditions.Normal }));

            //MKB4
            generator.allCourses.Add(new Course("ELeOnLe", "E-Learning und Online-Learning Vorlesung", Dittler, MKB4, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("ELeOnLeÜb", "E-Learning und Online-Learning Übung", Dittler, MKB4, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("Konz", "Konzeption", Frieß, MKB4, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("Identw", "Ideenentwicklung", Fries, MKB4, new List<Conditions>() { Conditions.Normal }));
            generator.allCourses.Add(new Course("PrStu", "Projektstudium", Krach, MKB4, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("PrStud Vor", "Projektstudium Vorlesung", Zydorek, MIB4, new List<Conditions> { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("CreaWr", "Creativ Writing", Ruf, MKB4, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("Stortell", "Storytelling", Ruf, MKB4, new List<Conditions> { Conditions.Normal }));

            //MKB5
            generator.allCourses.Add(new Course("OpMark", "Operatives Marketing", Pietsch, MKB5, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("IntDesVor", "Interface Disign Vorlesung", Krach, MKB5, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("IntDesPra", "Interface Disign Praktikum", Krach, MKB5, new List<Conditions> { Conditions.Normal }));
            generator.allCourses.Add(new Course("PrStu", "Projektstudium", Krach, MKB5, new List<Conditions> { Conditions.Normal }));

            //MKB6
            generator.allCourses.Add(new Course("MedTheo", "Medientheorie", Frieß, MIB6, new List<Conditions> { Conditions.Vorlesungssaal }));
            generator.allCourses.Add(new Course("FreSpr", "Fremdsprachenmodul", Unbekannt, MIB6, new List<Conditions> { Conditions.Vorlesungssaal }));

 

            //ROOMS
            generator.allRooms.Add(new Room("I0.01", 30, new List<Conditions> { Conditions.Normal }));
            generator.allRooms.Add(new Room("L1.01", 30, new List<Conditions> { Conditions.Computer }));
            generator.allRooms.Add(new Room("L1.06a", 40, new List<Conditions> { Conditions.Normal }));
            generator.allRooms.Add(new Room("I0.15", 90, new List<Conditions> { Conditions.Vorlesungssaal }));
            generator.allRooms.Add(new Room("I0.16", 90, new List<Conditions> { Conditions.Vorlesungssaal }));
            generator.allRooms.Add(new Room("L2.07a", 40, new List<Conditions> { Conditions.Computer }));
            generator.allRooms.Add(new Room("I0.14", 40, new List<Conditions> { Conditions.Vorlesungssaal }));
            generator.allRooms.Add(new Room("I1.20", 40, new List<Conditions> { Conditions.Normal }));
            generator.allRooms.Add(new Room("I2.21", 40, new List<Conditions> { Conditions.Normal }));
            generator.allRooms.Add(new Room("L2.07a", 40, new List<Conditions> { Conditions.Computer }));
            generator.allRooms.Add(new Room("I0.17", 90, new List<Conditions> { Conditions.Vorlesungssaal }));
            generator.allRooms.Add(new Room("I0.13", 40, new List<Conditions> { Conditions.Normal }));
            generator.allRooms.Add(new Room("L1.05a", 40, new List<Conditions> { Conditions.Normal }));
            generator.allRooms.Add(new Room("C0.02", 50, new List<Conditions> { Conditions.Vorlesungssaal }));
            generator.allRooms.Add(new Room("L2.08", 40, new List<Conditions> { Conditions.Computer }));
            generator.allRooms.Add(new Room("A3.11", 40, new List<Conditions> { Conditions.Normal }));
            generator.allRooms.Add(new Room("N1.01", 45, new List<Conditions> { Conditions.Fernsehstudio }));

            generator.allRooms.Add(new Room("N1.06", 50, new List<Conditions> { Conditions.Fernsehstudio }));
            generator.allRooms.Add(new Room("A2.05", 50, new List<Conditions> { Conditions.Normal }));


        }
    }
}